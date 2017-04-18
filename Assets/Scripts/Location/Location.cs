using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class Location
    {
        public enum Type
        {
            TOWN,
            DUNGEON1,
            DUNGEON2
        }

        private static int dungeon1MaxEnemies = 2;
        private static int dungeon2MaxEnemies = 3;

        public static int getMaxEnemies(Type location)
        {
            if (location == Location.Type.DUNGEON1)
            {
                return dungeon1MaxEnemies;
            }
            else if (location == Location.Type.DUNGEON2)
            {
                return dungeon2MaxEnemies;
            }
            else
            {
                return 0;
            }
        }
    }
}
