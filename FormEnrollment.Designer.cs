namespace Day02
{
    partial class FormEnrollment
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
            this.dataGridViewEnroll = new System.Windows.Forms.DataGridView();
            this.buttonResultEnroll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEnroll
            // 
            this.dataGridViewEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnroll.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewEnroll.Name = "dataGridViewEnroll";
            this.dataGridViewEnroll.RowHeadersWidth = 51;
            this.dataGridViewEnroll.RowTemplate.Height = 24;
            this.dataGridViewEnroll.Size = new System.Drawing.Size(1148, 201);
            this.dataGridViewEnroll.TabIndex = 0;
            this.dataGridViewEnroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnroll_CellContentClick);
            this.dataGridViewEnroll.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEnroll_RowHeaderMouseClick);
            this.dataGridViewEnroll.MouseHover += new System.EventHandler(this.dataGridViewEnroll_MouseHover);
            // 
            // buttonResultEnroll
            // 
            this.buttonResultEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonResultEnroll.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultEnroll.Location = new System.Drawing.Point(835, 451);
            this.buttonResultEnroll.Name = "buttonResultEnroll";
            this.buttonResultEnroll.Size = new System.Drawing.Size(253, 69);
            this.buttonResultEnroll.TabIndex = 1;
            this.buttonResultEnroll.Text = "Result";
            this.buttonResultEnroll.UseVisualStyleBackColor = false;
            this.buttonResultEnroll.Click += new System.EventHandler(this.buttonResultEnroll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 117);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course enroll list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(79, 451);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(214, 69);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 545);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonResultEnroll);
            this.Controls.Add(this.dataGridViewEnroll);
            this.Name = "FormEnrollment";
            this.Text = "FormEnrollment";
            this.Load += new System.EventHandler(this.FormEnrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnroll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnroll;
        private System.Windows.Forms.Button buttonResultEnroll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}