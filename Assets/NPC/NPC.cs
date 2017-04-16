using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class NPC : Stats, INPC
    {
        private String npcName;
        private String npcSprite;
        private Location.Type npcSpawnLocation;

        public NPC(String NPCName, String NPCSprite, Location.Type NPCSpawnLocation,
            int NPCAttack, int NPCHealth, int NPCDefense, int NPCSpeed)
        {
            this.NPCName = NPCName;
            this.NPCSprite = NPCSprite;
            this.NPCSpawnLocation = NPCSpawnLocation;
            setStats(NPCAttack, NPCHealth, NPCDefense, NPCSpeed);
        }
        public String NPCName
        {
            get
            {
                return npcName;
            }

            set
            {
                npcName = value;
            }
        }
        public Location.Type NPCSpawnLocation
        {
            get
            {
                return npcSpawnLocation;
            }

            set
            {
                npcSpawnLocation = value;
            }
        }
        public String NPCSprite
        {
            get
            {
                return npcSprite;
            }

            set
            {
                npcSprite = value;
            }
        }
    }
}
