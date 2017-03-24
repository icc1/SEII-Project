using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class EnemyNPCGroup : IEnemyNPCGroup
    {
        private LinkedList<IEnemyNPC> enemies;

        public int getNumberOfEnemies()
        {
            return enemies.Count;
        }

        public IEnemyNPC getEnemy(int enemyNo)
        {
            return enemies.ElementAt(enemyNo);
        }

        public void addEnemy(IEnemyNPC newEnemy)
        {
            enemies.AddLast(newEnemy);
        }

        public void removeEnemy(int enemyNo)
        {
            enemies.Remove(enemies.ElementAt(enemyNo));
        }
    }
}
