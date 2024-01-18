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
        List<string> prizes = new List<string>();
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
            prizes.Add("massage");
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText($"{label4.Text}\r\n");
            int currentValue = int.Parse(label10.Text);
            int updatedValue = currentValue + 10;
            label10.Text = updatedValue.ToString();
            prizes.Add("dinner");
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText($"{label5.Text}\r\n");
            int currentValue = int.Parse(label10.Text);
            int updatedValue = currentValue + 10;
            label10.Text = updatedValue.ToString();
            prizes.Add("breakfast");
        }
        private void LoadLoyalty()
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT loyalty_points FROM [RewardLoyalty] WHERE  guestname = @guestname", sqlConnection.Sql);
            command.Parameters.AddWithValue("@guestname", username);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {

                int loyaltyPoints = reader.GetInt32(0);


                label6.Text = "Loyalty Points: " + loyaltyPoints.ToString();
            }
            else
            {
                // Handle the case where no loyalty points are found for the given room type
                label6.Text = " Loyalty Points: 0 ";
            }

            reader.Close();
            sqlConnection.Sql.Close();  // Close the connection after using it
        }
        private void PointShop_Load(object sender, EventArgs e)
        {
            label10.Text = "0";

            LoadLoyalty();
            LoadClaimed();
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
                textBox1.Text = "";

                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand();
                foreach (string prize in prizes)
                {
                    command.Parameters.Clear();
                    command = new SqlCommand("SELECT count FROM [Rewards] WHERE guestname = @guestname AND prize = @prize", sqlConnection.Sql);
                    command.Parameters.AddWithValue("@guestname", username);
                    command.Parameters.AddWithValue("@prize", prize);
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        reader.Read();
                        int count = int.Parse(reader[0].ToString());
                        reader.Close();

                        command.Parameters.Clear();
                        command = new SqlCommand("UPDATE [Rewards] SET count = @count WHERE guestname = @guestname AND prize = @prize", sqlConnection.Sql);
                        command.Parameters.AddWithValue("@guestname", username);
                        command.Parameters.AddWithValue("@prize", prize);
                        command.Parameters.AddWithValue("@count", count + 1);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        reader.Close();
                        command.Parameters.Clear();
                        command = new SqlCommand("INSERT INTO [Rewards](guestname, prize, count) VALUES (@guestname, @prize, 1)", sqlConnection.Sql);
                        command.Parameters.AddWithValue("@guestname", username);
                        command.Parameters.AddWithValue("@prize", prize);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thank you for your loyalty!");
                }
                prizes.Clear();
                LoadLoyalty();
                LoadClaimed();
            }
            catch (Exception ex)
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
            SqlCommand command = new SqlCommand("SELECT loyalty_points FROM [RewardLoyalty] WHERE guestname = @user", sqlConnection.Sql);

            try // earning points
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int points = int.Parse(reader[0].ToString()) - loyaltyPointsToDeduct;
                reader.Close();
                if (points < 0)
                {
                    MessageBox.Show("Not enough points.");
                    return;
                }
                command.Parameters.Clear();
                command = new SqlCommand("UPDATE [RewardLoyalty] SET loyalty_points = @newpoint WHERE guestname = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@newpoint", points);
                command.ExecuteNonQuery();


            }
            catch (Exception Ex)
            {
                command.Parameters.Clear();
                command = new SqlCommand("INSERT INTO [RewardLoyalty](guestname, loyalty_points) VALUES (@user, 5)", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.ExecuteNonQuery();
            }

        }

        private void LoadClaimed()
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT prize, count FROM [Rewards] WHERE guestname = @user", sqlConnection.Sql);
            command.Parameters.AddWithValue("@user", username);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                string allPrizes = "";
                while(reader.Read())
                {
                    allPrizes += reader[1].ToString() + " " + reader[0].ToString() + ", ";
                }
                allPrizes = allPrizes.Remove(allPrizes.Length - 2, 2);
                textBox2.Text = allPrizes;
            }
            catch(Exception Ex)
            {
                reader.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
