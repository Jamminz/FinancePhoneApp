using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1.Model
{
    [Table]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int UserId { get; set; }

        [Column]
        public string Username { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string Password { get; set; }

       [Column]
       public double? Salary { get; set; }
    }
}
