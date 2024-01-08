using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOTELAPP
{
    public partial class MakeReservation : Form
    {
        

        public MakeReservation()
        {
            InitializeComponent();
            SetGradientBackground();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
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

            if (comboBox1.SelectedIndex== 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2) 
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                textBox3.Visible = true;
                textBox2.Visible = false;
                textBox4.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1) 
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                textBox3.Visible = false;
                textBox2.Visible = false;
                textBox4.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3 ) 
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
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
            Form3 f3 = new Form3();//Create the new form
            f3.Show();//display Form2 to the user
            this.Close();
        }
    }
}
