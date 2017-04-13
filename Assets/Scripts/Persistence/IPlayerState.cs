using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Persistence
{
    public interface IPlayerState
    {
        int locationX { set; get; }
        int locationY { set; get; }
        int locationZ { set; get; }
         
        int Attack { set; get; }
        int Health { set; get; }
        int Defense { set; get; }
        int Speed { set; get; }

    }
}
