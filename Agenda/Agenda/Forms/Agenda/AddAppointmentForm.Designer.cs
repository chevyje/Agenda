namespace Agenda.Forms.Agenda
{
    partial class AddAppointmentForm
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
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.combox_time = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combox_name = new System.Windows.Forms.ComboBox();
            this.combox_length = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combox_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbox_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_makeAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(27, 73);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(215, 36);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2024, 12, 26, 13, 57, 11, 546);
            // 
            // combox_time
            // 
            this.combox_time.BackColor = System.Drawing.Color.Transparent;
            this.combox_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_time.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_time.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_time.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combox_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combox_time.ItemHeight = 30;
            this.combox_time.Items.AddRange(new object[] {
            "09:00",
            "10:00"});
            this.combox_time.Location = new System.Drawing.Point(27, 143);
            this.combox_time.Name = "combox_time";
            this.combox_time.Size = new System.Drawing.Size(215, 36);
            this.combox_time.TabIndex = 3;
            // 
            // combox_name
            // 
            this.combox_name.FormattingEnabled = true;
            this.combox_name.Location = new System.Drawing.Point(27, 22);
            this.combox_name.Name = "combox_name";
            this.combox_name.Size = new System.Drawing.Size(215, 21);
            this.combox_name.TabIndex = 1;
            // 
            // combox_length
            // 
            this.combox_length.BackColor = System.Drawing.Color.Transparent;
            this.combox_length.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_length.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_length.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_length.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_length.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combox_length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combox_length.ItemHeight = 30;
            this.combox_length.Items.AddRange(new object[] {
            "30 minuten",
            "60 minuten"});
            this.combox_length.Location = new System.Drawing.Point(27, 210);
            this.combox_length.Name = "combox_length";
            this.combox_length.Size = new System.Drawing.Size(215, 36);
            this.combox_length.TabIndex = 4;
            // 
            // combox_type
            // 
            this.combox_type.BackColor = System.Drawing.Color.Transparent;
            this.combox_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combox_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combox_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combox_type.ItemHeight = 30;
            this.combox_type.Items.AddRange(new object[] {
            "normaal",
            "speciaal"});
            this.combox_type.Location = new System.Drawing.Point(27, 288);
            this.combox_type.Name = "combox_type";
            this.combox_type.Size = new System.Drawing.Size(215, 36);
            this.combox_type.TabIndex = 5;
            // 
            // txtbox_description
            // 
            this.txtbox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_description.DefaultText = "";
            this.txtbox_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_description.Location = new System.Drawing.Point(27, 356);
            this.txtbox_description.Multiline = true;
            this.txtbox_description.Name = "txtbox_description";
            this.txtbox_description.PasswordChar = '\0';
            this.txtbox_description.PlaceholderText = "";
            this.txtbox_description.SelectedText = "";
            this.txtbox_description.Size = new System.Drawing.Size(215, 136);
            this.txtbox_description.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Enabled = false;
            this.Datum.Location = new System.Drawing.Point(24, 57);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 0;
            this.Datum.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(24, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lengte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(24, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Behandeling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(24, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Beschrijving";
            // 
            // btn_makeAppointment
            // 
            this.btn_makeAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_makeAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_makeAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_makeAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_makeAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_makeAppointment.ForeColor = System.Drawing.Color.White;
            this.btn_makeAppointment.Location = new System.Drawing.Point(27, 516);
            this.btn_makeAppointment.Name = "btn_makeAppointment";
            this.btn_makeAppointment.Size = new System.Drawing.Size(215, 45);
            this.btn_makeAppointment.TabIndex = 7;
            this.btn_makeAppointment.Text = "Afspraak maken";
            this.btn_makeAppointment.Click += new System.EventHandler(this.Btn_makeAppointment_Click);
            // 
            // MakeAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 581);
            this.Controls.Add(this.btn_makeAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_description);
            this.Controls.Add(this.combox_type);
            this.Controls.Add(this.combox_length);
            this.Controls.Add(this.combox_name);
            this.Controls.Add(this.combox_time);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeAppointmentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Afspraak maken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox combox_time;
        private System.Windows.Forms.ComboBox combox_name;
        private Guna.UI2.WinForms.Guna2ComboBox combox_length;
        private Guna.UI2.WinForms.Guna2ComboBox combox_type;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_makeAppointment;
    }
}