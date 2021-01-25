using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    interface IGameService
    {
        void Add(IGame game);
        void Delete(IGame game);
        void Update(IGame game);
    }
}
