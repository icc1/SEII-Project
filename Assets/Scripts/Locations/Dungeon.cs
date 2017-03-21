using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Locations
{
    abstract class Dungeon : Location
    {
        private int enemyPoolSize;
        private int minEnemies;
        private int maxEnemies;
        public int EnemyPoolSize
        {
            get
            {
                return EnemyPoolSize;
            }

            set
            {
                EnemyPoolSize = value;
            }
        }

        public int MinEnemies
        {
            get
            {
                return MinEnemies;
            }

            set
            {
                MinEnemies = value;
            }
        }

        public int MaxEnemies
        {
            get
            {
                return MaxEnemies;
            }

            set
            {
                MaxEnemies = value;
            }
        }
    }
}
