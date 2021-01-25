using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuOdev
{
    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int YearOfBirth { get; set; }
    }
}
