using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
     class PlayerService : IPlayerService
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Kullanıcı başarıyla eklendi : "+ person.FirstName);
        }

        public void Delete(IPerson person)
        {
            Console.WriteLine("Kullanıcı başarıyla silindi : " + person.FirstName);
        }

        public void Update(IPerson person)
        {
            Console.WriteLine("Kullanıcı başarıyla güncellendi : " + person.FirstName);
        }
    }
}
