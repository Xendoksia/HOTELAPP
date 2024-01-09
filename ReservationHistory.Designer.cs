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
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Purple;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Purple;
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::HOTELAPP.Properties.Resources.undo_21;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(42, 42);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(144, 52);
            this.rjButton1.TabIndex = 13;
            this.rjButton1.Text = "Go Back";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox1.Location = new System.Drawing.Point(318, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(639, 61);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "burda alt alta eklenicek yeşil olan aktif olan kırmızılar geçmiş olan";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Crimson;
            this.textBox2.Location = new System.Drawing.Point(318, 196);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(639, 61);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "burda alt alta eklenicek yeşil olan aktif olan kırmızılar geçmiş olan";
            // 
            // ReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 695);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rjButton1);
            this.Name = "ReservationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationHistory";
            this.Load += new System.EventHandler(this.ReservationHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}