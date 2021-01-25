using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    class FileLoggerService : ILoggerService
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Dosyaya log eklendi : " + person.FirstName);
        }

        public void Delete(IPerson person)
        {
            Console.WriteLine("Dosyadaki log silindi : " + person.FirstName);
        }

        public void Update(IPerson person)
        {
            Console.WriteLine("Dosyadaki log güncellendi : " + person.FirstName);
        }
    }
}
