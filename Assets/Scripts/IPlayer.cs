﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface IPlayer : ICombatCapable
    {
        Location.Type CurrentLocation { get; set; }
    }
}
