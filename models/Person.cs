using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Persons.models.utils.PersonUtils;

namespace Persons.models
{
    class Person
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime Birthdate { get; set; }

        public Person(string name, string address, DateTime birthdate)
        {
            (Address, Birthdate) = (address, birthdate);
            this.Name = NormalizeName(name);
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Address: {Address}\nBirthdate {Birthdate.Date.ToString()}, Age: {CalculateAge(this)}";
        }
    }
}
