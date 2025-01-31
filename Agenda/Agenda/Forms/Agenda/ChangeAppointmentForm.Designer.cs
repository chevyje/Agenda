namespace Agenda.Forms.Agenda
{
    partial class ChangeAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.combox_Time = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combox_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combox_Length = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combox_Name = new System.Windows.Forms.ComboBox();
            this.dateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtbox_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lengte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soort behandeling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Beschrijving";
            // 
            // btn_Save
            // 
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(12, 524);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 45);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Opslaan";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(157, 524);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 45);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Verwijderen";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // combox_Time
            // 
            this.combox_Time.BackColor = System.Drawing.Color.Transparent;
            this.combox_Time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_Time.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_Time.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_Time.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combox_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combox_Time.ItemHeight = 30;
            this.combox_Time.Items.AddRange(new object[] {
            "09:00",
            "10:00"});
            this.combox_Time.Location = new System.Drawing.Point(15, 146);
            this.combox_Time.Name = "combox_Time";
            this.combox_Time.Size = new System.Drawing.Size(267, 36);
            this.combox_Time.TabIndex = 8;
            // 
            // combox_Type
            // 
            this.combox_Type.BackColor = System.Drawing.Color.Transparent;
            this.combox_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_Type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_Type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combox_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combox_Type.ItemHeight = 30;
            this.combox_Type.Items.AddRange(new object[] {
            "normaal",
            "speciaal"});
            this.combox_Type.Location = new System.Drawing.Point(15, 274);
            this.combox_Type.Name = "combox_Type";
            this.combox_Type.Size = new System.Drawing.Size(267, 36);
            this.combox_Type.TabIndex = 9;
            // 
            // combox_Length
            // 
            this.combox_Length.BackColor = System.Drawing.Color.Transparent;
            this.combox_Length.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_Length.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_Length.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_Length.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_Length.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combox_Length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combox_Length.ItemHeight = 30;
            this.combox_Length.Items.AddRange(new object[] {
            "30 minuten",
            "60 minuten"});
            this.combox_Length.Location = new System.Drawing.Point(15, 210);
            this.combox_Length.Name = "combox_Length";
            this.combox_Length.Size = new System.Drawing.Size(267, 36);
            this.combox_Length.TabIndex = 10;
            // 
            // combox_Name
            // 
            this.combox_Name.FormattingEnabled = true;
            this.combox_Name.Location = new System.Drawing.Point(16, 30);
            this.combox_Name.Name = "combox_Name";
            this.combox_Name.Size = new System.Drawing.Size(266, 21);
            this.combox_Name.TabIndex = 11;
            // 
            // dateTime
            // 
            this.dateTime.Checked = true;
            this.dateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTime.Location = new System.Drawing.Point(15, 80);
            this.dateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(267, 36);
            this.dateTime.TabIndex = 12;
            this.dateTime.Value = new System.DateTime(2024, 12, 29, 16, 33, 12, 285);
            // 
            // txtbox_Description
            // 
            this.txtbox_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Description.DefaultText = "";
            this.txtbox_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Description.Location = new System.Drawing.Point(15, 338);
            this.txtbox_Description.Multiline = true;
            this.txtbox_Description.Name = "txtbox_Description";
            this.txtbox_Description.PasswordChar = '\0';
            this.txtbox_Description.PlaceholderText = "";
            this.txtbox_Description.SelectedText = "";
            this.txtbox_Description.Size = new System.Drawing.Size(267, 163);
            this.txtbox_Description.TabIndex = 13;
            // 
            // ChangeAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 581);
            this.Controls.Add(this.txtbox_Description);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.combox_Name);
            this.Controls.Add(this.combox_Length);
            this.Controls.Add(this.combox_Type);
            this.Controls.Add(this.combox_Time);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weizig afspraak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2ComboBox combox_Time;
        private Guna.UI2.WinForms.Guna2ComboBox combox_Type;
        private Guna.UI2.WinForms.Guna2ComboBox combox_Length;
        private System.Windows.Forms.ComboBox combox_Name;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTime;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Description;
    }
}