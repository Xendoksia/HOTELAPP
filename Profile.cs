using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;


namespace HOTELAPP
{
    public partial class Profile : Form
    {
        string username;
        public Profile(string user)
        {
            InitializeComponent();
            SetGradientBackground();
            username = user;
        }
        public void SetGradientBackground()
        {
          
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.MediumSlateBlue,
                Color.Purple,
                LinearGradientMode.Vertical);  

            
            this.BackgroundImage = CreateBackgroundImage(this.ClientRectangle.Size, gradientBrush);
        }
        public Bitmap CreateBackgroundImage(Size size, Brush brush)
        {
            
            Bitmap bitmap = new Bitmap(size.Width, size.Height);

           
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                
                g.FillRectangle(brush, new Rectangle(Point.Empty, size));
            }

            return bitmap;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();

            
            SqlCommand command = new SqlCommand("SELECT username, name, surname, gender, email, birthday FROM [User]", sqlConnection.Sql);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["name"].ToString();
                textBox2.Text = reader["surname"].ToString();
                textBox3.Text = reader["email"].ToString();
                textBox4.Text = reader["gender"].ToString();
                textBox5.Text = reader["birthday"].ToString();
                textBox6.Text = reader["username"].ToString();
                
            }

            reader.Close();
            sqlConnection.Sql.Close();
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form3 pr = new Form3(username);//Create the new form
            pr.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReservationHistory pr = new ReservationHistory(username);//Create the new form
            pr.Show();
            this.Close();
        }
    }
}
