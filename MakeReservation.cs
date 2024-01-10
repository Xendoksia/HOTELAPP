using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace HOTELAPP
{
    public partial class MakeReservation : Form
    {
        string username;
        string[] price = new string[10];

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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                SqlCommand roomCmd = new SqlCommand("SELECT room_id FROM [RoomInventory] WHERE room_type = @name", sqlConnection.Sql);
                roomCmd.Parameters.AddWithValue("@name", comboBox1.GetItemText(comboBox1.SelectedItem));
                SqlDataReader roomID = roomCmd.ExecuteReader();
                roomID.Read();

                int i = int.Parse(roomID[0].ToString());
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
                }
                
                sqlConnection.Sql.Close();
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, "Please Select a Room Type");
            comboBox1.SelectedIndex = 0;
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

        private void rjButton3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "Please Select a Room Type");
            comboBox1.SelectedIndex = 0;

            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand roomCmd = new SqlCommand("SELECT * FROM [RoomInventory]", sqlConnection.Sql);
            SqlDataReader roomTable = roomCmd.ExecuteReader();

            int i = 0;
            while (roomTable.Read())
            {
                try
                {
                    DateTime resIn = roomTable.GetDateTime(5);
                    DateTime resOut = roomTable.GetDateTime(6);
                    DateTime dateIn = dateTimePicker1.Value.Date;
                    DateTime dateOut = dateTimePicker2.Value.Date;
                    if (!(resIn <= dateIn && resOut >= dateIn) && !(resIn <= dateOut && resOut >= dateOut))
                    {
                        comboBox1.Items.Add(roomTable[1]);
                        price[i] = roomTable[4].ToString();
                    }
                }
                catch (Exception ex)
                {
                    comboBox1.Items.Add(roomTable[1]);
                    price[i] = roomTable[4].ToString();
                }
                i++;
            }
            sqlConnection.Sql.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            int id = comboBox1.SelectedIndex - 1;
            if (id == -1) return;
            DateTime dateIn = dateTimePicker1.Value.Date;
            DateTime dateOut = dateTimePicker2.Value.Date;
            

            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();

            SqlCommand updateCmd = new SqlCommand("UPDATE RoomInventory SET reservation_in = @in, reservation_out = @out WHERE room_id = @id", sqlConnection.Sql);
            updateCmd.Parameters.AddWithValue("@in", dateIn);
            updateCmd.Parameters.AddWithValue("@out", dateOut);
            updateCmd.Parameters.AddWithValue("@id", id);
            updateCmd.ExecuteNonQuery();
            MessageBox.Show("rezervasyon yapıldı.");

            comboBox1.Items.Clear();
            comboBox1.Items.Insert(0, "Please Select a Room Type");
            comboBox1.SelectedIndex = 0;

            sqlConnection.Sql.Close();
        }
    }
}
