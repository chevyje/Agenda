namespace Agenda.UserControls.Agenda
{
    partial class UC_WaitList
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_voorkeur = new System.Windows.Forms.Label();
            this.detailLine = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(10, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Naam";
            // 
            // lbl_voorkeur
            // 
            this.lbl_voorkeur.Location = new System.Drawing.Point(10, 50);
            this.lbl_voorkeur.Name = "lbl_voorkeur";
            this.lbl_voorkeur.Size = new System.Drawing.Size(195, 63);
            this.lbl_voorkeur.TabIndex = 1;
            this.lbl_voorkeur.Text = "Voorkeur";
            // 
            // detailLine
            // 
            this.detailLine.AllowDrop = true;
            this.detailLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(164)))), ((int)(((byte)(173)))));
            this.detailLine.Location = new System.Drawing.Point(10, 35);
            this.detailLine.Name = "detailLine";
            this.detailLine.Size = new System.Drawing.Size(195, 3);
            this.detailLine.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.guna2ImageButton1.Image = global::Agenda.Properties.Resources.edit_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(185, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.guna2ImageButton1.Size = new System.Drawing.Size(27, 26);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.Click += new System.EventHandler(this.Edit);
            // 
            // UC_WaitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.detailLine);
            this.Controls.Add(this.lbl_voorkeur);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name = "UC_WaitList";
            this.Size = new System.Drawing.Size(215, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_voorkeur;
        private Guna.UI2.WinForms.Guna2Panel detailLine;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
