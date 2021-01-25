using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
     interface IPlayerService
    {
        void Add(IPerson person);
        void Delete(IPerson person);
        void Update(IPerson person);
    }
}
