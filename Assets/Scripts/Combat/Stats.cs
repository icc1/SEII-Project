using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Stats : IStats
    {
        private String name;
        private int attack;
        private int maxHealth;
        private int health;
        private int defense;
        private int speed;
        private bool isDefending;

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
        public int MaxHealth
        {
            get
            {
                return maxHealth;
            }
            set
            {
                maxHealth = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void setStats(int newAttack, int newHealth, int newDefense, int newSpeed)
        {
            this.Attack = newAttack;
            this.MaxHealth = newHealth;
            this.Health = newHealth;
            this.Defense = newDefense;
            this.Speed = newSpeed;
        }

        public bool IsDefending
        {
            set
            {
                isDefending = value;
            }
            get
            {
                return isDefending;
            }
        }
    }
}
