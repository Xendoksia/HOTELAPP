namespace HOTELAPP
{
    partial class ReservationHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationHistory));
            rjButton1 = new CustomControls.RJControls.RJButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rjButton2 = new CustomControls.RJControls.RJButton();
            modifybtn = new CustomControls.RJControls.RJButton();
            manageReservations1 = new ManageReservations();
            SuspendLayout();
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Purple;
            rjButton1.BackgroundColor = Color.Purple;
            rjButton1.BackgroundImageLayout = ImageLayout.None;
            rjButton1.BorderColor = Color.White;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 1;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Image = Properties.Resources.undo_21;
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.Location = new Point(48, 56);
            rjButton1.Margin = new Padding(3, 5, 3, 5);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(165, 69);
            rjButton1.TabIndex = 13;
            rjButton1.Text = "Go Back";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumAquamarine;
            textBox1.Location = new Point(363, 152);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(730, 80);
            textBox1.TabIndex = 14;
            textBox1.Text = "burda alt alta eklenicek yeşil olan aktif olan kırmızılar geçmiş olan";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Crimson;
            textBox2.Location = new Point(363, 261);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(730, 80);
            textBox2.TabIndex = 15;
            textBox2.Text = "burda alt alta eklenicek yeşil olan aktif olan kırmızılar geçmiş olan";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Purple;
            rjButton2.BackgroundColor = Color.Purple;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 0;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(1101, 167);
            rjButton2.Margin = new Padding(3, 4, 3, 4);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(81, 51);
            rjButton2.TabIndex = 16;
            rjButton2.Text = "Cancel";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // modifybtn
            // 
            modifybtn.BackColor = Color.Purple;
            modifybtn.BackgroundColor = Color.Purple;
            modifybtn.BorderColor = Color.PaleVioletRed;
            modifybtn.BorderRadius = 0;
            modifybtn.BorderSize = 0;
            modifybtn.FlatAppearance.BorderSize = 0;
            modifybtn.FlatStyle = FlatStyle.Flat;
            modifybtn.ForeColor = Color.White;
            modifybtn.Location = new Point(1207, 167);
            modifybtn.Margin = new Padding(3, 4, 3, 4);
            modifybtn.Name = "modifybtn";
            modifybtn.Size = new Size(81, 51);
            modifybtn.TabIndex = 17;
            modifybtn.Text = "Modify";
            modifybtn.TextColor = Color.White;
            modifybtn.UseVisualStyleBackColor = false;
            modifybtn.Click += modifybtn_Click;
            // 
            // manageReservations1
            // 
            manageReservations1.BackColor = SystemColors.ScrollBar;
            manageReservations1.BackgroundImage = (Image)resources.GetObject("manageReservations1.BackgroundImage");
            manageReservations1.Location = new Point(-7, 1);
            manageReservations1.Margin = new Padding(3, 5, 3, 5);
            manageReservations1.Name = "manageReservations1";
            manageReservations1.Size = new Size(1512, 908);
            manageReservations1.TabIndex = 18;
            manageReservations1.Visible = false;
            manageReservations1.Load += manageReservations1_Load;
            // 
            // ReservationHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 825);
            Controls.Add(manageReservations1);
            Controls.Add(modifybtn);
            Controls.Add(rjButton2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(rjButton1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservationHistory";
            Load += ReservationHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton modifybtn;
        private ManageReservations manageReservations1;
    }
}