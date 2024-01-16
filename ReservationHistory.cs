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
    public partial class ReservationHistory : Form
    {
        string username;
        public ReservationHistory(string user)
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

        private void ReservationHistory_Load(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT room_id, check_in_date, check_out_date FROM [Reservation] WHERE guestname = @user", sqlConnection.Sql);
            command.Parameters.AddWithValue("@user", username);
            SqlDataReader reader = command.ExecuteReader();

            List<string> roomOld = new List<string>();
            List<string> roomNew = new List<string>();
            List<string> roomNewIn = new List<string>();
            List<string> roomNewOut = new List<string>();
            List<string> roomOldIn = new List<string>();
            List<string> roomOldOut = new List<string>();
            while (reader.Read())
            {
                string roomId = reader[0].ToString();
                DateTime resIn = reader.GetDateTime(1);
                DateTime resOut = reader.GetDateTime(2);
                DateTime now = DateTime.Now;
                if (resIn <= now)
                {
                    roomOld.Add(roomId);
                    roomOldIn.Add(resIn.ToString());
                    roomOldOut.Add(resOut.ToString());
                }
                else
                {
                    roomNew.Add(roomId);
                    roomNewIn.Add(resIn.ToString());
                    roomNewOut.Add(resOut.ToString());
                }
            }
            reader.Close();


            command = new SqlCommand("SELECT room_type FROM [RoomInventory] WHERE room_id = @id", sqlConnection.Sql);
            int i = 0;
            foreach (string roomId in roomOld)
            {
                reader.Close();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", roomId);
                reader = command.ExecuteReader();
                reader.Read();
                string room = reader[0].ToString();
                comboBox2.Items.Add(room + "  " + roomOldIn[i] + " - " + roomOldOut[i]);
            }
            reader.Close();


            command = new SqlCommand("SELECT room_type FROM [RoomInventory] WHERE room_id = @id", sqlConnection.Sql);
            foreach (string roomId in roomNew)
            {
                reader.Close();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", roomId);
                reader = command.ExecuteReader();
                reader.Read();
                string room = reader[0].ToString();
                comboBox1.Items.Add(room + "  " + roomNewIn[i] + " - " + roomNewOut[i]);
            }
            reader.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3(username);
            f2.Show();
            this.Close();
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {

        }

        private void manageReservations1_Load(object sender, EventArgs e)
        {

        }
    }
}
