namespace HOTELAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pw1 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pw1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.IBeam;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(455, 104);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 638);
            panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.MediumSlateBlue;
            checkBox1.Location = new Point(335, 408);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.LightSkyBlue;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 3;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(53, 423);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(152, 63);
            rjButton1.TabIndex = 7;
            rjButton1.Text = "Sign in";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.PaleTurquoise;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.MediumSlateBlue;
            linkLabel1.Location = new Point(226, 532);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up here.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(130, 532);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Are you new?";
            // 
            // pw1
            // 
            pw1.BorderStyle = BorderStyle.FixedSingle;
            pw1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            pw1.Location = new Point(53, 327);
            pw1.Margin = new Padding(3, 4, 3, 4);
            pw1.Multiline = true;
            pw1.Name = "pw1";
            pw1.PasswordChar = '*';
            pw1.Size = new Size(357, 61);
            pw1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(53, 163);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 58);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(53, 276);
            label2.Name = "label2";
            label2.Size = new Size(120, 36);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(53, 109);
            label1.Name = "label1";
            label1.Size = new Size(137, 36);
            label1.TabIndex = 0;
            label1.Text = "ID Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.wallpaperflare1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1424, 812);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label3;
        private CustomControls.RJControls.RJButton rjButton1;
        protected TextBox pw1;
        private CheckBox checkBox1;
    }
}