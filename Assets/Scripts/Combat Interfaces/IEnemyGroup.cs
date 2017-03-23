using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface IEnemyGroup
    {
        IEnemyNPC getEnemy(int enemyNo);
        void addEnemy(IEnemyNPC newEnemy);
    }
}
