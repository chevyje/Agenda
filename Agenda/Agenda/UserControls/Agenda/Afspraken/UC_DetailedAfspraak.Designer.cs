namespace Agenda.UserControls
{
    partial class UC_DetailedAfspraak
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
            this.components = new System.ComponentModel.Container();
            this.Datum = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tijd = new System.Windows.Forms.Label();
            this.lbl_behandeling = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(10, 18);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 0;
            this.Datum.Text = "Datum";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(54, 18);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(61, 13);
            this.lbl_datum.TabIndex = 1;
            this.lbl_datum.Text = "11-25-2024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tijd";
            // 
            // lbl_tijd
            // 
            this.lbl_tijd.AutoSize = true;
            this.lbl_tijd.Location = new System.Drawing.Point(162, 18);
            this.lbl_tijd.Name = "lbl_tijd";
            this.lbl_tijd.Size = new System.Drawing.Size(64, 13);
            this.lbl_tijd.TabIndex = 3;
            this.lbl_tijd.Text = "09:00-10:00";
            // 
            // lbl_behandeling
            // 
            this.lbl_behandeling.AutoSize = true;
            this.lbl_behandeling.Location = new System.Drawing.Point(126, 45);
            this.lbl_behandeling.Name = "lbl_behandeling";
            this.lbl_behandeling.Size = new System.Drawing.Size(100, 13);
            this.lbl_behandeling.TabIndex = 4;
            this.lbl_behandeling.Text = "Voetreflex Massage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soort behandeling";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // UC_DetailedAfspraak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_behandeling);
            this.Controls.Add(this.lbl_tijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.Datum);
            this.Name = "UC_DetailedAfspraak";
            this.Size = new System.Drawing.Size(238, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tijd;
        private System.Windows.Forms.Label lbl_behandeling;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
