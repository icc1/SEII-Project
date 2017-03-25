using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Combat_Interfaces;
using Assets.Scripts.InfoManagers;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Combat
{
    class EnemyEncounter : IEnemyEncounter
    {
        public EnemyEncounter()
        {
            System.Random encounterRand = new System.Random();
            int chanceOfEncounter = 1;

            int encounter = encounterRand.Next(0, 100);
            if (encounter <= chanceOfEncounter)
                initializeCombat();
        }
        private void initializeCombat()
        {
            //SceneManager.LoadScene("Scenes/battle", LoadSceneMode.Additive);
        }
    }
}