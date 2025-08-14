namespace Agenda.Forms.Agenda.Waitlist
{
    partial class WaitlistForm
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
            this.combox_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_voorkeur = new Guna.UI2.WinForms.Guna2TextBox();
            this.toevoegen = new Guna.UI2.WinForms.Guna2Button();
            this.aanpassen = new Guna.UI2.WinForms.Guna2Button();
            this.verwijderen = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // combox_name
            // 
            this.combox_name.FormattingEnabled = true;
            this.combox_name.Location = new System.Drawing.Point(20, 40);
            this.combox_name.Name = "combox_name";
            this.combox_name.Size = new System.Drawing.Size(215, 21);
            this.combox_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Voorkeur";
            // 
            // txtbox_voorkeur
            // 
            this.txtbox_voorkeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_voorkeur.DefaultText = "";
            this.txtbox_voorkeur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_voorkeur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_voorkeur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_voorkeur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_voorkeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_voorkeur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_voorkeur.ForeColor = System.Drawing.Color.Black;
            this.txtbox_voorkeur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_voorkeur.Location = new System.Drawing.Point(20, 100);
            this.txtbox_voorkeur.Multiline = true;
            this.txtbox_voorkeur.Name = "txtbox_voorkeur";
            this.txtbox_voorkeur.PasswordChar = '\0';
            this.txtbox_voorkeur.PlaceholderText = "";
            this.txtbox_voorkeur.SelectedText = "";
            this.txtbox_voorkeur.Size = new System.Drawing.Size(215, 136);
            this.txtbox_voorkeur.TabIndex = 8;
            // 
            // toevoegen
            // 
            this.toevoegen.BorderRadius = 10;
            this.toevoegen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.toevoegen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.toevoegen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.toevoegen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.toevoegen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.toevoegen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toevoegen.ForeColor = System.Drawing.Color.Black;
            this.toevoegen.Location = new System.Drawing.Point(20, 250);
            this.toevoegen.Name = "toevoegen";
            this.toevoegen.Size = new System.Drawing.Size(215, 45);
            this.toevoegen.TabIndex = 9;
            this.toevoegen.Text = "Toevoegen";
            this.toevoegen.Click += new System.EventHandler(this.InsertWaitlist);
            // 
            // aanpassen
            // 
            this.aanpassen.BorderRadius = 10;
            this.aanpassen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aanpassen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aanpassen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aanpassen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aanpassen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.aanpassen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aanpassen.ForeColor = System.Drawing.Color.Black;
            this.aanpassen.Location = new System.Drawing.Point(20, 250);
            this.aanpassen.Name = "aanpassen";
            this.aanpassen.Size = new System.Drawing.Size(100, 45);
            this.aanpassen.TabIndex = 10;
            this.aanpassen.Text = "Aanpassen";
            this.aanpassen.Visible = false;
            this.aanpassen.Click += new System.EventHandler(this.UpdateWaitlist);
            // 
            // verwijderen
            // 
            this.verwijderen.BorderRadius = 10;
            this.verwijderen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verwijderen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verwijderen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verwijderen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verwijderen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.verwijderen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verwijderen.ForeColor = System.Drawing.Color.Black;
            this.verwijderen.Location = new System.Drawing.Point(135, 250);
            this.verwijderen.Name = "verwijderen";
            this.verwijderen.Size = new System.Drawing.Size(100, 45);
            this.verwijderen.TabIndex = 11;
            this.verwijderen.Text = "Verwijderen";
            this.verwijderen.Visible = false;
            this.verwijderen.Click += new System.EventHandler(this.DeleteWaitlist);
            // 
            // WaitlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 311);
            this.Controls.Add(this.verwijderen);
            this.Controls.Add(this.aanpassen);
            this.Controls.Add(this.toevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_voorkeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitlistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toevoegen aan wachtlijst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_voorkeur;
        private Guna.UI2.WinForms.Guna2Button toevoegen;
        private Guna.UI2.WinForms.Guna2Button aanpassen;
        private Guna.UI2.WinForms.Guna2Button verwijderen;
    }
}