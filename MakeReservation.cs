using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Mail;
using System.Numerics;
//using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOTELAPP
{
    public partial class MakeReservation : Form
    {
        string username;

        public MakeReservation(string user)
        {
            InitializeComponent();
            SetGradientBackground();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // farklı şey seçince
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox1.Visible = false;

            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand("SELECT price FROM [RoomInventory] WHERE room_type = @name AND status = 1", sqlConnection.Sql);
                command.Parameters.AddWithValue("@name", comboBox1.GetItemText(comboBox1.SelectedItem));
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                /*int i = int.Parse(roomID[0].ToString());
                switch (i)
                {
                    case 0:
                    case 1:
                        pictureBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox1.Visible = true;
                        textBox1.Text = price[i] + " per night";
                        break;

                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        pictureBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox1.Visible = true;
                        textBox1.Text = price[i] + " per night";
                        break;

                    case 7:
                    case 8:
                    case 9:
                        pictureBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox1.Visible = true;
                        textBox1.Text = price[i] + " per night";
                        break;
                }*/

                pictureBox3.Visible = true;
                textBox4.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = reader[0] + " per night";

                sqlConnection.Sql.Close();
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, "Please Select a Room Type");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(username);//Create the new form
            f3.Show();//display Form2 to the user
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;
            comboBox1.SelectedIndex = -1;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void rjButton3_Click(object sender, EventArgs e) // searching
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "Please Select a Room Type");
            comboBox1.SelectedIndex = 0;
            string bedCountStr = comboBox2.SelectedItem.ToString();
            int bedCount = 0;
            switch (bedCountStr)
            {
                case "All":
                    bedCount = 0;
                    break;
                case "1 Bed":
                    bedCount = 1;
                    break;
                case "2 Beds":
                    bedCount = 2;
                    break;
                case "3 Beds":
                    bedCount = 3;
                    break;
            }

            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand();

            if (bedCountStr == "All") command = new SqlCommand("SELECT room_id, price FROM [RoomInventory] WHERE status = 1", sqlConnection.Sql);
            else
            {
                command = new SqlCommand("SELECT room_id, price FROM [RoomInventory] WHERE capacity = @bed AND status = 1", sqlConnection.Sql);
                command.Parameters.AddWithValue("@bed", bedCount);
            }
            SqlDataReader reader = command.ExecuteReader();

            List<string> roomids = new List<string>();
            while (reader.Read())
            {
                roomids.Add(reader[0].ToString());
            }
            reader.Close();

            command = new SqlCommand("SELECT room_id, check_in_date, check_out_date FROM [Reservation]", sqlConnection.Sql);
            reader = command.ExecuteReader();

            DateTime dateIn = dateTimePicker1.Value.Date;
            DateTime dateOut = dateTimePicker2.Value.Date;

            while (reader.Read())
            {
                DateTime resIn = reader.GetDateTime(1);
                DateTime resOut = reader.GetDateTime(2);

                if ((resIn <= dateIn && resOut >= dateIn) || (resIn <= dateOut && resOut >= dateOut))
                    roomids.Remove(reader[0].ToString());

            }
            reader.Close();

            command = new SqlCommand("SELECT room_type FROM [RoomInventory] WHERE room_id = @id", sqlConnection.Sql);
            foreach (string type in roomids)
            {
                command.Parameters.AddWithValue("@id", type);
                reader = command.ExecuteReader();
                reader.Read();
                comboBox1.Items.Add(reader[0]);
                reader.Close();
                command.Parameters.Clear();
            }

            sqlConnection.Sql.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e) // reservation button
        {

            int index = comboBox1.SelectedIndex - 1;
            if (index == -1) return;
            DateTime dateIn = dateTimePicker1.Value.Date;
            DateTime dateOut = dateTimePicker2.Value.Date;
            string dateInStr = dateIn.ToString();
            string dateOutStr = dateOut.ToString();

            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();

            SqlCommand command = new SqlCommand("SELECT room_id FROM [RoomInventory] WHERE room_type = @roomname", sqlConnection.Sql);
            string roomName;
            try
            {
                roomName = comboBox1.SelectedItem.ToString();

            }
            catch(Exception Ex)
            {
                return;
            }
            command.Parameters.AddWithValue("@roomname", roomName);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string room = reader[0].ToString();
            int roomid = int.Parse(room);
            reader.Close();

            command = new SqlCommand("SELECT * FROM [ReservationIDCounter]", sqlConnection.Sql); // unique id for reservation
            reader = command.ExecuteReader();
            reader.Read();
            int reservationId = int.Parse(reader[0].ToString()) + 1;
            reader.Close();

            command = new SqlCommand("INSERT INTO [Reservation] (reservation_id,guestname,room_id,check_in_date,check_out_date) values (@resid,@guest,@roomid,@in,@out)", sqlConnection.Sql);
            command.Parameters.AddWithValue("@resid", reservationId);
            command.Parameters.AddWithValue("@guest", username);
            command.Parameters.AddWithValue("@roomid", roomid);
            command.Parameters.AddWithValue("@in", dateIn);
            command.Parameters.AddWithValue("@out", dateOut);
            command.ExecuteNonQuery();

            command = new SqlCommand("UPDATE [ReservationIDCounter] SET id = @id", sqlConnection.Sql);
            command.Parameters.AddWithValue("@id", reservationId);
            command.ExecuteNonQuery();

            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "Please Select a Room Type");
            comboBox1.SelectedIndex = 0;

            try // earning points
            {
                command.Parameters.Clear();
                command = new SqlCommand("SELECT loyalty_points FROM [RewardLoyalty] WHERE guestname = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                reader = command.ExecuteReader();
                reader.Read();
                int points = int.Parse(reader[0].ToString()) + 5;
                reader.Close();
                command.Parameters.Clear();
                command = new SqlCommand("UPDATE [RewardLoyalty] SET loyalty_points = @newpoint WHERE guestname = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@newpoint", points);
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                reader.Close();
                command.Parameters.Clear();
                command = new SqlCommand("INSERT INTO [RewardLoyalty](guestname, loyalty_points) VALUES (@user, 5)", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.ExecuteNonQuery();
            }
            command.Parameters.Clear();
            command = new SqlCommand("SELECT email FROM [User] WHERE username = @user", sqlConnection.Sql);
            command.Parameters.AddWithValue("@user", username);
            reader = command.ExecuteReader();
            reader.Read();
            string guestMail = reader[0].ToString();
            reader.Close();
            

            //guestMail, bedCount, dateInStr, dateOutStr, reservationId
            
            
            
            
            
            
            /*
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the SmtpClient class.";
            message.Body = @"Using this feature, you can send an email message from an application very easily.";
            MailAddress bcc = new MailAddress("manager1@contoso.com");
            message.Bcc.Add(bcc);
            SmtpClient client = new SmtpClient();
            client.Credentials = CredentialCache.DefaultNetworkCredentials;
            Console.WriteLine("Sending an email message to {0} and {1}.",
                to.DisplayName, message.Bcc.ToString());

            try
            {
                client.Send(message);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateBccTestMessage(): {0}",
                    ex.ToString());
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(reader[0].ToString(), reader[1].ToString()),
                EnableSsl = true,
            };

            smtpClient.Send("email", "recipient", "subject", "body");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("email"),
                Subject = "subject",
                Body = "<h1>Your reservation has been received\r\n</h1>",
                IsBodyHtml = true,
            };/
            mailMessage.To.Add("recipient");

            smtpClient.Send(mailMessage);


            */

            sqlConnection.Sql.Close();

            MessageBox.Show("Reservation complete (+5 points)");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
