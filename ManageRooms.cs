using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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

        private void ManageRooms_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
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
        }

    }
}

