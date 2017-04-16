using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat_Interfaces
{
    interface INPC : IStats
    {
        String NPCName { get; set; }
        Location.Type NPCSpawnLocation { get; set; }
        String NPCSprite { get; set; }
    }
}
