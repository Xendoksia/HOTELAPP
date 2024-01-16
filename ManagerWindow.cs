using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELAPP
{
    public partial class ManagerWindow : Form
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            panelm.Top = btn.Top;
            panelm.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeldate.Text = DateTime.Now.ToString("dd.MM.yyyy    hh:mm:ss");
        }

        private void ManagerWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            // SqlConnection oluştur

        }

       

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            MovePanel(empbtn);
            employees1.Visible= true;
            
            clientList1.Visible = false;
            

        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            MovePanel(clientbtn);
            employees1.Visible = false;
            
            clientList1.Visible = true;
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
