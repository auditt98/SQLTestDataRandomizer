using SQLTestDataGenerator.Generators.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDataGenerator.Generators.Types
{
    class DecimalGenerator : NumberGenerator<decimal>
    {
        private readonly Random _random = new Random();

        DecimalGenerator()
        {
            Max = 0;
            Min = 0;
        }

        DecimalGenerator(decimal min, decimal max)
        {
            this.Max = max;
            this.Min = min;
        }

        
        public override decimal GenerateOne()
        {

            throw new NotImplementedException();
        }

        public override List<decimal> GenerateMany(int size)
        {
            throw new NotImplementedException();
        }

        
    }
}
