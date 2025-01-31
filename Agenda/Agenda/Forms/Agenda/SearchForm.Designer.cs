namespace Agenda.Forms.Agenda
{
    partial class SearchForm
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
            this.combox_klanten = new System.Windows.Forms.ComboBox();
            this.btn_zoeken = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // combox_klanten
            // 
            this.combox_klanten.FormattingEnabled = true;
            this.combox_klanten.Location = new System.Drawing.Point(12, 12);
            this.combox_klanten.Name = "combox_klanten";
            this.combox_klanten.Size = new System.Drawing.Size(180, 21);
            this.combox_klanten.TabIndex = 0;
            // 
            // btn_zoeken
            // 
            this.btn_zoeken.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_zoeken.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_zoeken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_zoeken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_zoeken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_zoeken.ForeColor = System.Drawing.Color.White;
            this.btn_zoeken.Location = new System.Drawing.Point(12, 39);
            this.btn_zoeken.Name = "btn_zoeken";
            this.btn_zoeken.Size = new System.Drawing.Size(180, 30);
            this.btn_zoeken.TabIndex = 1;
            this.btn_zoeken.Text = "Zoeken";
            this.btn_zoeken.Click += new System.EventHandler(this.btn_zoeken_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 81);
            this.Controls.Add(this.btn_zoeken);
            this.Controls.Add(this.combox_klanten);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zoeken";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_klanten;
        private Guna.UI2.WinForms.Guna2Button btn_zoeken;
    }
}