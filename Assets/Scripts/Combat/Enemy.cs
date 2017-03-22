using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Enemy : CombatCapable, IEnemy
    {
        private int enemyID;
        private int enemyRarity;
        private Location.Type spawnLocation;
    }
}
