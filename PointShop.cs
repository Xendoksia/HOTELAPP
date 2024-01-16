using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELAPP
{
    public partial class PointShop : Form
    {
        string username;
        public PointShop(string user)
        {
            InitializeComponent();
            SetGradientBackground();
            username = user;
        }
        public void SetGradientBackground()
        {
            // Arka plan rengini gradient olarak ayarlamak için bir LinearGradientBrush kullanacağız.
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.MediumSlateBlue,
                Color.Purple,
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


        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(username);//Create the new form
            f3.Show();//display Form2 to the user
            this.Close();
        }
        
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText($"{label3.Text}\r\n");
            int currentValue = int.Parse(label10.Text);
            int updatedValue = currentValue + 10;
            label10.Text = updatedValue.ToString();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText($"{label4.Text}\r\n");
            int currentValue = int.Parse(label10.Text);
            int updatedValue = currentValue + 10;
            label10.Text = updatedValue.ToString();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText($"{label5.Text}\r\n");
            int currentValue = int.Parse(label10.Text);
            int updatedValue = currentValue + 10;
            label10.Text = updatedValue.ToString();
        }

        private void PointShop_Load(object sender, EventArgs e)
        {
            label10.Text = "0";
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // label9 içindeki değeri al
                int loyaltyPointsToDeduct = int.Parse(label10.Text);

                // loyalty_points değerini azaltmak için ilgili işlemi gerçekleştir
                UpdateLoyaltyPointsInDatabase(loyaltyPointsToDeduct);

                // İlgili işlemi gerçekleştirdikten sonra label9'u sıfırla veya başka bir değerle güncelle
                label10.Text = "0";
            }
            catch (FormatException)
            {
                // Eğer label9 içinde geçerli bir sayı yoksa bu hatayı ele alabilirsiniz.
                MessageBox.Show("Geçerli bir sayı girilmelidir.");
            }
        }

        // loyalty_points değerini azaltmak için kullanılan fonksiyon
        private void UpdateLoyaltyPointsInDatabase(int loyaltyPointsToDeduct)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand();
            try // earning points
            {
                command.Parameters.Clear();
                command = new SqlCommand("SELECT loyalty_points FROM [RewardLoyalty] WHERE guestname = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int points = int.Parse(reader[0].ToString()) - loyaltyPointsToDeduct;
                reader.Close();
                command.Parameters.Clear();
                command = new SqlCommand("UPDATE [RewardLoyalty] SET loyalty_points = @newpoint WHERE guestname = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@newpoint", points);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                command.Parameters.Clear();
                command = new SqlCommand("INSERT INTO [RewardLoyalty](guestname, loyalty_points) VALUES (@user, 5)", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.ExecuteNonQuery();
            }


        }
    }
}
