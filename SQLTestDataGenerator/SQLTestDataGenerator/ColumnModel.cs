using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDataGenerator
{
    public class ColumnModel
    {
        public string COLUMN_NAME { get; set; }
        public string DATA_TYPE { get; set; }
        public bool IS_NULLABLE { get; set; }
        public string CHARACTER_MAXIMUM_LENGTH { get; set; }
        public int  IS_IDENTITY { get; set; }
        public string NUMERIC_PRECISION { get; set; }
        public string NUMERIC_SCALE { get; set; }
        public string Parameter { get; set; }
        public string Variable { get; set; }
        public ColumnModel()
        {

        }
    }
}
