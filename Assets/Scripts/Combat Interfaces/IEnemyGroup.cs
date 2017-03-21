using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface IEnemyGroup
    {
        IEnemy getEnemy(int enemyNo);
        void addEnemy(IEnemy newEnemy);
    }
}
