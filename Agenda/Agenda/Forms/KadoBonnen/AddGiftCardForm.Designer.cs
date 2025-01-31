namespace Agenda.Forms.KadoBonnen
{
    partial class AddGiftCardForm
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
            this.lbl_BonId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_waarde = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbl_BonId
            // 
            this.lbl_BonId.AutoSize = true;
            this.lbl_BonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BonId.Location = new System.Drawing.Point(29, 29);
            this.lbl_BonId.Name = "lbl_BonId";
            this.lbl_BonId.Size = new System.Drawing.Size(189, 20);
            this.lbl_BonId.TabIndex = 0;
            this.lbl_BonId.Text = "Bonnummer:  120052425";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "waarde";
            // 
            // txtbox_waarde
            // 
            this.txtbox_waarde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_waarde.DefaultText = "";
            this.txtbox_waarde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_waarde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_waarde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_waarde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_waarde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_waarde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_waarde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_waarde.Location = new System.Drawing.Point(33, 85);
            this.txtbox_waarde.Name = "txtbox_waarde";
            this.txtbox_waarde.PasswordChar = '\0';
            this.txtbox_waarde.PlaceholderText = "";
            this.txtbox_waarde.SelectedText = "";
            this.txtbox_waarde.Size = new System.Drawing.Size(185, 36);
            this.txtbox_waarde.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(33, 147);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(185, 45);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Opslaan";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // AddGiftCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 226);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtbox_waarde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_BonId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGiftCardForm";
            this.Text = "AddGiftCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BonId;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_waarde;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
    }
}