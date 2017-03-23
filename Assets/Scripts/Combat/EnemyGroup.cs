using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class EnemyGroup : IEnemyGroup
    {
        private LinkedList<IEnemyNPC> enemies;

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
