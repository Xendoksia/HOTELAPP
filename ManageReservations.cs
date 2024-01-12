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

namespace HOTELAPP
{
    public partial class ManageReservations : UserControl
    {
        public ManageReservations()
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

        private void ManageReservations_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex== 0 && comboBox1.SelectedIndex!=1)
            {
                dateTimePicker1.Visible= true;
                dateTimePicker2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;  
                avabtn.Visible= true;
                label5.Visible = true;
                label6.Visible= true;   
                confirmbtn.Visible= true;
            }
           
            if(comboBox1.SelectedIndex==1 && comboBox1.SelectedIndex!=0)       
            {
                label3.Visible=true;
                comboBox2.Visible=true;
                label5.Visible = true;
                label6.Visible = true;
                confirmbtn.Visible = true;
                //bakılacak akşam
                
            }
        }
    }
}
