using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Combat.Enemies
{
    class EnemyInfo : MonoBehaviour
    {
        public IEnemyNPC findEnemy(int spawnRoll, Location.Type dungeon)
        {

        }

        private ArrayList enemyList = new ArrayList();

        private populateList()
        {

        }

        void Start()
        {
            populateList();
        } 
    }
}
