using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    class Game : IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public double UnitPrice { get; set; }
    }
}
