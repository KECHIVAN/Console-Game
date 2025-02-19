using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal class Hero : Character
    {
        public uint Experience { get; set; }

        public Hero(string name, uint health, int strength, uint defense, uint level, uint experience, int minAttack, int maxAttack)
            : base(name, health, strength, defense, level, minAttack, maxAttack)
        {
            Experience = experience;
        }
    }
}
