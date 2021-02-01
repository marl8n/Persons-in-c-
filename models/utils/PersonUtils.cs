using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.models.utils
{
    class PersonUtils
    {
        public static int CalculateAge(Person person)
        {
            var age = DateTime.Now - person.Birthdate;
            return age.Days / 365;
        }

        public static String NormalizeName(String name)
        {
            List<String> normalizedWords = name.Split(' ').ToList();
            normalizedWords.ForEach(word => word.ToLower());
            name = "";
            foreach(var word in normalizedWords)
            {
                var n = char.ToUpper(word[0]) + word.Substring(1);
                name += " " + n;
            }
            return name;
        }
    }
}
