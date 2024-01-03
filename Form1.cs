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
            // Yuvarlaklýk varmý riad
            int borderRadius = 50; // Yuvarlaklýk miktarý, isteðe baðlý olarak ayarlanabilir.
            int borderWidth = 30; // Kenarlýk kalýnlýðý
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
           

            // Panelin kenarlarýna yuvarlaklýk efektini uyguluyoruz.
            using (GraphicsPath borderPath = new GraphicsPath())
            {
                Rectangle borderRectangle = new Rectangle(0, 0, panel.Width, panel.Height);

                borderPath.AddArc(borderRectangle.X, borderRectangle.Y, borderRadius, borderRadius, 180, 90); // Sol üst köþe
                borderPath.AddArc(borderRectangle.X + borderRectangle.Width - borderRadius, borderRectangle.Y, borderRadius, borderRadius, 270, 90); // Sað üst köþe
                borderPath.AddArc(borderRectangle.X + borderRectangle.Width - borderRadius, borderRectangle.Y + borderRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Sað alt köþe
                borderPath.AddArc(borderRectangle.X, borderRectangle.Y + borderRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Sol alt köþe
                borderPath.CloseAllFigures();

                using (Pen pen = new Pen(Color.Blue, borderWidth)) // Border rengini ve kalýnlýðý ayarlýyoruz
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, borderPath);
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Panelin arka planýný boyamadan önce base sýnýfýndaki OnPaintBackground metodu çaðrýlmalýdýr.
            base.OnPaintBackground(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.Turquoise, 120F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
