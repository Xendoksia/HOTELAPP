using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HOTELAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            // Yuvarlakl�k varm� riad
            int borderRadius = 50; // Yuvarlakl�k miktar�, iste�e ba�l� olarak ayarlanabilir.
            int borderWidth = 20; // Kenarl�k kal�nl���
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
           

            // Panelin kenarlar�na yuvarlakl�k efektini uyguluyoruz.
            using (GraphicsPath borderPath = new GraphicsPath())
            {
                Rectangle borderRectangle = new Rectangle(0, 0, panel.Width, panel.Height);

                borderPath.AddArc(borderRectangle.X, borderRectangle.Y, borderRadius, borderRadius, 180, 90); // Sol �st k��e
                borderPath.AddArc(borderRectangle.X + borderRectangle.Width - borderRadius, borderRectangle.Y, borderRadius, borderRadius, 270, 90); // Sa� �st k��e
                borderPath.AddArc(borderRectangle.X + borderRectangle.Width - borderRadius, borderRectangle.Y + borderRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Sa� alt k��e
                borderPath.AddArc(borderRectangle.X, borderRectangle.Y + borderRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Sol alt k��e
                borderPath.CloseAllFigures();

                using (Pen pen = new Pen(Color.FromArgb(152, 255, 242), borderWidth)) // Border rengini ve kal�nl��� ayarl�yoruz
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, borderPath);
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
