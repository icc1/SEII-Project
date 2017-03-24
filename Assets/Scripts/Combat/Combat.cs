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

        private CombatStates currentState;
        private IEnemyNPCGroup enemyGroup;
        private IPlayer player;

        void Start()
        {
            currentState = CombatStates.START;

            player = GameObject.FindGameObjectWithTag("Player").GetComponent(typeof(Player)) as Player;
            enemyGroup = EnemyInfo.generateEnemyGroup(player.CurrentLocation);
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

        }
        void processEnemyMoves()
        {

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

            for(int i = 0; i < enemyGroup.getNumberOfEnemies(); i++)
            {
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
