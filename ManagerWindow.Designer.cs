namespace HOTELAPP
{
    partial class ManagerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientbtn = new FontAwesome.Sharp.IconButton();
            this.empbtn = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelm = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.labeldate = new System.Windows.Forms.Label();
            this.employees1 = new HOTELAPP.Employees();
            this.clientList1 = new HOTELAPP.ClientList();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.clientbtn);
            this.panel1.Controls.Add(this.empbtn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panelm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 644);
            this.panel1.TabIndex = 0;
            // 
            // clientbtn
            // 
            this.clientbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.clientbtn.FlatAppearance.BorderSize = 0;
            this.clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientbtn.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientbtn.ForeColor = System.Drawing.Color.White;
            this.clientbtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.clientbtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.clientbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientbtn.Location = new System.Drawing.Point(22, 220);
            this.clientbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(259, 65);
            this.clientbtn.TabIndex = 2;
            this.clientbtn.Text = "        Clients";
            this.clientbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientbtn.UseVisualStyleBackColor = false;
            this.clientbtn.Click += new System.EventHandler(this.clientbtn_Click);
            // 
            // empbtn
            // 
            this.empbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.empbtn.FlatAppearance.BorderSize = 0;
            this.empbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empbtn.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empbtn.ForeColor = System.Drawing.Color.White;
            this.empbtn.IconChar = FontAwesome.Sharp.IconChar.PersonMilitaryPointing;
            this.empbtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.empbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.empbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empbtn.Location = new System.Drawing.Point(22, 149);
            this.empbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empbtn.Name = "empbtn";
            this.empbtn.Size = new System.Drawing.Size(259, 65);
            this.empbtn.TabIndex = 2;
            this.empbtn.Text = "   Employees";
            this.empbtn.UseVisualStyleBackColor = false;
            this.empbtn.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 126);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Icardi";
            // 
            // panelm
            // 
            this.panelm.BackColor = System.Drawing.Color.AliceBlue;
            this.panelm.Location = new System.Drawing.Point(4, 149);
            this.panelm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelm.Name = "panelm";
            this.panelm.Size = new System.Drawing.Size(10, 54);
            this.panelm.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.rjCircularPictureBox1);
            this.panel2.Controls.Add(this.labeldate);
            this.panel2.Location = new System.Drawing.Point(266, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 126);
            this.panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(925, 77);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 35);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::HOTELAPP.Properties.Resources._150708;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(949, 3);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(71, 71);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 3;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldate.ForeColor = System.Drawing.Color.White;
            this.labeldate.Location = new System.Drawing.Point(58, 37);
            this.labeldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(90, 37);
            this.labeldate.TabIndex = 0;
            this.labeldate.Text = "label3";
            // 
            // employees1
            // 
            this.employees1.BackColor = System.Drawing.Color.MidnightBlue;
            this.employees1.ForeColor = System.Drawing.Color.Coral;
            this.employees1.Location = new System.Drawing.Point(278, 132);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(1058, 526);
            this.employees1.TabIndex = 3;
            // 
            // clientList1
            // 
            this.clientList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientList1.BackColor = System.Drawing.Color.MidnightBlue;
            this.clientList1.Location = new System.Drawing.Point(278, 132);
            this.clientList1.Name = "clientList1";
            this.clientList1.Size = new System.Drawing.Size(1058, 538);
            this.clientList1.TabIndex = 5;
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1335, 642);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clientList1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManagerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerWindow";
            this.Load += new System.EventHandler(this.ManagerWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelm;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Label labeldate;
        private FontAwesome.Sharp.IconButton clientbtn;
        private FontAwesome.Sharp.IconButton empbtn;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private LinkLabel linkLabel1;
        private Employees employees1;
        private ClientList clientList1;
    }
}