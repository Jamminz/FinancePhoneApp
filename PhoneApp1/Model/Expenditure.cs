﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1.Model
{
    [Table]
    public class Expenditure
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ExpenditureId { get; set; }

        [Column]
        public double? Amount { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public string CreatedBy { get; set; }
    }
}
