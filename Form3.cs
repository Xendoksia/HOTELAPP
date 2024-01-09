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


namespace HOTELAPP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SetGradientBackground();
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ReservationHistory f2 = new ReservationHistory();
            f2.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            MakeReservation f3 = new MakeReservation();//Create the new form
            f3.Show();//display Form2 to the user
            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Profile f1 = new Profile();//Create the new form
            f1.Show();//display Form2 to the user
            this.Close();

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            PointShop f1 = new PointShop();//Create the new form
            f1.Show();//display Form2 to the user
            this.Close();
        }
    }
}
