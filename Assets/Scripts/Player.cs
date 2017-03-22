using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts 
{
    class Player : CombatCapable, IPlayer
    {
        Location.Type currentLocation;

        public Location.Type CurrentLocation
        {
            get
            {
                return currentLocation;
            }
            set
            {
                currentLocation = value;
            }
        }
    }
}
