using Assets.Scripts.Combat.Combat_UI;
using Assets.Scripts.Combat_Interfaces;
using Assets.Scripts.InfoManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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
        public ButtonManager buttonManager;

        void Start()
        {
            currentState = CombatStates.START;
            PlayerStats tmpStats = (PlayerStats)GameObject.FindGameObjectWithTag("Player").GetComponent(typeof(PlayerStats));
            player = tmpStats.getStats();
            enemyGroup = EnemyInfo.generateEnemyGroup(Location.Type.DUNGEON1);

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
                    processPlayerMoves();
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
        void processPlayerMoves()
        {
            if(buttonManager.getSelected() != PlayerChoice.NONE)
            {
                switch(buttonManager.getSelected())
                {
                    case (PlayerChoice.ATTACK):
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
    }
}
