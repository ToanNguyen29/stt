
namespace Day02
{
    partial class UpdataStudent
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
            this.BirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LNametextBox = new System.Windows.Forms.TextBox();
            this.FNametextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.BDate = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.Genderpanel = new System.Windows.Forms.Panel();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.PicturepictureBox = new System.Windows.Forms.PictureBox();
            this.AddressrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Canclebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.findbtn = new System.Windows.Forms.Button();
            this.MajortextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Genderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthdateTimePicker
            // 
            this.BirthdateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.BirthdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdateTimePicker.Location = new System.Drawing.Point(236, 185);
            this.BirthdateTimePicker.Name = "BirthdateTimePicker";
            this.BirthdateTimePicker.Size = new System.Drawing.Size(269, 22);
            this.BirthdateTimePicker.TabIndex = 21;
            // 
            // LNametextBox
            // 
            this.LNametextBox.Location = new System.Drawing.Point(236, 139);
            this.LNametextBox.Name = "LNametextBox";
            this.LNametextBox.Size = new System.Drawing.Size(269, 22);
            this.LNametextBox.TabIndex = 20;
            this.LNametextBox.TextChanged += new System.EventHandler(this.LNametextBox_TextChanged);
            // 
            // FNametextBox
            // 
            this.FNametextBox.Location = new System.Drawing.Point(236, 88);
            this.FNametextBox.Name = "FNametextBox";
            this.FNametextBox.Size = new System.Drawing.Size(269, 22);
            this.FNametextBox.TabIndex = 19;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(236, 44);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(146, 22);
            this.IDtextBox.TabIndex = 18;
            // 
            // BDate
            // 
            this.BDate.AutoSize = true;
            this.BDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BDate.Location = new System.Drawing.Point(120, 191);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(67, 17);
            this.BDate.TabIndex = 17;
            this.BDate.Text = "BirthDate";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LName.Location = new System.Drawing.Point(111, 144);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(76, 17);
            this.LName.TabIndex = 16;
            this.LName.Text = "Last Name";
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FName.Location = new System.Drawing.Point(111, 93);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(76, 17);
            this.FName.TabIndex = 15;
            this.FName.Text = "First Name";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentID.Location = new System.Drawing.Point(109, 49);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(78, 17);
            this.StudentID.TabIndex = 14;
            this.StudentID.Text = "Student ID ";
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(236, 286);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(269, 22);
            this.PhonetextBox.TabIndex = 25;
            // 
            // Genderpanel
            // 
            this.Genderpanel.Controls.Add(this.FemaleradioButton);
            this.Genderpanel.Controls.Add(this.MaleradioButton);
            this.Genderpanel.Location = new System.Drawing.Point(236, 227);
            this.Genderpanel.Name = "Genderpanel";
            this.Genderpanel.Size = new System.Drawing.Size(242, 42);
            this.Genderpanel.TabIndex = 24;
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FemaleradioButton.Location = new System.Drawing.Point(144, 18);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleradioButton.TabIndex = 1;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaleradioButton.Location = new System.Drawing.Point(13, 18);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleradioButton.TabIndex = 0;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(138, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(131, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gender";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(766, 269);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(273, 30);
            this.uploadBtn.TabIndex = 30;
            this.uploadBtn.Text = "upload image";
            this.uploadBtn.UseVisualStyleBackColor = true;
            // 
            // PicturepictureBox
            // 
            this.PicturepictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicturepictureBox.Location = new System.Drawing.Point(766, 162);
            this.PicturepictureBox.Name = "PicturepictureBox";
            this.PicturepictureBox.Size = new System.Drawing.Size(269, 114);
            this.PicturepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturepictureBox.TabIndex = 29;
            this.PicturepictureBox.TabStop = false;
            // 
            // AddressrichTextBox
            // 
            this.AddressrichTextBox.Location = new System.Drawing.Point(766, 44);
            this.AddressrichTextBox.Name = "AddressrichTextBox";
            this.AddressrichTextBox.Size = new System.Drawing.Size(269, 96);
            this.AddressrichTextBox.TabIndex = 28;
            this.AddressrichTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(671, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Picture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(663, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Address";
            // 
            // Canclebtn
            // 
            this.Canclebtn.BackColor = System.Drawing.Color.Red;
            this.Canclebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Canclebtn.Location = new System.Drawing.Point(380, 470);
            this.Canclebtn.Name = "Canclebtn";
            this.Canclebtn.Size = new System.Drawing.Size(170, 70);
            this.Canclebtn.TabIndex = 32;
            this.Canclebtn.Text = "Delete";
            this.Canclebtn.UseVisualStyleBackColor = false;
            this.Canclebtn.Click += new System.EventHandler(this.Canclebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Blue;
            this.editbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editbtn.Location = new System.Drawing.Point(605, 470);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(170, 70);
            this.editbtn.TabIndex = 31;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.Blue;
            this.findbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findbtn.Location = new System.Drawing.Point(401, 33);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(77, 49);
            this.findbtn.TabIndex = 33;
            this.findbtn.Text = "Find";
            this.findbtn.UseVisualStyleBackColor = false;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // MajortextBox
            // 
            this.MajortextBox.Location = new System.Drawing.Point(236, 389);
            this.MajortextBox.Name = "MajortextBox";
            this.MajortextBox.Size = new System.Drawing.Size(269, 22);
            this.MajortextBox.TabIndex = 37;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(236, 342);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(269, 22);
            this.EmailtextBox.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(144, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Major";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(145, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Email";
            // 
            // UpdataStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1106, 662);
            this.Controls.Add(this.MajortextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.Canclebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.PicturepictureBox);
            this.Controls.Add(this.AddressrichTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.Genderpanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthdateTimePicker);
            this.Controls.Add(this.LNametextBox);
            this.Controls.Add(this.FNametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.BDate);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.StudentID);
            this.Name = "UpdataStudent";
            this.Text = "UpdataStudent";
            this.Load += new System.EventHandler(this.UpdataStudent_Load);
            this.Genderpanel.ResumeLayout(false);
            this.Genderpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdateTimePicker;
        private System.Windows.Forms.TextBox LNametextBox;
        private System.Windows.Forms.Label BDate;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.Panel Genderpanel;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox PicturepictureBox;
        private System.Windows.Forms.RichTextBox AddressrichTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Canclebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button findbtn;
        public System.Windows.Forms.TextBox IDtextBox;
        public System.Windows.Forms.TextBox FNametextBox;
        private System.Windows.Forms.TextBox MajortextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}