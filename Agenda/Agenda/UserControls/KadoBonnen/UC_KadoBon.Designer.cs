namespace Agenda.UserControls
{
    partial class UC_KadoBon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KadoBon));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_Waarde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_BonNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_check = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lb_Waarde);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.lb_BonNum);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btn_check);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(230, 120);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lb_Waarde
            // 
            this.lb_Waarde.AutoSize = true;
            this.lb_Waarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Waarde.Location = new System.Drawing.Point(25, 79);
            this.lb_Waarde.Name = "lb_Waarde";
            this.lb_Waarde.Size = new System.Drawing.Size(78, 25);
            this.lb_Waarde.TabIndex = 4;
            this.lb_Waarde.Text = "$45,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waarde";
            // 
            // lb_BonNum
            // 
            this.lb_BonNum.AutoSize = true;
            this.lb_BonNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BonNum.Location = new System.Drawing.Point(25, 25);
            this.lb_BonNum.Name = "lb_BonNum";
            this.lb_BonNum.Size = new System.Drawing.Size(96, 25);
            this.lb_BonNum.TabIndex = 2;
            this.lb_BonNum.Text = "2409001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bon nummer";
            // 
            // btn_check
            // 
            this.btn_check.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_check.HoverState.ImageSize = new System.Drawing.Size(17, 17);
            this.btn_check.Image = ((System.Drawing.Image)(resources.GetObject("btn_check.Image")));
            this.btn_check.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_check.ImageRotate = 0F;
            this.btn_check.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_check.Location = new System.Drawing.Point(207, 3);
            this.btn_check.Name = "btn_check";
            this.btn_check.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_check.Size = new System.Drawing.Size(20, 20);
            this.btn_check.TabIndex = 0;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // UC_KadoBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_KadoBon";
            this.Size = new System.Drawing.Size(230, 120);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Waarde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_BonNum;
    }
}
