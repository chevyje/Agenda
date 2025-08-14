namespace Agenda
{
    partial class UC_Klanten
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
            this.lb_Maand = new System.Windows.Forms.Label();
            this.KlantenContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lb_Maand
            // 
            this.lb_Maand.Font = new System.Drawing.Font("Mongolian Baiti", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Maand.Location = new System.Drawing.Point(68, 38);
            this.lb_Maand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Maand.Name = "lb_Maand";
            this.lb_Maand.Size = new System.Drawing.Size(424, 98);
            this.lb_Maand.TabIndex = 2;
            this.lb_Maand.Text = "Klanten";
            this.lb_Maand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KlantenContainer
            // 
            this.KlantenContainer.AutoScroll = true;
            this.KlantenContainer.AutoScrollMinSize = new System.Drawing.Size(30, 1040);
            this.KlantenContainer.Location = new System.Drawing.Point(22, 215);
            this.KlantenContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KlantenContainer.Name = "KlantenContainer";
            this.KlantenContainer.Size = new System.Drawing.Size(2528, 1323);
            this.KlantenContainer.TabIndex = 3;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_addCustomer.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_addCustomer.Image = global::Agenda.Properties.Resources.add;
            this.btn_addCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_addCustomer.ImageRotate = 0F;
            this.btn_addCustomer.ImageSize = new System.Drawing.Size(56, 56);
            this.btn_addCustomer.Location = new System.Drawing.Point(2178, 38);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_addCustomer.Size = new System.Drawing.Size(96, 98);
            this.btn_addCustomer.TabIndex = 4;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_search
            // 
            this.btn_search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_search.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.btn_search.Image = global::Agenda.Properties.Resources.search;
            this.btn_search.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_search.ImageRotate = 0F;
            this.btn_search.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_search.Location = new System.Drawing.Point(2283, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedState.ImageSize = new System.Drawing.Size(58, 58);
            this.btn_search.Size = new System.Drawing.Size(96, 98);
            this.btn_search.TabIndex = 5;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_refresh.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.btn_refresh.Image = global::Agenda.Properties.Resources.refresh;
            this.btn_refresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_refresh.ImageRotate = 0F;
            this.btn_refresh.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_refresh.Location = new System.Drawing.Point(2388, 38);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedState.ImageSize = new System.Drawing.Size(58, 58);
            this.btn_refresh.Size = new System.Drawing.Size(96, 98);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // UC_Klanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.KlantenContainer);
            this.Controls.Add(this.lb_Maand);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Klanten";
            this.Size = new System.Drawing.Size(2550, 1538);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Maand;
        private System.Windows.Forms.FlowLayoutPanel KlantenContainer;
        private Guna.UI2.WinForms.Guna2ImageButton btn_addCustomer;
        private Guna.UI2.WinForms.Guna2ImageButton btn_search;
        private Guna.UI2.WinForms.Guna2ImageButton btn_refresh;
    }
}
