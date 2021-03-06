﻿using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Combat
{
    class Player : Stats, IPlayer
    {
        Location.Type currentLocation;

        public Player()
        {
            setStats(10, 10, 10, 10);
        }

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
