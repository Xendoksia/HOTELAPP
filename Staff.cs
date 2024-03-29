﻿using System;
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
    public partial class Staff : Form
    {
        public Staff()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            manageRooms1.Visible = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool sidebarExpanded = false;

        private void SidebarBtn_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                if (panel1.Width > 60)
                {
                    panel1.Width -= 10;
                }
                else
                {
                    sidebarExpanded = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                if (panel1.Width < 257)
                {
                    panel1.Width += 10;
                }
                else
                {
                    sidebarExpanded = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageRooms1.Visible = true;
            addNewManualReservation1.Visible= false;
            label1.Visible= false;
            label3.Visible= false;
            

        }


        private void newreservation_Click(object sender, EventArgs e)
        {
            addNewManualReservation1.Visible= true;
            manageRooms1.Visible= false;
            label1.Visible = false;
            label3.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
