using Assets.Scripts.Combat.Combat_UI;
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
                    for(int i = 0; i < 4; i++)
                    {
                        processPlayerMoves(i);
                    }
                    break;
                case (CombatStates.ENEMYCHOICE):
                    processEnemyMoves();
                    break;
                case (CombatStates.WIN):
                    processWin();
                    break;
                case (CombatStates.LOSE):
                    processLose();
                    break;
            }
        }
        void processPlayerMoves(int playerPartyMember)
        {
            if(buttonManager.getSelected() != PlayerChoice.NONE)
            {
                switch(buttonManager.getSelected())
                {
                    case (PlayerChoice.ATTACK):
                        printToBattleLog("Click an enemy to attack...");
                        Debug.Log("Player Attacks");
                        //attack
                        break;
                    case (PlayerChoice.DEFEND):
                        Debug.Log("Player Defends");
                        //defend
                        break;
                    case (PlayerChoice.RUN):
                        Debug.Log("Player Runs");
                        //try to run
                        break;
                    case (PlayerChoice.INVENTORY):
                        Debug.Log("Player Opens Inventory");
                        //load inv
                        break;
                }
            }
        }
        void processPlayerAttack()
        {

        }
        void processEnemyMoves()
        {
            Debug.Log("Enemy Turn");
        }
        void processWin()
        {
            Debug.Log("Win!");
        }
        void processLose()
        {
            Debug.Log("Lose!");
        }
        bool playerIsFaster()
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
    }
}
