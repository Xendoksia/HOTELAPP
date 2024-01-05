﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetGradientBackground();
        }

        private void SetGradientBackground()
        {
            // Arka plan rengini gradient olarak ayarlamak için bir LinearGradientBrush kullanacağız.
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.Purple,
                Color.Turquoise,
                LinearGradientMode.Vertical);  // Dikey gradient

            // Arka plan rengini belirtilen brush ile ayarla
            this.BackgroundImage = CreateBackgroundImage(this.ClientRectangle.Size, gradientBrush);
        }

        public Bitmap CreateBackgroundImage(Size size, Brush brush)
        {
            // Bir bitmap oluştur
            Bitmap bitmap = new Bitmap(size.Width, size.Height);

            // Bitmap üzerinde bir grafik nesnesi oluştur
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Belirtilen brush ile arka planı doldur
                g.FillRectangle(brush, new Rectangle(Point.Empty, size));
            }

            return bitmap;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;

            try
            {
            sqlConnection = new SqlConnection(@"Data Source=HERO\SQLEXPRESS;Initial Catalog=SQLHotel;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand insertCmd = new SqlCommand("INSERT INTO userTable (Username, Password, Name, Surname, Gender, Birthday, Email, Role, PrizeCounter, Reservations) values (@Username, @Password, @Name, @Surname, @Gender, @Birthday, @Email, 'Guest', 0, '')", sqlConnection);
            insertCmd.Parameters.AddWithValue("@Username", textBox3.Text);
            insertCmd.Parameters.AddWithValue("@Password", registerpw.Text);
            insertCmd.Parameters.AddWithValue("@Name", textBox4.Text);
            insertCmd.Parameters.AddWithValue("@Surname", textBox1.Text);
            insertCmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
            insertCmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Text);
            insertCmd.Parameters.AddWithValue("@Email", textBox2.Text);

            insertCmd.ExecuteNonQuery();
            MessageBox.Show("kayıt olundu");

            this.Close();
            }
            catch (Exception ex)
            {
                if (sqlConnection == null)
                    MessageBox.Show("sql yüklenemedi");
                else
                {
                    MessageBox.Show("kullanıcı adı alınmış");
                }
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
