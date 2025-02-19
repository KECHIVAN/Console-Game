using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal class User
    {
        public string Name { get; set; }
        public Hero Hero { get; set; }

        public User(string name, Hero hero)
        {
            Name = name;
            Hero = hero;
        }
    }
}
