using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class EnemyNPC : Stats, IEnemyNPC
    {
        private int enemyID;
        private String enemyName;
        private String enemySprite;
        private Location.Type enemySpawnLocation;
        

        public EnemyNPC(int enemyID, String enemyName, String enemySprite, Location.Type enemySpawnLocation,
            int enemyAttack, int enemyHealth, int enemyDefense, int enemySpeed)
        {
            this.enemyID = enemyID;
            this.enemyName = enemyName;
            this.enemySprite = enemySprite;
            this.enemySpawnLocation = enemySpawnLocation;
            setStats(enemyAttack, enemyHealth, enemyDefense, enemySpeed);
        }

        public int EnemyID
        {
            get
            {
                return enemyID;
            }

            set
            {
                enemyID = value;
            }
        }

        public String EnemyName
        {
            get
            {
                return enemyName;
            }

            set
            {
                enemyName = value;
            }
        }
        public Location.Type EnemySpawnLocation
        {
            get
            {
                return enemySpawnLocation;
            }

            set
            {
                enemySpawnLocation = value;
            }
        }
        public String EnemySprite
        {
            get
            {
                return enemySprite;
            }

            set
            {
                enemySprite = value;
            }
        }

    }
}
