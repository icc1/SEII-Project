using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat_Interfaces
{
    interface IEnemyGroup
    {
        IEnemyNPC getEnemy(int enemyNo);
        void addEnemy(IEnemyNPC newEnemy);
    }
}
