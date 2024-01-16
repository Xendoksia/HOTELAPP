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
            this.label1 = new System.Windows.Forms.Label();
            this.assbtn = new CustomControls.RJControls.RJButton();
            this.listrooms = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // roomt
            // 
            this.roomt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomt.FormattingEnabled = true;
            this.roomt.Location = new System.Drawing.Point(448, 159);
            this.roomt.Name = "roomt";
            this.roomt.Size = new System.Drawing.Size(309, 23);
            this.roomt.TabIndex = 0;
            this.roomt.SelectedIndexChanged += new System.EventHandler(this.roomt_SelectedIndexChanged);
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
            // assbtn
            // 
            this.assbtn.AllowDrop = true;
            this.assbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.assbtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.assbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.assbtn.BorderRadius = 0;
            this.assbtn.BorderSize = 0;
            this.assbtn.FlatAppearance.BorderSize = 0;
            this.assbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assbtn.ForeColor = System.Drawing.Color.White;
            this.assbtn.Location = new System.Drawing.Point(448, 205);
            this.assbtn.Name = "assbtn";
            this.assbtn.Size = new System.Drawing.Size(150, 40);
            this.assbtn.TabIndex = 12;
            this.assbtn.Text = "Set Available";
            this.assbtn.TextColor = System.Drawing.Color.White;
            this.assbtn.UseVisualStyleBackColor = false;
            this.assbtn.Click += new System.EventHandler(this.settrue_Click);
            // 
            // listrooms
            // 
            this.listrooms.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.listrooms.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.listrooms.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.listrooms.BorderRadius = 0;
            this.listrooms.BorderSize = 0;
            this.listrooms.FlatAppearance.BorderSize = 0;
            this.listrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listrooms.ForeColor = System.Drawing.Color.White;
            this.listrooms.Location = new System.Drawing.Point(607, 205);
            this.listrooms.Name = "listrooms";
            this.listrooms.Size = new System.Drawing.Size(150, 40);
            this.listrooms.TabIndex = 13;
            this.listrooms.Text = "Set Maintance";
            this.listrooms.TextColor = System.Drawing.Color.White;
            this.listrooms.UseVisualStyleBackColor = false;
            this.listrooms.Click += new System.EventHandler(this.setfalse_Click);
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.listrooms);
            this.Controls.Add(this.assbtn);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private CustomControls.RJControls.RJButton assbtn;
        private CustomControls.RJControls.RJButton listrooms;
    }
}
