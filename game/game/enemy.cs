﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class enemy : ICloneable
    {
        public string Name;
        public int ID;
        public int MaxHealth, Health;
        public int Damage;
        public int Armor;


        public enemy(string name, int id, int maxhealth, int damage, int armor)
        {
            Name = name;
            ID = id;
            MaxHealth = maxhealth;
            Damage = damage;
            Armor = armor;

            Health = MaxHealth;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
