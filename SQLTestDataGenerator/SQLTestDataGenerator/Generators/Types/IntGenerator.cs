using SQLTestDataGenerator.Generators.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDataGenerator.Generators.Types
{
    class IntGenerator : NumberGenerator<int>
    {
        private readonly Random _random = new Random();
        public IntGenerator()
        {
            Max = 0;
            Min = 0;
        }
        public IntGenerator(int min, int max)
        {
            Min = min;
            Max = max;
        }
        public override int GenerateOne()
        {
            Result = _random.Next(Min, Max);
            return Result;
        }

        public override List<int> GenerateMany(int size)
        {
            for(var i = 0; i < size; i++)
            {
                var n = GenerateOne();
                this.Results.Add(n);
            }
            return Results;
        }
    }
}
