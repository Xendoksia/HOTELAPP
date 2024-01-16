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
        public SqlConnection Sql;
        public ConfigureSQL()
        {
            string pcname = System.Environment.MachineName;

            Sql = new SqlConnection("Data Source=.;Initial Catalog=Hotel Reservation;Integrated Security=True");
            //Sql = new SqlConnection(@$"Data Source = DESKTOP-HV9AC1E\SQLEXPRESS; Initial Catalog = 'Hotel Reservation'; Integrated Security = True");
        }
    }
}
