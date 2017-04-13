using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts;

namespace Assets.Scripts.Persistence
{
    public class PlayerState : IPlayerState
    {
        private int DEFAULT_locationX = 0;
        private int DEFAULT_locationY = 0;
        private int DEFAULT_locationZ = 0;
        private int DEFAULT_health = 10;
        private int DEFAULT_defense = 1;
        private int DEFAULT_attack = 1;
        private int DEFAULT_speed = 1;

        public PlayerState()
        {
            this.locationX = DEFAULT_locationX;
            this.locationY = DEFAULT_locationY;
            this.locationZ = DEFAULT_locationZ;
            this.Health = DEFAULT_health;
            this.Defense = DEFAULT_defense;
            this.Speed = DEFAULT_speed;
            this.Attack = DEFAULT_attack;

        }
        public PlayerState(int locX, int locY, int locZ, int attack, int health, int defense, int speed)
        {
            this.locationX = locX;
            this.locationY = locY;
            this.locationZ = locZ;
            this.Health = health;
            this.Defense = defense;
            this.Speed = speed;
            this.Attack = attack;
        }

        public int locationX
        {
            set; get;
        }
        public int locationY
        {
            set; get;
        }
        public int locationZ
        {
            set; get;
        }
        public int Attack
        {
            set; get;
        }
        public int Health
        {
            set; get;
        }
        public int Defense
        {
            set; get;
        }
        public int Speed
        {
            set; get;
        }
    }
}