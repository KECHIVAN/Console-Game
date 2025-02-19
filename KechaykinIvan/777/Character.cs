using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal abstract class Character
    {
        public string Name { get; set; }
        public uint Health { get; set; }
        public uint CurrentHealth { get; set; }
        public int Strength { get; set; }
        public uint Defense { get; set; }
        public uint Level { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }

        public Character(string name, uint health, int strength, uint defense, uint level, int minAttack, int maxAttack)
        {
            Name = name;
            Health = health;
            CurrentHealth = health;
            Strength = strength;
            Defense = defense;
            Level = level;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }

        public virtual int Attack()
        {
            Random rnd = new Random();
            return rnd.Next(MinAttack, MaxAttack + 1) + Strength;
        }

        public virtual void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(damage - (int)Defense, 0);
            CurrentHealth = (uint)Math.Max((int)CurrentHealth - actualDamage, 0);
        }

        public bool IsDead() => CurrentHealth == 0;
    }
}
