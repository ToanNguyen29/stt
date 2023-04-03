namespace Day02
{
    partial class StaticsForm
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.LabelFemale = new System.Windows.Forms.Label();
            this.LabelMale = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelMale = new System.Windows.Forms.Panel();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(135, 46);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 16);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // LabelFemale
            // 
            this.LabelFemale.AutoSize = true;
            this.LabelFemale.Location = new System.Drawing.Point(71, 31);
            this.LabelFemale.Name = "LabelFemale";
            this.LabelFemale.Size = new System.Drawing.Size(0, 16);
            this.LabelFemale.TabIndex = 1;
            this.LabelFemale.MouseLeave += new System.EventHandler(this.LabelFemale_MouseLeave);
            // 
            // LabelMale
            // 
            this.LabelMale.AutoSize = true;
            this.LabelMale.Location = new System.Drawing.Point(53, 31);
            this.LabelMale.Name = "LabelMale";
            this.LabelMale.Size = new System.Drawing.Size(0, 16);
            this.LabelMale.TabIndex = 2;
            this.LabelMale.MouseLeave += new System.EventHandler(this.LabelMale_MouseLeave);
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Red;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(-1, 1);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(455, 131);
            this.panelTotal.TabIndex = 3;
            this.panelTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTotal.Move += new System.EventHandler(this.panelTotal_Move);
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.Yellow;
            this.panelMale.Controls.Add(this.LabelMale);
            this.panelMale.Location = new System.Drawing.Point(-1, 138);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(220, 131);
            this.panelMale.TabIndex = 4;
            this.panelMale.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMale_Paint);
            // 
            // PanelFemale
            // 
            this.PanelFemale.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelFemale.Controls.Add(this.LabelFemale);
            this.PanelFemale.Location = new System.Drawing.Point(225, 138);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(229, 131);
            this.PanelFemale.TabIndex = 5;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 380);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.PanelFemale.ResumeLayout(false);
            this.PanelFemale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label LabelFemale;
        private System.Windows.Forms.Label LabelMale;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Panel PanelFemale;
    }
}