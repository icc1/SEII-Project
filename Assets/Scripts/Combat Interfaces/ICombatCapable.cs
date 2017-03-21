using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface ICombatCapable
    {
        int Attack { get; set; }
        int Health { get; set; }
        int Defense { get; set; }
        int Speed { get; set; }

        void setStats(int newAttack, int newHealth, int newDefense, int newSpeed);
    }
}
