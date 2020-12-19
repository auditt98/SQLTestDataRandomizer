using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDataGenerator.Generators.Generic
{
    abstract class NumberGenerator <T>
    {
        public T Max { get; set; }
        public T Min { get; set; }
        public T Result { get; set; }
        public List<T> Results { get; set; }
        public abstract T GenerateOne();
        public abstract List<T> GenerateMany(int size);
    }
}
