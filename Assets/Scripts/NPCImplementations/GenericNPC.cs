using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.NPCInterfaces;

namespace Assets.Scripts
{
    class GenericNPC : Stats, IGenericNPC
    {
        private int genericNPCID;
        private String genericNPCName;
        private String genericNPCSprite;
        private Location.Type genericNPCSpawnLocation;


        public GenericNPC(int genericNPCID, String genericNPCName, String genericNPCSprite, Location.Type genericNPCLocation,
            int genericNPCAttack, int genericNPCHealth, int genericNPCDefense, int genericNPCSpeed)
        {
            this.genericNPCID = genericNPCID;
            this.genericNPCName = genericNPCName;
            this.genericNPCSprite = genericNPCSprite;
            this.genericNPCSpawnLocation = genericNPCLocation;
            setStats(genericNPCAttack, genericNPCHealth, genericNPCDefense, genericNPCSpeed);
        }

        public int GenericNPCID
        {
            get
            {
                return genericNPCID;
            }

            set
            {
                genericNPCID = value;
            }
        }

        public String GenericNPCName
        {
            get
            {
                return genericNPCName;
            }

            set
            {
                genericNPCName = value;
            }
        }
        public Location.Type GenericNPCSpawnLocation
        {
            get
            {
                return genericNPCSpawnLocation;
            }

            set
            {
                genericNPCSpawnLocation = value;
            }
        }
        public String GenericNPCSprite
        {
            get
            {
                return genericNPCSprite;
            }

            set
            {
                genericNPCSprite = value;
            }
        }

    }
}
