using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELAPP
{
    public class ConfigureSQL
    {
        public readonly SqlConnection Sql;
        public ConfigureSQL()
        {
            string pcname = System.Environment.MachineName;

            Sql = new SqlConnection(@$"Data Source = {pcname}\SQLEXPRESS; Initial Catalog = 'Hotel Reservation'; Integrated Security = True");
        }
    }
}
