using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat_Interfaces
{
    public interface IStats
    {
        int Attack { set; get; }
        int Health { set; get; }
        int Defense { set; get; }
        int Speed { set; get; }
        int MaxHealth { set; get; }
        String Name { set; get; }
        bool IsDefending { set; get; }
    }
}
