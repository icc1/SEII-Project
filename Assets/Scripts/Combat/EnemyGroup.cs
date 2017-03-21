using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class EnemyGroup : IEnemyGroup
    {
        private LinkedList<IEnemy> enemies;

        public IEnemy getEnemy(int enemyNo)
        {
            return enemies.ElementAt(enemyNo);
        }

        public void addEnemy(IEnemy newEnemy)
        {
            enemies.AddLast(newEnemy);
        }

        public void removeEnemy(int enemyNo)
        {
            enemies.Remove(enemies.ElementAt(enemyNo));
        }
    }
}
