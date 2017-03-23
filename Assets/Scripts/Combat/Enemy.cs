using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class EnemyNPC : Stats, IEnemyNPC
    {
        private int enemyID;
        private int enemyRarity;
        private Location.Type spawnLocation;
        private String spriteName;
    }
}
