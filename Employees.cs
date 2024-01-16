using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HOTELAPP
{
    public partial class Employees : UserControl
    {
        private string connectionString = "Your_Connection_String"; 

        public Employees()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand query = new SqlCommand("SELECT name, surname, gender, role FROM [User] WHERE role = 'Staff' OR role = 'Manager'", sqlConnection.Sql);
            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // DataGridView'e DataTable'ı bağla
            dataGridView1.DataSource = dataTable;
            
        }

        

        private void rjButton1_Click(object sender, EventArgs e)
        {
            EmployeeAdd f1 = new EmployeeAdd();
            f1.Show();
            
        }
    }
}
