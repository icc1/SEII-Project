using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Combat
{
    class PlayerStats : MonoBehaviour
    {
        IPlayer player;
        void Start()
        {
            player = new Player();
        }
        public IPlayer getStats()
        {
            return player;
        }
    }
}
