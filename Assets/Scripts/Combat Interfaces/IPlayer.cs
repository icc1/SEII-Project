using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Combat_Interfaces
{
    public interface IPlayer : IStats
    {
        Location.Type CurrentLocation { get; set; }
    }
}
