﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDataGenerator
{
    
    public class TableModel
    {
        public string TABLE_NAME { get; set; }
        public List<ColumnModel> Columns { get; set; }
        public int FK_COUNT { get; set; }
        public bool IS_INSERTED { get; set; } 
        public TableModel()
        {
            this.Columns = new List<ColumnModel>();
        }
    }
}
