using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1.Model
{
    [Table]
    public class Income
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IncomeId { get; set; }

        [Column]
        public decimal Amount { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public string CreatedBy { get; set; }
    }
}
