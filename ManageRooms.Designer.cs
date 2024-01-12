namespace HOTELAPP
{
    partial class ManageRooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomt = new System.Windows.Forms.ComboBox();
            this.roomn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffchoose = new System.Windows.Forms.ComboBox();
            this.cslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.liststaffbtn = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.assbtn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // roomt
            // 
            this.roomt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomt.FormattingEnabled = true;
            this.roomt.Items.AddRange(new object[] {
            "sd"});
            this.roomt.Location = new System.Drawing.Point(448, 159);
            this.roomt.Name = "roomt";
            this.roomt.Size = new System.Drawing.Size(309, 23);
            this.roomt.TabIndex = 0;
            // 
            // roomn
            // 
            this.roomn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomn.FormattingEnabled = true;
            this.roomn.Items.AddRange(new object[] {
            "s"});
            this.roomn.Location = new System.Drawing.Point(448, 250);
            this.roomn.Name = "roomn";
            this.roomn.Size = new System.Drawing.Size(309, 23);
            this.roomn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(448, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Room Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(448, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Room Number";
            // 
            // staffchoose
            // 
            this.staffchoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffchoose.FormattingEnabled = true;
            this.staffchoose.Location = new System.Drawing.Point(448, 394);
            this.staffchoose.Name = "staffchoose";
            this.staffchoose.Size = new System.Drawing.Size(309, 23);
            this.staffchoose.TabIndex = 5;
            this.staffchoose.Visible = false;
            // 
            // cslabel
            // 
            this.cslabel.AutoSize = true;
            this.cslabel.BackColor = System.Drawing.Color.Transparent;
            this.cslabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cslabel.ForeColor = System.Drawing.SystemColors.Control;
            this.cslabel.Location = new System.Drawing.Point(448, 366);
            this.cslabel.Name = "cslabel";
            this.cslabel.Size = new System.Drawing.Size(136, 25);
            this.cslabel.TabIndex = 6;
            this.cslabel.Text = "Choose a Staff:";
            this.cslabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(840, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose Operation:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(849, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Maintanance";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Location = new System.Drawing.Point(849, 201);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 19);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Cleaning";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // liststaffbtn
            // 
            this.liststaffbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.liststaffbtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.liststaffbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.liststaffbtn.BorderRadius = 0;
            this.liststaffbtn.BorderSize = 0;
            this.liststaffbtn.FlatAppearance.BorderSize = 0;
            this.liststaffbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liststaffbtn.ForeColor = System.Drawing.Color.White;
            this.liststaffbtn.Location = new System.Drawing.Point(849, 233);
            this.liststaffbtn.Name = "liststaffbtn";
            this.liststaffbtn.Size = new System.Drawing.Size(150, 40);
            this.liststaffbtn.TabIndex = 10;
            this.liststaffbtn.Text = "List the Staff";
            this.liststaffbtn.TextColor = System.Drawing.Color.White;
            this.liststaffbtn.UseVisualStyleBackColor = false;
            this.liststaffbtn.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(448, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(682, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------------------";
            // 
            // assbtn
            // 
            this.assbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.assbtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.assbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.assbtn.BorderRadius = 0;
            this.assbtn.BorderSize = 0;
            this.assbtn.FlatAppearance.BorderSize = 0;
            this.assbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assbtn.ForeColor = System.Drawing.Color.White;
            this.assbtn.Location = new System.Drawing.Point(849, 377);
            this.assbtn.Name = "assbtn";
            this.assbtn.Size = new System.Drawing.Size(150, 40);
            this.assbtn.TabIndex = 12;
            this.assbtn.Text = "Assign";
            this.assbtn.TextColor = System.Drawing.Color.White;
            this.assbtn.UseVisualStyleBackColor = false;
            this.assbtn.Visible = false;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.assbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liststaffbtn);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cslabel);
            this.Controls.Add(this.staffchoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomn);
            this.Controls.Add(this.roomt);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ManageRooms";
            this.Size = new System.Drawing.Size(1228, 558);
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox roomt;
        private ComboBox roomn;
        private Label label1;
        private Label label2;
        private ComboBox staffchoose;
        private Label cslabel;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CustomControls.RJControls.RJButton liststaffbtn;
        private Label label3;
        private CustomControls.RJControls.RJButton assbtn;
    }
}
