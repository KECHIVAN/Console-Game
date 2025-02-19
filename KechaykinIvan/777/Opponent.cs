using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal class Opponent : Character
    {
        public Opponent(string name, uint health, int strength, uint defense, uint level, int minAttack, int maxAttack)
            : base(name, health, strength, defense, level, minAttack, maxAttack) { }
    }
}
