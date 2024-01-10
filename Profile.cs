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
    public partial class Profile : Form
    {
        string username;
        public Profile(string user)
        {
            InitializeComponent();
            SetGradientBackground();
            username = user;
        }
        public void SetGradientBackground()
        {
          
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.MediumSlateBlue,
                Color.Purple,
                LinearGradientMode.Vertical);  

            
            this.BackgroundImage = CreateBackgroundImage(this.ClientRectangle.Size, gradientBrush);
        }
        public Bitmap CreateBackgroundImage(Size size, Brush brush)
        {
            
            Bitmap bitmap = new Bitmap(size.Width, size.Height);

           
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                
                g.FillRectangle(brush, new Rectangle(Point.Empty, size));
            }

            return bitmap;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form3 pr = new Form3(username);//Create the new form
            pr.Show();//display Form2 to the user
            this.Close();
        }
    }
}
