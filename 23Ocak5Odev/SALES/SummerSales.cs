using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    class SummerSales : ISales
    {
        public void Discount(IGame game)
        {
            Console.WriteLine(game.Name + " "+ "Oyununda Yaz İndirimlerine Özel %20 indirim var" );
        }
    }
}
