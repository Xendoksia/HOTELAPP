using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HOTELAPP
{
    public partial class ManageRooms : UserControl
    {
        public ManageRooms()
        {
            InitializeComponent();
            SetGradientBackground();
        }
        public void SetGradientBackground()
        {
            // Arka plan rengini gradient olarak ayarlamak için bir LinearGradientBrush kullanacağız.
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.Red,
                Color.Orange,
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

        private void loadRooms()
        {
            roomt.Items.Clear();
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT room_type, status FROM [RoomInventory]", sqlConnection.Sql);
            SqlDataReader reader = command.ExecuteReader();
            List<string> rooms = new List<string>();
            while (reader.Read())
            {
                string status;
                if (bool.Parse(reader[1].ToString())) status = "Avaliable";
                else status = "Maintance";

                rooms.Add(reader[0].ToString() + " - " + status);
            }
            reader.Close();

            foreach (string type in rooms)
            {
                roomt.Items.Add(type);
                reader.Close();
                command.Parameters.Clear();
            }
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            loadRooms();
        }

        /*private void rjButton1_Click(object sender, EventArgs e)
        {
            if (roomn.SelectedItem != null && roomt.SelectedItem != null && (checkBox1.Checked || checkBox2.Checked))
            {
                staffchoose.Visible = true;
                cslabel.Visible = true;
                liststaffbtn.Visible = false;
                assbtn.Visible = true;
            }
            else
            {
                staffchoose.Visible = false;
                cslabel.Visible = true;
                
            }
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
          
           
           
            try
            {
                // SQL sorgusunu hazırla ve yürüt
                SqlCommand staffCmd = new SqlCommand("SELECT name FROM [User] WHERE role = 'Staff'", sqlConnection.Sql);

                // SqlDataReader kullanarak verileri oku
                using (SqlDataReader loyal = staffCmd.ExecuteReader())
                {
                    // ComboBox temizle
                    staffchoose.Items.Clear();

                    // Verileri ComboBox'a ekle
                    while (loyal.Read())
                    {
                        // SqlDataReader'dan "name" sütununu al
                        string staffName = loyal["name"].ToString();

                        // ComboBox'a ekle
                        staffchoose.Items.Add(staffName);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda bir şeyler yapabilirsiniz
                Console.WriteLine($"Hata: {ex.Message}");
            }
            finally
            {
                // SqlConnection nesnesini kapat
                sqlConnection.Sql.Close();
            }

        }*/

        private void roomt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void settrue_Click(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("UPDATE [RoomInventory] SET status = 1 WHERE room_type = @room", sqlConnection.Sql);
            string roomtype = roomt.SelectedItem.ToString();
            int index = roomtype.IndexOf("-");
            if (index >= 0)
                roomtype = roomtype.Substring(0, index);
            roomtype.TrimEnd(roomtype[roomtype.Length - 1]);
            command.Parameters.AddWithValue("@room", roomtype);
            command.ExecuteNonQuery();
            loadRooms();
        }

        private void setfalse_Click(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("UPDATE [RoomInventory] SET status = 0 WHERE room_type = @room", sqlConnection.Sql);
            string roomtype = roomt.SelectedItem.ToString();
            int index = roomtype.IndexOf("-");
            if (index >= 0)
                roomtype = roomtype.Substring(0, index);
            roomtype.TrimEnd(roomtype[roomtype.Length - 1]);
            command.Parameters.AddWithValue("@room", roomtype);
            command.ExecuteNonQuery();
            loadRooms();
        }
    }
}

