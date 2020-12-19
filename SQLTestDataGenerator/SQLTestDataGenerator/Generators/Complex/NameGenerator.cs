﻿using SQLTestDataGenerator.Generators.Generic;
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
        public override string GenerateOne()
        {
            throw new NotImplementedException();
        }
    }
}
