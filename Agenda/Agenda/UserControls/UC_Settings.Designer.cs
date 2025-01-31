namespace Agenda.UserControls
{
    partial class UC_Settings
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
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ChosableTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_PathDb = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TypesOfMassages = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_PathSettings = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BonId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Length = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(46, 926);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(180, 45);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Opslaan";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bestandspad naar de database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1337, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wachtwoord";
            // 
            // txt_ChosableTime
            // 
            this.txt_ChosableTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChosableTime.DefaultText = "";
            this.txt_ChosableTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ChosableTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ChosableTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ChosableTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ChosableTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ChosableTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ChosableTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ChosableTime.Location = new System.Drawing.Point(46, 224);
            this.txt_ChosableTime.Multiline = true;
            this.txt_ChosableTime.Name = "txt_ChosableTime";
            this.txt_ChosableTime.PasswordChar = '\0';
            this.txt_ChosableTime.PlaceholderText = "";
            this.txt_ChosableTime.SelectedText = "";
            this.txt_ChosableTime.Size = new System.Drawing.Size(224, 397);
            this.txt_ChosableTime.TabIndex = 3;
            // 
            // txt_PathDb
            // 
            this.txt_PathDb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PathDb.DefaultText = "";
            this.txt_PathDb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PathDb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PathDb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PathDb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PathDb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PathDb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PathDb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PathDb.Location = new System.Drawing.Point(46, 65);
            this.txt_PathDb.Name = "txt_PathDb";
            this.txt_PathDb.PasswordChar = '\0';
            this.txt_PathDb.PlaceholderText = "";
            this.txt_PathDb.SelectedText = "";
            this.txt_PathDb.Size = new System.Drawing.Size(1244, 36);
            this.txt_PathDb.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(1341, 65);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(325, 36);
            this.txt_Password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beschikbare tijden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Massages";
            // 
            // txt_TypesOfMassages
            // 
            this.txt_TypesOfMassages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TypesOfMassages.DefaultText = "";
            this.txt_TypesOfMassages.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TypesOfMassages.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TypesOfMassages.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TypesOfMassages.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TypesOfMassages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TypesOfMassages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TypesOfMassages.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TypesOfMassages.Location = new System.Drawing.Point(323, 224);
            this.txt_TypesOfMassages.Multiline = true;
            this.txt_TypesOfMassages.Name = "txt_TypesOfMassages";
            this.txt_TypesOfMassages.PasswordChar = '\0';
            this.txt_TypesOfMassages.PlaceholderText = "";
            this.txt_TypesOfMassages.SelectedText = "";
            this.txt_TypesOfMassages.Size = new System.Drawing.Size(224, 397);
            this.txt_TypesOfMassages.TabIndex = 7;
            // 
            // txt_PathSettings
            // 
            this.txt_PathSettings.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PathSettings.DefaultText = "";
            this.txt_PathSettings.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PathSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PathSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PathSettings.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PathSettings.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PathSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PathSettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PathSettings.Location = new System.Drawing.Point(46, 143);
            this.txt_PathSettings.Name = "txt_PathSettings";
            this.txt_PathSettings.PasswordChar = '\0';
            this.txt_PathSettings.PlaceholderText = "";
            this.txt_PathSettings.SelectedText = "";
            this.txt_PathSettings.Size = new System.Drawing.Size(1244, 36);
            this.txt_PathSettings.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bestandspad naar de instellingen";
            // 
            // txt_BonId
            // 
            this.txt_BonId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BonId.DefaultText = "";
            this.txt_BonId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_BonId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_BonId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BonId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BonId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BonId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_BonId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BonId.Location = new System.Drawing.Point(1341, 143);
            this.txt_BonId.Name = "txt_BonId";
            this.txt_BonId.PasswordChar = '\0';
            this.txt_BonId.PlaceholderText = "";
            this.txt_BonId.SelectedText = "";
            this.txt_BonId.Size = new System.Drawing.Size(325, 36);
            this.txt_BonId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1337, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Laatst gebruikte bon nummer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lengte in minuten";
            // 
            // txt_Length
            // 
            this.txt_Length.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Length.DefaultText = "";
            this.txt_Length.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Length.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Length.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Length.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Length.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Length.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Length.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Length.Location = new System.Drawing.Point(596, 224);
            this.txt_Length.Multiline = true;
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.PasswordChar = '\0';
            this.txt_Length.PlaceholderText = "";
            this.txt_Length.SelectedText = "";
            this.txt_Length.Size = new System.Drawing.Size(224, 397);
            this.txt_Length.TabIndex = 13;
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Length);
            this.Controls.Add(this.txt_BonId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PathSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TypesOfMassages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_PathDb);
            this.Controls.Add(this.txt_ChosableTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1700, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_ChosableTime;
        private Guna.UI2.WinForms.Guna2TextBox txt_PathDb;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_TypesOfMassages;
        private Guna.UI2.WinForms.Guna2TextBox txt_PathSettings;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_BonId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_Length;
    }
}
