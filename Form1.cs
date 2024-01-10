using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HOTELAPP
{
    public partial class Form1 : Form
    {

        bool form3opened = false;
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            // Yuvarlakl�k varm� riad
            int borderRadius = 50; // Yuvarlakl�k miktar�, iste�e ba�l� olarak ayarlanabilir.
            int borderWidth = 20; // Kenarl�k kal�nl���
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);


            // Panelin kenarlar�na yuvarlakl�k efektini uyguluyoruz.
            using (GraphicsPath borderPath = new GraphicsPath())
            {
                Rectangle borderRectangle = new Rectangle(0, 0, panel.Width, panel.Height);

                borderPath.AddArc(borderRectangle.X, borderRectangle.Y, borderRadius, borderRadius, 180, 90); // Sol �st k��e
                borderPath.AddArc(borderRectangle.X + borderRectangle.Width - borderRadius, borderRectangle.Y, borderRadius, borderRadius, 270, 90); // Sa� �st k��e
                borderPath.AddArc(borderRectangle.X + borderRectangle.Width - borderRadius, borderRectangle.Y + borderRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Sa� alt k��e
                borderPath.AddArc(borderRectangle.X, borderRectangle.Y + borderRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Sol alt k��e
                borderPath.CloseAllFigures();

                using (Pen pen = new Pen(Color.FromArgb(152, 255, 242), borderWidth)) // Border rengini ve kal�nl��� ayarl�yoruz
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, borderPath);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            ConfigureSQL sqlConnection = new ConfigureSQL();

            try
            {
                sqlConnection.Sql.Open();
                SqlCommand userCmd = new SqlCommand("SELECT username, password, role FROM [User]", sqlConnection.Sql);
                SqlDataReader userTable = userCmd.ExecuteReader();

                string usernameText = textBox1.Text, passwordText = pw1.Text;

                while (userTable.Read())
                {

                    if (usernameText == userTable[0].ToString() && passwordText == userTable[1].ToString())
                    {
                        switch (userTable[2].ToString())
                        {
                            case "Guest":
                                Form3 f3 = new Form3(usernameText);
                                f3.Show();
                                break;

                            case "Staff":
                                Staff staff = new Staff();
                                staff.Show();
                                break;

                            case "Manager":
                                break;
                        }


                        form3opened = true;
                        this.Close();

                        sqlConnection.Sql.Close();
                        return;
                    }
                }
                MessageBox.Show("not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql y�klenemedi");
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Sql.Close();
                }
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pw1.UseSystemPasswordChar = true;

            }
            else
            {
                pw1.UseSystemPasswordChar = false;
            }
        }


        private void linkLabel1_LinkClicked_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!form3opened) Application.Exit();
        }
    }
}
