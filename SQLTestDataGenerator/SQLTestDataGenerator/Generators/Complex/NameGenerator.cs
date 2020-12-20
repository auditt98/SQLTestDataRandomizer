using SQLTestDataGenerator.Generators.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDataGenerator.Generators.Complex
{
    class NameGenerator : StringGenerator
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Suffix { get; set; }
        public string Prefix { get; set; }
        public XmlReader reader { get; set; }
        public NameGenerator()
        {
            reader = new XmlReader();
        }
        public override string GenerateOne()
        {
            Random _random = new Random();
            FirstName = reader._first_name[_random.Next(0, reader._first_name.Count)];
            LastName = reader._last_name[_random.Next(0, reader._last_name.Count)];
            MiddleName = reader._middle_name[_random.Next(0, reader._middle_name.Count)];
            FullName = FirstName + " " + MiddleName + " " + LastName;
            return FullName;
        }
        
        public string GenerateFirstName()
        {
            Random _random = new Random();
            FirstName = reader._first_name[_random.Next(0, reader._first_name.Count)];
            return FirstName;
        }

        public string GenerateLastName()
        {
            Random _random = new Random();
            LastName = reader._last_name[_random.Next(0, reader._last_name.Count)];
            return LastName;
        }

        public string GenerateMiddleName()
        {
            Random _random = new Random();
            MiddleName = reader._middle_name[_random.Next(0, reader._middle_name.Count)];
            return MiddleName;
        }
    }
}
