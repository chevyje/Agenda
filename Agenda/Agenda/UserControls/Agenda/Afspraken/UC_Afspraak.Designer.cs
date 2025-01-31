namespace Agenda.UserControls
{
    partial class UC_Afspraak
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
            this.lb_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Time
            // 
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(0, 0);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(67, 45);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "09:00 - 10:00";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Time.Click += new System.EventHandler(this.OnClick);
            // 
            // UC_Afspraak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(164)))), ((int)(((byte)(173)))));
            this.Controls.Add(this.lb_Time);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name = "UC_Afspraak";
            this.Size = new System.Drawing.Size(67, 45);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Time;
    }
}
