
namespace Day02
{
    partial class SendCode
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
            this.SendCodeLable = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.VerifyCodeTextBox = new System.Windows.Forms.TextBox();
            this.VerifyCodeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendCodeLable
            // 
            this.SendCodeLable.AutoSize = true;
            this.SendCodeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendCodeLable.Location = new System.Drawing.Point(192, 189);
            this.SendCodeLable.Name = "SendCodeLable";
            this.SendCodeLable.Size = new System.Drawing.Size(60, 25);
            this.SendCodeLable.TabIndex = 0;
            this.SendCodeLable.Text = "Email";
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(455, 240);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(122, 44);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // VerifyCodeTextBox
            // 
            this.VerifyCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyCodeTextBox.Location = new System.Drawing.Point(197, 347);
            this.VerifyCodeTextBox.Name = "VerifyCodeTextBox";
            this.VerifyCodeTextBox.Size = new System.Drawing.Size(222, 36);
            this.VerifyCodeTextBox.TabIndex = 2;
            // 
            // VerifyCodeBtn
            // 
            this.VerifyCodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyCodeBtn.Location = new System.Drawing.Point(455, 344);
            this.VerifyCodeBtn.Name = "VerifyCodeBtn";
            this.VerifyCodeBtn.Size = new System.Drawing.Size(122, 44);
            this.VerifyCodeBtn.TabIndex = 3;
            this.VerifyCodeBtn.Text = "Verify code";
            this.VerifyCodeBtn.UseVisualStyleBackColor = true;
            this.VerifyCodeBtn.Click += new System.EventHandler(this.VerifyCodeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reset your password";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Red;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 25);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 38);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerifyCodeBtn);
            this.Controls.Add(this.VerifyCodeTextBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.SendCodeLable);
            this.Name = "SendCode";
            this.Text = "SendCode";
            this.Load += new System.EventHandler(this.SendCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SendCodeLable;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox VerifyCodeTextBox;
        private System.Windows.Forms.Button VerifyCodeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
    }
}