using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            MovePanel(dashbbtn);
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            MovePanel(empbtn);
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            MovePanel(clientbtn);
        }

        private void ıconButton1_Click_1(object sender, EventArgs e)
        {
            MovePanel(ıconButton1);
        }
    }
}
