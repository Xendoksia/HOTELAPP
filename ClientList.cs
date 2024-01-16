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

namespace HOTELAPP
{
    public partial class ClientList : UserControl
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM [User] WHERE role = 'Guest' ", sqlConnection.Sql);
            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // DataGridView'e DataTable'ı bağla
            dataGridView1.DataSource = dataTable;
        }
    }
}
