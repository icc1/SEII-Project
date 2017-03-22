using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    abstract class Stats
    {
        private int attack;
        private int health;
        private int defense;
        private int speed;

        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public int Defense
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public void setStats(int newAttack, int newHealth, int newDefense, int newSpeed)
        {
            this.Attack = newAttack;
            this.Health = newHealth;
            this.Defense = newDefense;
            this.Speed = newSpeed;
        }
    }
}
