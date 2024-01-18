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
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            modifybtn = new CustomControls.RJControls.RJButton();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
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
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(430, 157);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(508, 53);
            comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(430, 281);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(508, 53);
            comboBox2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(430, 96);
            label1.Name = "label1";
            label1.Size = new Size(382, 57);
            label1.TabIndex = 20;
            label1.Text = "Active Reservations";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(430, 220);
            label2.Name = "label2";
            label2.Size = new Size(337, 57);
            label2.TabIndex = 21;
            label2.Text = "Old Reservations";
            // 
            // ReservationHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 825);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(modifybtn);
            Controls.Add(rjButton2);
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
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton modifybtn;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
    }
}