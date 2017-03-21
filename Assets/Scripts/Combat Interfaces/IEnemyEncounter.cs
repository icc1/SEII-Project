using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface IEnemyEncounter
    {
        bool enemyEncountered();
        IEnemyGroup getEnemyGroup();
    }
}
