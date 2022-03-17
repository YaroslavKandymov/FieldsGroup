﻿using System;

namespace FieldsGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Player
    {
        private Weapon _weapon;
        private Movement _movement;

        public string Name { get; private set; }
        public int Age { get; private set; }
    }

    class Weapon
    {
        public float Cooldown { get; private set; }
        public int Damage { get; private set; }

        public void Attack()
        {
            //attack
        }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }
    }

    class Movement
    {
        public float DirectionX { get; private set; }
        public float DirectionY { get; private set; }
        public float Speed { get; private set; }

        public void Move()
        {
            //Do move
        }
    }
}
