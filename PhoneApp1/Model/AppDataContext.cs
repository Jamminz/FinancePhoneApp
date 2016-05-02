using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1.Model
{
    public class AppDataContext : DataContext
    {
        public static string DbConnectionString = @"isostore:/Databases.sdf";
        public AppDataContext(string connectionString) : base (connectionString)
        { }

        public Table<User> Users
        {
            get { return this.GetTable<User>(); }
        }
        public Table<Income> Incomes
        {
            get { return this.GetTable<Income>(); }
        }

        public Table<Expenditure> Expenditures
        {
            get { return this.GetTable<Expenditure>(); }
        }
    }
}
