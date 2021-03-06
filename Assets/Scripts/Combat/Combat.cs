﻿using Assets.Scripts.Combat.Combat_UI;
using Assets.Scripts.Combat_Interfaces;
using Assets.Scripts.InfoManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Combat
{
    public class Combat : MonoBehaviour
    {
        public enum CombatStates
        {
            START,
            PLAYERCHOICE,
            ENEMYCHOICE,
            WIN,
            LOSE
        }
        public enum PlayerChoice
        {
            ATTACK,
            DEFEND,
            RUN,
            INVENTORY,
            NONE
        }

        private CombatStates currentState;
        private IEnemyNPCGroup enemyGroup;
        private IPlayer player;
        private Text battleLog;
        private System.Random combatRand;

        public ButtonManager buttonManager;


        void Start()
        {
            currentState = CombatStates.START;
            PlayerScript tmpStats = (PlayerScript)GameObject.FindGameObjectWithTag("Player").GetComponent(typeof(PlayerScript));
            player = tmpStats.getStats();
            enemyGroup = EnemyInfo.generateEnemyGroup(Location.Type.DUNGEON1);
            battleLog = (Text)GameObject.FindGameObjectWithTag("BattleLog").GetComponent(typeof(Text));
            battleLog.text = "Battle Started!";
            buttonManager = GetComponent<ButtonManager>();
        }
        
        void Update()
        {
            switch(currentState)
            {
                case (CombatStates.START):
                    if (playerIsFaster())
                    {
                        currentState = CombatStates.PLAYERCHOICE;
                    }
                    else
                    {
                        currentState = CombatStates.ENEMYCHOICE;
                    }
                    break;
                case (CombatStates.PLAYERCHOICE):
                    for(int i = 0; i < 4; i++)//replace the 4 with number of party memebers + player
                    {
                        processPlayerMoves(i);
                    }
                    break;
                case (CombatStates.ENEMYCHOICE):
                    for(int i = 0; i < enemyGroup.getNumberOfEnemies(); i++)
                    {
                        processEnemyMoves(i);
                    }
                    break;
                case (CombatStates.WIN):
                    processWin();
                    break;
                case (CombatStates.LOSE):
                    processLose();
                    break;
            }
        }

        void processPlayerMoves(int playerPartyIndex)
        {
            if(buttonManager.getSelectedButton() != PlayerChoice.NONE)
            {
                switch(buttonManager.getSelectedButton())
                {
                    case (PlayerChoice.ATTACK):
                        processPlayerAttack(playerPartyIndex);
                        break;
                    case (PlayerChoice.DEFEND):
                        if(playerPartyIndex == 0)
                        {
                            player.IsDefending = true;
                            printDefense(player.Name);
                        }
                        else
                        {
                            //set teammate to defend using playerPartyMemebr index
                        }
                        break;
                    case (PlayerChoice.RUN):
                        if (playerIsFaster())
                        {
                            printToBattleLog("You ran away successfully!");
                            //exit battle
                        }
                        else
                        {
                            printToBattleLog("You wasted your turn trying to run away from a faster enemy!");
                            currentState = CombatStates.ENEMYCHOICE;
                        }
                        break;
                    case (PlayerChoice.INVENTORY):
                        Debug.Log("Player Opens Inventory");
                        //load inv
                        break;
                }
                buttonManager.setSelectedButton((int)PlayerChoice.NONE);
            }
        }

        private void processPlayerAttack(int playerPartyIndex)
        {
            printToBattleLog("Click an enemy to attack...");
            int selectedEnemyIndex = buttonManager.getSelectedEnemy();
            IEnemyNPC selectedEnemy = enemyGroup.getEnemy(selectedEnemyIndex);
            int damage = getDamage(player.Attack, selectedEnemy.IsDefending, selectedEnemy.Defense);//this line has player reference, needs to be generalized to player or npc companions
            selectedEnemy.Health -= damage;
            printDamage(selectedEnemy.Name, damage);
            if (selectedEnemy.Health <= 0)
            {
                killEnemy(selectedEnemyIndex);
                enemyGroup.removeEnemy(selectedEnemyIndex);
                checkIfWin();
            }
            else
            {
                currentState = CombatStates.ENEMYCHOICE;
            }
        }

        private void processEnemyMoves(int enemyIndex)
        {
            IEnemyNPC currentEnemy = enemyGroup.getEnemy(enemyIndex);
            int roll = combatRand.Next(0, 3);
            if((((double)currentEnemy.Health/(double)currentEnemy.MaxHealth) < .4) && (roll > 0))
            {
                currentEnemy.IsDefending = true;
            }
            else if(roll > 0)
            {
                processEnemyAttack(currentEnemy);
            }
            else
            {
                currentEnemy.IsDefending = true;
            }
            if (currentEnemy.IsDefending)
            {
                printDefense(currentEnemy.Name);
            }
        }

        private void processEnemyAttack(IEnemyNPC currentEnemy)
        {
            int roll = combatRand.Next(0, 1);//add count of allies to this
            if(roll == 0)
            {
                int damage = getDamage(currentEnemy.Attack, player.IsDefending, player.Defense);
                player.Health -= damage;
                printDamage(player.Name, damage);
            }
            else
            {
                //attack party members
            }
        }

        private void processWin()
        {
            Debug.Log("Win!");
            //Give loot
            //Return to dungeon
        }

        private void processLose()
        {
            Debug.Log("Lose!");
            //Show game over
            //Return to town
        }

        private bool playerIsFaster()
        {
            int fastestEnemy = 0;
            int fastestTeammate = 0;

            for (int i = 0; i < enemyGroup.getNumberOfEnemies(); i++)
            {
                Debug.Log(enemyGroup.getNumberOfEnemies());
                Debug.Log(i);
                Debug.Log(enemyGroup.getEnemy(i).GetType());
                if(enemyGroup.getEnemy(i).Speed > fastestEnemy)
                {
                    fastestEnemy = enemyGroup.getEnemy(i).Speed;
                }
            }

            if(player.Speed > fastestTeammate)
            {
                fastestTeammate = player.Speed;
            }

            if (fastestTeammate > fastestEnemy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void printToBattleLog(String newLine)
        {
            battleLog.text = battleLog.text + "\n" + newLine;
        }

        private void printDamage(String target, int damage)
        {
            if(damage < 0)
            {
                printToBattleLog(target + " took no damage...");
            }
            else
            {
                printToBattleLog(target + " took " + damage + " points of damage!");
            }
        }

        private void printDefense(String name)
        {
            printToBattleLog(name + " is defending");
        }

        private void checkIfWin()
        {
            if(enemyGroup.getNumberOfEnemies() == 0)
            {
                currentState = CombatStates.WIN;
            }
        }

        private void killEnemy(int enemyIndex)
        {

        }

        private int getDamage(int baseDamage, bool isDefending, int targetDefense)
        {
            int finalDamage = baseDamage;
            int roll = combatRand.Next(0, 20);
            if(roll == 19)
            {
                finalDamage = baseDamage * 2;
                printToBattleLog("Critical hit!");
            }
            else if(roll < 4)
            {
                finalDamage = baseDamage / 2;
                printToBattleLog("Near miss!");
            }
            if (isDefending)
            {
                finalDamage -= targetDefense;
                printToBattleLog("The target was defending and took less damage...");
            }
            if(finalDamage < 0)
            {
                return 0;
            }
            else
            {
                return finalDamage;
            }
        }
    }
}
