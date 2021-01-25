using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    class GameService : IGameService
    {
        public void Add(IGame game)
        {
            Console.WriteLine("Oyun eklendi : " + game.Name);
        }

        public void Delete(IGame game)
        {
            Console.WriteLine("Oyun silindi : " + game.Name);
        }

        public void Update(IGame game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.Name);
        }
    }
}
