namespace Day02
{
    partial class FormResultEnroll
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
            this.dataGridViewResultEnroll = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonResultEnroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultEnroll)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultEnroll
            // 
            this.dataGridViewResultEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultEnroll.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewResultEnroll.Name = "dataGridViewResultEnroll";
            this.dataGridViewResultEnroll.RowHeadersWidth = 51;
            this.dataGridViewResultEnroll.RowTemplate.Height = 24;
            this.dataGridViewResultEnroll.Size = new System.Drawing.Size(853, 150);
            this.dataGridViewResultEnroll.TabIndex = 0;
            this.dataGridViewResultEnroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultEnroll_CellContentClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(75, 352);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(214, 69);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonResultEnroll
            // 
            this.buttonResultEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonResultEnroll.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultEnroll.Location = new System.Drawing.Point(588, 352);
            this.buttonResultEnroll.Name = "buttonResultEnroll";
            this.buttonResultEnroll.Size = new System.Drawing.Size(229, 69);
            this.buttonResultEnroll.TabIndex = 5;
            this.buttonResultEnroll.Text = "Print";
            this.buttonResultEnroll.UseVisualStyleBackColor = false;
            // 
            // FormResultEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.buttonResultEnroll);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewResultEnroll);
            this.Name = "FormResultEnroll";
            this.Text = "FormResultEnroll";
            this.Load += new System.EventHandler(this.FormResultEnroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultEnroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultEnroll;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonResultEnroll;
    }
}