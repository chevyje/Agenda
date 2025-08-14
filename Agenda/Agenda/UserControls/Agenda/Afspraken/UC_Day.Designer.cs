namespace Agenda
{
    partial class UC_Day
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
            this.lb_dag = new System.Windows.Forms.Label();
            this.afspraakContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_index = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_dag
            // 
            this.lb_dag.AutoSize = true;
            this.lb_dag.Location = new System.Drawing.Point(12, 14);
            this.lb_dag.Name = "lb_dag";
            this.lb_dag.Size = new System.Drawing.Size(35, 13);
            this.lb_dag.TabIndex = 0;
            this.lb_dag.Text = "label1";
            // 
            // afspraakContainer
            // 
            this.afspraakContainer.Location = new System.Drawing.Point(10, 34);
            this.afspraakContainer.Margin = new System.Windows.Forms.Padding(0);
            this.afspraakContainer.Name = "afspraakContainer";
            this.afspraakContainer.Size = new System.Drawing.Size(233, 100);
            this.afspraakContainer.TabIndex = 1;
            // 
            // lb_index
            // 
            this.lb_index.AutoSize = true;
            this.lb_index.Location = new System.Drawing.Point(208, 14);
            this.lb_index.Name = "lb_index";
            this.lb_index.Size = new System.Drawing.Size(0, 13);
            this.lb_index.TabIndex = 2;
            // 
            // UC_Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.lb_index);
            this.Controls.Add(this.afspraakContainer);
            this.Controls.Add(this.lb_dag);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.Name = "UC_Day";
            this.Size = new System.Drawing.Size(233, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dag;
        private System.Windows.Forms.FlowLayoutPanel afspraakContainer;
        private System.Windows.Forms.Label lb_index;
    }
}
