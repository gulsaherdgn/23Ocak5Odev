using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Veritabanına loglandı : " + person.FirstName);
        }

        public void Delete(IPerson person)
        {
            Console.WriteLine("Veritabanından log silindi : " + person.FirstName);
        }

        public void Update(IPerson person)
        {
            Console.WriteLine("Veritabanındaki log güncellendi : " + person.FirstName);
        }
    }
}
