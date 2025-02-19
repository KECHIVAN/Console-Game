using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{

    class Program
    {
        static void Main()
        {
            Hero hero = new Hero("Воин", 100, 10, 5, 1, 0, 5, 15);
            User player = new User("Игрок1", hero);

            List<Level> levels = new List<Level> {
            new Level {
                Number = 1,
                Name = "Лесной лагерь",
                Opponents = new List<Opponent> {
                    new Opponent("Гоблин", 50, 5, 2, 1, 3, 8)
                },
                Boss = new Boss("Орк", 150, 15, 5, 2, 10, 20),
                Reward = new Reward { Exp = 50, Health = 10, Strength = 3, Defense = 2 }
            }
        };

            Game game = new Game(player, levels);

            Console.WriteLine($"Добро пожаловать, {player.Name}! Ваш герой: {player.Hero.Name}");
            Console.WriteLine($"Первый уровень: {game.CurrentLevel.Name}");

            Console.ReadLine();
        }
    }
}
