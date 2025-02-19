using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal class Level
    {
        public uint Number { get; set; }
        public string Name { get; set; }
        public List<Opponent> Opponents { get; set; }
        public Boss Boss { get; set; }
        public Reward Reward { get; set; }
    }
}
