using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
     class Player : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int YearOfBirth { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
    }
}
