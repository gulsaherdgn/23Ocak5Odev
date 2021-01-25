using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    class NewYearSales : ISales
    {
        public void Discount(IGame game)
        {
            Console.WriteLine(game.Name + " " + "Oyununda Yeniyıl indirimlerine özel %60 indirim var");
        }
    }
}
