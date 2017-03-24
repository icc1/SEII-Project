using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat_Interfaces
{
    interface IEnemyNPC : IStats
    {
        int EnemyID { get; set; }
        String EnemyName { get; set; }
        Location.Type EnemySpawnLocation { get; set; }
        String EnemySprite { get; set; }
    }
}
