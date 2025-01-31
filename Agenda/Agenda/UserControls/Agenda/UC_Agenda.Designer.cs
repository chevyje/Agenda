namespace Agenda
{
    partial class UC_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Agenda));
            this.lb_Maand = new System.Windows.Forms.Label();
            this.lb_Jaar = new System.Windows.Forms.Label();
            this.DagenContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Maandag = new System.Windows.Forms.Label();
            this.lb_Dinsdag = new System.Windows.Forms.Label();
            this.lb_Woensdag = new System.Windows.Forms.Label();
            this.lb_Donderdag = new System.Windows.Forms.Label();
            this.lb_Vrijdag = new System.Windows.Forms.Label();
            this.PreviousMonth = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NextMonth = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_PlusAfspraak = new Guna.UI2.WinForms.Guna2ImageButton();
            this.afspraakDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_details_close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_details_wijzigen = new Guna.UI2.WinForms.Guna2Button();
            this.lb_details_tijd = new System.Windows.Forms.Label();
            this.lb_details2 = new System.Windows.Forms.Label();
            this.lb_details_beschrijving = new System.Windows.Forms.Label();
            this.lb_details5 = new System.Windows.Forms.Label();
            this.lb_details_behandeling = new System.Windows.Forms.Label();
            this.lb_details4 = new System.Windows.Forms.Label();
            this.lb_details_naam = new System.Windows.Forms.Label();
            this.lb_details3 = new System.Windows.Forms.Label();
            this.lb_details_datum = new System.Windows.Forms.Label();
            this.lb_details1 = new System.Windows.Forms.Label();
            this.btn_Search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.afspraakDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Maand
            // 
            this.lb_Maand.BackColor = System.Drawing.Color.Transparent;
            this.lb_Maand.Font = new System.Drawing.Font("Mongolian Baiti", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Maand.Location = new System.Drawing.Point(38, 25);
            this.lb_Maand.Name = "lb_Maand";
            this.lb_Maand.Size = new System.Drawing.Size(270, 64);
            this.lb_Maand.TabIndex = 1;
            this.lb_Maand.Text = "September";
            this.lb_Maand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Jaar
            // 
            this.lb_Jaar.BackColor = System.Drawing.Color.Transparent;
            this.lb_Jaar.Font = new System.Drawing.Font("MingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Jaar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Jaar.Location = new System.Drawing.Point(328, 25);
            this.lb_Jaar.Name = "lb_Jaar";
            this.lb_Jaar.Size = new System.Drawing.Size(125, 64);
            this.lb_Jaar.TabIndex = 2;
            this.lb_Jaar.Text = "2024";
            this.lb_Jaar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DagenContainer
            // 
            this.DagenContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.DagenContainer.Location = new System.Drawing.Point(18, 140);
            this.DagenContainer.Name = "DagenContainer";
            this.DagenContainer.Size = new System.Drawing.Size(1212, 860);
            this.DagenContainer.TabIndex = 5;
            // 
            // lb_Maandag
            // 
            this.lb_Maandag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Maandag.Location = new System.Drawing.Point(21, 108);
            this.lb_Maandag.Name = "lb_Maandag";
            this.lb_Maandag.Size = new System.Drawing.Size(233, 29);
            this.lb_Maandag.TabIndex = 7;
            this.lb_Maandag.Text = "Maandag";
            this.lb_Maandag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Dinsdag
            // 
            this.lb_Dinsdag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dinsdag.Location = new System.Drawing.Point(260, 108);
            this.lb_Dinsdag.Name = "lb_Dinsdag";
            this.lb_Dinsdag.Size = new System.Drawing.Size(233, 29);
            this.lb_Dinsdag.TabIndex = 8;
            this.lb_Dinsdag.Text = "Dinsdag";
            this.lb_Dinsdag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Woensdag
            // 
            this.lb_Woensdag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Woensdag.Location = new System.Drawing.Point(499, 108);
            this.lb_Woensdag.Name = "lb_Woensdag";
            this.lb_Woensdag.Size = new System.Drawing.Size(233, 29);
            this.lb_Woensdag.TabIndex = 9;
            this.lb_Woensdag.Text = "Woensdag";
            this.lb_Woensdag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Donderdag
            // 
            this.lb_Donderdag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Donderdag.Location = new System.Drawing.Point(738, 108);
            this.lb_Donderdag.Name = "lb_Donderdag";
            this.lb_Donderdag.Size = new System.Drawing.Size(233, 29);
            this.lb_Donderdag.TabIndex = 10;
            this.lb_Donderdag.Text = "Donderdag";
            this.lb_Donderdag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Vrijdag
            // 
            this.lb_Vrijdag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Vrijdag.Location = new System.Drawing.Point(977, 108);
            this.lb_Vrijdag.Name = "lb_Vrijdag";
            this.lb_Vrijdag.Size = new System.Drawing.Size(233, 29);
            this.lb_Vrijdag.TabIndex = 11;
            this.lb_Vrijdag.Text = "Vrijdag";
            this.lb_Vrijdag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousMonth
            // 
            this.PreviousMonth.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PreviousMonth.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.PreviousMonth.Image = global::Agenda.Properties.Resources.down;
            this.PreviousMonth.ImageOffset = new System.Drawing.Point(0, 0);
            this.PreviousMonth.ImageRotate = 0F;
            this.PreviousMonth.ImageSize = new System.Drawing.Size(56, 56);
            this.PreviousMonth.Location = new System.Drawing.Point(473, 25);
            this.PreviousMonth.Name = "PreviousMonth";
            this.PreviousMonth.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PreviousMonth.Size = new System.Drawing.Size(64, 64);
            this.PreviousMonth.TabIndex = 14;
            this.PreviousMonth.Click += new System.EventHandler(this.PreviousMonth_Click);
            // 
            // NextMonth
            // 
            this.NextMonth.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.NextMonth.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.NextMonth.Image = global::Agenda.Properties.Resources.up;
            this.NextMonth.ImageOffset = new System.Drawing.Point(0, 0);
            this.NextMonth.ImageRotate = 0F;
            this.NextMonth.ImageSize = new System.Drawing.Size(56, 56);
            this.NextMonth.Location = new System.Drawing.Point(543, 25);
            this.NextMonth.Name = "NextMonth";
            this.NextMonth.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.NextMonth.Size = new System.Drawing.Size(64, 64);
            this.NextMonth.TabIndex = 15;
            this.NextMonth.Click += new System.EventHandler(this.NextMonth_Click);
            // 
            // btn_PlusAfspraak
            // 
            this.btn_PlusAfspraak.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_PlusAfspraak.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_PlusAfspraak.Image = global::Agenda.Properties.Resources.add;
            this.btn_PlusAfspraak.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_PlusAfspraak.ImageRotate = 0F;
            this.btn_PlusAfspraak.ImageSize = new System.Drawing.Size(56, 56);
            this.btn_PlusAfspraak.Location = new System.Drawing.Point(1452, 25);
            this.btn_PlusAfspraak.Name = "btn_PlusAfspraak";
            this.btn_PlusAfspraak.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_PlusAfspraak.Size = new System.Drawing.Size(64, 64);
            this.btn_PlusAfspraak.TabIndex = 16;
            this.btn_PlusAfspraak.Click += new System.EventHandler(this.btn_PlusAfspraak_Click);
            // 
            // afspraakDetails
            // 
            this.afspraakDetails.BackColor = System.Drawing.Color.Transparent;
            this.afspraakDetails.BorderColor = System.Drawing.Color.Black;
            this.afspraakDetails.BorderThickness = 1;
            this.afspraakDetails.Controls.Add(this.lb_details_close);
            this.afspraakDetails.Controls.Add(this.btn_details_wijzigen);
            this.afspraakDetails.Controls.Add(this.lb_details_tijd);
            this.afspraakDetails.Controls.Add(this.lb_details2);
            this.afspraakDetails.Controls.Add(this.lb_details_beschrijving);
            this.afspraakDetails.Controls.Add(this.lb_details5);
            this.afspraakDetails.Controls.Add(this.lb_details_behandeling);
            this.afspraakDetails.Controls.Add(this.lb_details4);
            this.afspraakDetails.Controls.Add(this.lb_details_naam);
            this.afspraakDetails.Controls.Add(this.lb_details3);
            this.afspraakDetails.Controls.Add(this.lb_details_datum);
            this.afspraakDetails.Controls.Add(this.lb_details1);
            this.afspraakDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.afspraakDetails.Location = new System.Drawing.Point(420, 250);
            this.afspraakDetails.Name = "afspraakDetails";
            this.afspraakDetails.Size = new System.Drawing.Size(400, 600);
            this.afspraakDetails.TabIndex = 17;
            this.afspraakDetails.Visible = false;
            // 
            // lb_details_close
            // 
            this.lb_details_close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.lb_details_close.HoverState.ImageSize = new System.Drawing.Size(19, 19);
            this.lb_details_close.Image = ((System.Drawing.Image)(resources.GetObject("lb_details_close.Image")));
            this.lb_details_close.ImageOffset = new System.Drawing.Point(0, 0);
            this.lb_details_close.ImageRotate = 0F;
            this.lb_details_close.ImageSize = new System.Drawing.Size(17, 17);
            this.lb_details_close.Location = new System.Drawing.Point(374, 3);
            this.lb_details_close.Name = "lb_details_close";
            this.lb_details_close.PressedState.ImageSize = new System.Drawing.Size(19, 19);
            this.lb_details_close.Size = new System.Drawing.Size(25, 25);
            this.lb_details_close.TabIndex = 11;
            this.lb_details_close.Click += new System.EventHandler(this.lb_details_close_Click);
            // 
            // btn_details_wijzigen
            // 
            this.btn_details_wijzigen.BorderRadius = 30;
            this.btn_details_wijzigen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_details_wijzigen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_details_wijzigen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_details_wijzigen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_details_wijzigen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btn_details_wijzigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details_wijzigen.ForeColor = System.Drawing.Color.Black;
            this.btn_details_wijzigen.Location = new System.Drawing.Point(100, 494);
            this.btn_details_wijzigen.Name = "btn_details_wijzigen";
            this.btn_details_wijzigen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_details_wijzigen.Size = new System.Drawing.Size(200, 87);
            this.btn_details_wijzigen.TabIndex = 10;
            this.btn_details_wijzigen.Text = "Wijzigen";
            this.btn_details_wijzigen.Click += new System.EventHandler(this.btn_details_wijzigen_Click);
            // 
            // lb_details_tijd
            // 
            this.lb_details_tijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details_tijd.Location = new System.Drawing.Point(230, 71);
            this.lb_details_tijd.Name = "lb_details_tijd";
            this.lb_details_tijd.Size = new System.Drawing.Size(149, 29);
            this.lb_details_tijd.TabIndex = 9;
            this.lb_details_tijd.Text = "09:00 - 10:00";
            // 
            // lb_details2
            // 
            this.lb_details2.AutoSize = true;
            this.lb_details2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details2.Location = new System.Drawing.Point(220, 47);
            this.lb_details2.Name = "lb_details2";
            this.lb_details2.Size = new System.Drawing.Size(37, 20);
            this.lb_details2.TabIndex = 8;
            this.lb_details2.Text = "Tijd";
            // 
            // lb_details_beschrijving
            // 
            this.lb_details_beschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details_beschrijving.Location = new System.Drawing.Point(25, 302);
            this.lb_details_beschrijving.Name = "lb_details_beschrijving";
            this.lb_details_beschrijving.Size = new System.Drawing.Size(350, 177);
            this.lb_details_beschrijving.TabIndex = 7;
            this.lb_details_beschrijving.Text = "Factuur voor werk. Evt nog eruit halen als";
            // 
            // lb_details5
            // 
            this.lb_details5.AutoSize = true;
            this.lb_details5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details5.Location = new System.Drawing.Point(15, 278);
            this.lb_details5.Name = "lb_details5";
            this.lb_details5.Size = new System.Drawing.Size(105, 20);
            this.lb_details5.TabIndex = 6;
            this.lb_details5.Text = "Beschrijving";
            // 
            // lb_details_behandeling
            // 
            this.lb_details_behandeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details_behandeling.Location = new System.Drawing.Point(25, 225);
            this.lb_details_behandeling.Name = "lb_details_behandeling";
            this.lb_details_behandeling.Size = new System.Drawing.Size(350, 29);
            this.lb_details_behandeling.TabIndex = 5;
            this.lb_details_behandeling.Text = "Therapie Massage";
            // 
            // lb_details4
            // 
            this.lb_details4.AutoSize = true;
            this.lb_details4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details4.Location = new System.Drawing.Point(15, 201);
            this.lb_details4.Name = "lb_details4";
            this.lb_details4.Size = new System.Drawing.Size(109, 20);
            this.lb_details4.TabIndex = 4;
            this.lb_details4.Text = "Behandeling";
            // 
            // lb_details_naam
            // 
            this.lb_details_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details_naam.Location = new System.Drawing.Point(25, 148);
            this.lb_details_naam.Name = "lb_details_naam";
            this.lb_details_naam.Size = new System.Drawing.Size(350, 29);
            this.lb_details_naam.TabIndex = 3;
            this.lb_details_naam.Text = "Regina Langedijk";
            // 
            // lb_details3
            // 
            this.lb_details3.AutoSize = true;
            this.lb_details3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details3.Location = new System.Drawing.Point(15, 124);
            this.lb_details3.Name = "lb_details3";
            this.lb_details3.Size = new System.Drawing.Size(55, 20);
            this.lb_details3.TabIndex = 2;
            this.lb_details3.Text = "Naam";
            this.lb_details3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_details_datum
            // 
            this.lb_details_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details_datum.Location = new System.Drawing.Point(25, 71);
            this.lb_details_datum.Name = "lb_details_datum";
            this.lb_details_datum.Size = new System.Drawing.Size(133, 29);
            this.lb_details_datum.TabIndex = 1;
            this.lb_details_datum.Text = "08-05-2023";
            // 
            // lb_details1
            // 
            this.lb_details1.AutoSize = true;
            this.lb_details1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details1.Location = new System.Drawing.Point(15, 47);
            this.lb_details1.Name = "lb_details1";
            this.lb_details1.Size = new System.Drawing.Size(62, 20);
            this.lb_details1.TabIndex = 0;
            this.lb_details1.Text = "Datum";
            // 
            // btn_Search
            // 
            this.btn_Search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Search.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.btn_Search.Image = global::Agenda.Properties.Resources.search;
            this.btn_Search.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Search.ImageRotate = 0F;
            this.btn_Search.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Search.Location = new System.Drawing.Point(1522, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.PressedState.ImageSize = new System.Drawing.Size(58, 58);
            this.btn_Search.Size = new System.Drawing.Size(64, 64);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_refresh.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.btn_refresh.Image = global::Agenda.Properties.Resources.refresh;
            this.btn_refresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_refresh.ImageRotate = 0F;
            this.btn_refresh.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_refresh.Location = new System.Drawing.Point(1592, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedState.ImageSize = new System.Drawing.Size(58, 58);
            this.btn_refresh.Size = new System.Drawing.Size(64, 64);
            this.btn_refresh.TabIndex = 19;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1236, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 860);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1353, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Wachtlijst";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.afspraakDetails);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_PlusAfspraak);
            this.Controls.Add(this.NextMonth);
            this.Controls.Add(this.PreviousMonth);
            this.Controls.Add(this.lb_Vrijdag);
            this.Controls.Add(this.lb_Donderdag);
            this.Controls.Add(this.lb_Woensdag);
            this.Controls.Add(this.lb_Dinsdag);
            this.Controls.Add(this.lb_Maandag);
            this.Controls.Add(this.lb_Jaar);
            this.Controls.Add(this.lb_Maand);
            this.Controls.Add(this.DagenContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Agenda";
            this.Size = new System.Drawing.Size(1700, 1000);
            this.afspraakDetails.ResumeLayout(false);
            this.afspraakDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_Maand;
        private System.Windows.Forms.Label lb_Jaar;
        private System.Windows.Forms.FlowLayoutPanel DagenContainer;
        private System.Windows.Forms.Label lb_Maandag;
        private System.Windows.Forms.Label lb_Dinsdag;
        private System.Windows.Forms.Label lb_Woensdag;
        private System.Windows.Forms.Label lb_Donderdag;
        private System.Windows.Forms.Label lb_Vrijdag;
        private Guna.UI2.WinForms.Guna2ImageButton PreviousMonth;
        private Guna.UI2.WinForms.Guna2ImageButton NextMonth;
        private Guna.UI2.WinForms.Guna2ImageButton btn_PlusAfspraak;
        private Guna.UI2.WinForms.Guna2Panel afspraakDetails;
        private Guna.UI2.WinForms.Guna2ImageButton lb_details_close;
        private Guna.UI2.WinForms.Guna2Button btn_details_wijzigen;
        private System.Windows.Forms.Label lb_details_tijd;
        private System.Windows.Forms.Label lb_details2;
        private System.Windows.Forms.Label lb_details_beschrijving;
        private System.Windows.Forms.Label lb_details5;
        private System.Windows.Forms.Label lb_details_behandeling;
        private System.Windows.Forms.Label lb_details4;
        private System.Windows.Forms.Label lb_details_naam;
        private System.Windows.Forms.Label lb_details3;
        private System.Windows.Forms.Label lb_details_datum;
        private System.Windows.Forms.Label lb_details1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Search;
        private Guna.UI2.WinForms.Guna2ImageButton btn_refresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}
