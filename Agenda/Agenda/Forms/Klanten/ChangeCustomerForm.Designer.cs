namespace Agenda.Forms.Klanten
{
    partial class ChangeCustomerForm
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
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.datetimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_postcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_city = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_street = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(12, 497);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 40);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Opslaan";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // datetimepicker
            // 
            this.datetimepicker.AllowDrop = true;
            this.datetimepicker.Checked = true;
            this.datetimepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepicker.Location = new System.Drawing.Point(12, 86);
            this.datetimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(325, 36);
            this.datetimepicker.TabIndex = 15;
            this.datetimepicker.Value = new System.DateTime(2024, 12, 29, 22, 2, 22, 554);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Plaats naam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Straat naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefoon nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Geboorte datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naam";
            // 
            // txtbox_postcode
            // 
            this.txtbox_postcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_postcode.DefaultText = "";
            this.txtbox_postcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_postcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_postcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_postcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_postcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_postcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_postcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_postcode.Location = new System.Drawing.Point(12, 441);
            this.txtbox_postcode.Name = "txtbox_postcode";
            this.txtbox_postcode.PasswordChar = '\0';
            this.txtbox_postcode.PlaceholderText = "";
            this.txtbox_postcode.SelectedText = "";
            this.txtbox_postcode.Size = new System.Drawing.Size(325, 36);
            this.txtbox_postcode.TabIndex = 21;
            // 
            // txtbox_city
            // 
            this.txtbox_city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_city.DefaultText = "";
            this.txtbox_city.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_city.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_city.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_city.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_city.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_city.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_city.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_city.Location = new System.Drawing.Point(12, 373);
            this.txtbox_city.Name = "txtbox_city";
            this.txtbox_city.PasswordChar = '\0';
            this.txtbox_city.PlaceholderText = "";
            this.txtbox_city.SelectedText = "";
            this.txtbox_city.Size = new System.Drawing.Size(325, 36);
            this.txtbox_city.TabIndex = 19;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_email.DefaultText = "";
            this.txtbox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_email.Location = new System.Drawing.Point(12, 155);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.PasswordChar = '\0';
            this.txtbox_email.PlaceholderText = "";
            this.txtbox_email.SelectedText = "";
            this.txtbox_email.Size = new System.Drawing.Size(325, 36);
            this.txtbox_email.TabIndex = 16;
            // 
            // txtbox_number
            // 
            this.txtbox_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_number.DefaultText = "";
            this.txtbox_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_number.Location = new System.Drawing.Point(12, 228);
            this.txtbox_number.Name = "txtbox_number";
            this.txtbox_number.PasswordChar = '\0';
            this.txtbox_number.PlaceholderText = "";
            this.txtbox_number.SelectedText = "";
            this.txtbox_number.Size = new System.Drawing.Size(325, 36);
            this.txtbox_number.TabIndex = 17;
            // 
            // txtbox_street
            // 
            this.txtbox_street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_street.DefaultText = "";
            this.txtbox_street.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_street.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_street.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_street.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_street.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_street.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_street.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_street.Location = new System.Drawing.Point(12, 296);
            this.txtbox_street.Name = "txtbox_street";
            this.txtbox_street.PasswordChar = '\0';
            this.txtbox_street.PlaceholderText = "";
            this.txtbox_street.SelectedText = "";
            this.txtbox_street.Size = new System.Drawing.Size(325, 36);
            this.txtbox_street.TabIndex = 18;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_name.DefaultText = "";
            this.txtbox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_name.Location = new System.Drawing.Point(12, 23);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.PasswordChar = '\0';
            this.txtbox_name.PlaceholderText = "";
            this.txtbox_name.SelectedText = "";
            this.txtbox_name.Size = new System.Drawing.Size(325, 36);
            this.txtbox_name.TabIndex = 14;
            // 
            // btn_delete
            // 
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(186, 497);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 40);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Verwijderen";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ChangeCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 549);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_postcode);
            this.Controls.Add(this.txtbox_city);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.txtbox_number);
            this.Controls.Add(this.txtbox_street);
            this.Controls.Add(this.txtbox_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Klant relatie aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_postcode;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_city;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_email;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_number;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_street;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_name;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
    }
}