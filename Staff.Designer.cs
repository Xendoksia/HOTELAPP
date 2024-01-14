namespace HOTELAPP
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidebarBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.newreservation = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manageRooms1 = new HOTELAPP.ManageRooms();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HOTELAPP.Properties.Resources.Ekran_görüntüsü_2024_01_09_191059;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.SidebarBtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 227);
            this.panel2.TabIndex = 1;
            // 
            // SidebarBtn
            // 
            this.SidebarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SidebarBtn.Image = global::HOTELAPP.Properties.Resources.menu;
            this.SidebarBtn.Location = new System.Drawing.Point(-3, 0);
            this.SidebarBtn.Name = "SidebarBtn";
            this.SidebarBtn.Size = new System.Drawing.Size(60, 51);
            this.SidebarBtn.TabIndex = 1;
            this.SidebarBtn.UseVisualStyleBackColor = false;
            this.SidebarBtn.Click += new System.EventHandler(this.SidebarBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Controls.Add(this.newreservation);
            this.panel6.Location = new System.Drawing.Point(3, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 56);
            this.panel6.TabIndex = 4;
            // 
            // newreservation
            // 
            this.newreservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newreservation.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newreservation.ForeColor = System.Drawing.SystemColors.Control;
            this.newreservation.Image = global::HOTELAPP.Properties.Resources.check;
            this.newreservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newreservation.Location = new System.Drawing.Point(-45, -19);
            this.newreservation.Name = "newreservation";
            this.newreservation.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.newreservation.Size = new System.Drawing.Size(341, 85);
            this.newreservation.TabIndex = 3;
            this.newreservation.Text = "        New Reservation";
            this.newreservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newreservation.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(3, 298);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 56);
            this.panel5.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::HOTELAPP.Properties.Resources.hammer;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-45, -14);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(311, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "Room Management";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 678);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 56);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::HOTELAPP.Properties.Resources.home__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-45, -12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(341, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "        Main Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 101);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 101);
            this.label3.TabIndex = 8;
            this.label3.Text = "<<------------------";
            // 
            // manageRooms1
            // 
            this.manageRooms1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageRooms1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manageRooms1.BackgroundImage")));
            this.manageRooms1.ForeColor = System.Drawing.SystemColors.Control;
            this.manageRooms1.Location = new System.Drawing.Point(35, 12);
            this.manageRooms1.Name = "manageRooms1";
            this.manageRooms1.Size = new System.Drawing.Size(1400, 638);
            this.manageRooms1.TabIndex = 9;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1325, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.manageRooms1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Panel panel5;
        private Button button3;
        private Panel panel6;
        private Button newreservation;
        private Button SidebarBtn;
        private System.Windows.Forms.Timer SidebarTimer;
        private FlowLayoutPanel panel1;
        private Panel panel3;
        private Button button1;
        private Label label1;
        private Label label3;
        private ManageRooms manageRooms1;
        
    }
}