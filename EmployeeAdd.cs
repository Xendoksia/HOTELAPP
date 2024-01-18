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
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            try
            {
                sqlConnection.Sql.Open();
                SqlCommand insertCmd = new SqlCommand("INSERT INTO [User] (username, password, name, surname, gender, email, birthday, role) values (@Username, @Password, @Name, @Surname, @Gender, @Email, @Birthday, @Role)", sqlConnection.Sql);
                
                insertCmd.Parameters.AddWithValue("@Name", textBox3.Text);
                insertCmd.Parameters.AddWithValue("@Password", textBox3.Text);
                insertCmd.Parameters.AddWithValue("@Surname", textBox2.Text);
                insertCmd.Parameters.AddWithValue("@Username", textBox1.Text);
                insertCmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                insertCmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value.Date);
                insertCmd.Parameters.AddWithValue("@Email", textBox5.Text);
                insertCmd.Parameters.AddWithValue("@Role", comboBox2.Text);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Registered");

                this.Close();
            }
            catch (Exception Ex)
            {
                if (sqlConnection == null)
                    MessageBox.Show("Couldn't access the Database");
                else
                {
                    MessageBox.Show("Username Taken");
                }
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Sql.Close();
                }
            }
        }
    
    }
}
