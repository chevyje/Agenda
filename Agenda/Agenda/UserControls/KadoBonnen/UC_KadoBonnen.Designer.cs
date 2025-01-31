namespace Agenda.UserControls
{
    partial class UC_KadoBonnen
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
            this.BonnenContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_KadoBon = new System.Windows.Forms.Label();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_AddGiftCard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // BonnenContainer
            // 
            this.BonnenContainer.AutoScroll = true;
            this.BonnenContainer.AutoScrollMinSize = new System.Drawing.Size(30, 1040);
            this.BonnenContainer.Location = new System.Drawing.Point(15, 140);
            this.BonnenContainer.Name = "BonnenContainer";
            this.BonnenContainer.Size = new System.Drawing.Size(1685, 860);
            this.BonnenContainer.TabIndex = 4;
            // 
            // lb_KadoBon
            // 
            this.lb_KadoBon.Font = new System.Drawing.Font("Mongolian Baiti", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KadoBon.Location = new System.Drawing.Point(45, 25);
            this.lb_KadoBon.Name = "lb_KadoBon";
            this.lb_KadoBon.Size = new System.Drawing.Size(438, 64);
            this.lb_KadoBon.TabIndex = 5;
            this.lb_KadoBon.Text = "Cadeau Bonnen";
            this.lb_KadoBon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Refresh.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_Refresh.Image = global::Agenda.Properties.Resources.refresh;
            this.btn_Refresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Refresh.ImageRotate = 0F;
            this.btn_Refresh.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Refresh.Location = new System.Drawing.Point(1592, 25);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PressedState.ImageSize = new System.Drawing.Size(54, 54);
            this.btn_Refresh.Size = new System.Drawing.Size(64, 64);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_AddGiftCard
            // 
            this.btn_AddGiftCard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_AddGiftCard.HoverState.ImageSize = new System.Drawing.Size(58, 58);
            this.btn_AddGiftCard.Image = global::Agenda.Properties.Resources.add;
            this.btn_AddGiftCard.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_AddGiftCard.ImageRotate = 0F;
            this.btn_AddGiftCard.ImageSize = new System.Drawing.Size(56, 56);
            this.btn_AddGiftCard.Location = new System.Drawing.Point(1522, 25);
            this.btn_AddGiftCard.Name = "btn_AddGiftCard";
            this.btn_AddGiftCard.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_AddGiftCard.Size = new System.Drawing.Size(64, 64);
            this.btn_AddGiftCard.TabIndex = 6;
            this.btn_AddGiftCard.Click += new System.EventHandler(this.btn_AddGiftCard_Click);
            // 
            // UC_KadoBonnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_AddGiftCard);
            this.Controls.Add(this.lb_KadoBon);
            this.Controls.Add(this.BonnenContainer);
            this.Name = "UC_KadoBonnen";
            this.Size = new System.Drawing.Size(1700, 1000);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BonnenContainer;
        private System.Windows.Forms.Label lb_KadoBon;
        private Guna.UI2.WinForms.Guna2ImageButton btn_AddGiftCard;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Refresh;
    }
}
