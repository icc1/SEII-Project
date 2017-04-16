using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Combat_Interfaces;


    public interface INpc : IStats
    {
        String NPCName { get; set; }
        Location.Type NPCSpawnLocation { get; set; }
        String NPCSprite { get; set; }
        int DefaultSpriteNumber { get; set;}
    }
