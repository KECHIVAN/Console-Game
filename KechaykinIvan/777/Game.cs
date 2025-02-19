using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal class Game
    {
        public User Player { get; set; }
        public List<Level> Levels { get; set; }
        public Level CurrentLevel { get; set; }

        public Game(User player, List<Level> levels)
        {
            Player = player;
            Levels = levels;
            CurrentLevel = levels[0];
        }
    }
}
