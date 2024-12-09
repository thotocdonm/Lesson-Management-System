namespace QuanLyLichHoc.Forms.UpdateLecturer
{
    partial class UpdateLecturer
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
            this.update_lecture_button = new System.Windows.Forms.Button();
            this.dateTimeOBLecture = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.text_lecture_email = new System.Windows.Forms.TextBox();
            this.text_lecture_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_lecture_gender = new System.Windows.Forms.ComboBox();
            this.text_lecture_name = new System.Windows.Forms.TextBox();
            this.text_lecture_id = new System.Windows.Forms.TextBox();
            this.label_lecturestatus = new System.Windows.Forms.Label();
            this.label_lecturegender = new System.Windows.Forms.Label();
            this.label_lecturename = new System.Windows.Forms.Label();
            this.label_lectureid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_lecture_button
            // 
            this.update_lecture_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update_lecture_button.Location = new System.Drawing.Point(748, 348);
            this.update_lecture_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_lecture_button.Name = "update_lecture_button";
            this.update_lecture_button.Size = new System.Drawing.Size(157, 38);
            this.update_lecture_button.TabIndex = 22;
            this.update_lecture_button.Text = "Update";
            this.update_lecture_button.UseVisualStyleBackColor = true;
            this.update_lecture_button.Click += new System.EventHandler(this.update_lecture_button_Click);
            // 
            // dateTimeOBLecture
            // 
            this.dateTimeOBLecture.Location = new System.Drawing.Point(180, 279);
            this.dateTimeOBLecture.Name = "dateTimeOBLecture";
            this.dateTimeOBLecture.Size = new System.Drawing.Size(200, 22);
            this.dateTimeOBLecture.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date of birth";
            // 
            // text_lecture_email
            // 
            this.text_lecture_email.Location = new System.Drawing.Point(706, 153);
            this.text_lecture_email.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_email.Name = "text_lecture_email";
            this.text_lecture_email.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_email.TabIndex = 34;
            // 
            // text_lecture_phone
            // 
            this.text_lecture_phone.Location = new System.Drawing.Point(706, 209);
            this.text_lecture_phone.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_phone.Name = "text_lecture_phone";
            this.text_lecture_phone.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_phone.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Phone";
            // 
            // comboBox_lecture_gender
            // 
            this.comboBox_lecture_gender.FormattingEnabled = true;
            this.comboBox_lecture_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_lecture_gender.Location = new System.Drawing.Point(221, 210);
            this.comboBox_lecture_gender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_lecture_gender.Name = "comboBox_lecture_gender";
            this.comboBox_lecture_gender.Size = new System.Drawing.Size(160, 24);
            this.comboBox_lecture_gender.TabIndex = 29;
            // 
            // text_lecture_name
            // 
            this.text_lecture_name.Location = new System.Drawing.Point(221, 150);
            this.text_lecture_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_name.Name = "text_lecture_name";
            this.text_lecture_name.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_name.TabIndex = 28;
            // 
            // text_lecture_id
            // 
            this.text_lecture_id.Location = new System.Drawing.Point(221, 87);
            this.text_lecture_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_id.Name = "text_lecture_id";
            this.text_lecture_id.ReadOnly = true;
            this.text_lecture_id.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_id.TabIndex = 27;
            // 
            // label_lecturestatus
            // 
            this.label_lecturestatus.AutoSize = true;
            this.label_lecturestatus.Location = new System.Drawing.Point(630, 156);
            this.label_lecturestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturestatus.Name = "label_lecturestatus";
            this.label_lecturestatus.Size = new System.Drawing.Size(41, 16);
            this.label_lecturestatus.TabIndex = 26;
            this.label_lecturestatus.Text = "Email";
            // 
            // label_lecturegender
            // 
            this.label_lecturegender.AutoSize = true;
            this.label_lecturegender.Location = new System.Drawing.Point(81, 214);
            this.label_lecturegender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturegender.Name = "label_lecturegender";
            this.label_lecturegender.Size = new System.Drawing.Size(52, 16);
            this.label_lecturegender.TabIndex = 25;
            this.label_lecturegender.Text = "Gender";
            // 
            // label_lecturename
            // 
            this.label_lecturename.AutoSize = true;
            this.label_lecturename.Location = new System.Drawing.Point(81, 150);
            this.label_lecturename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturename.Name = "label_lecturename";
            this.label_lecturename.Size = new System.Drawing.Size(92, 16);
            this.label_lecturename.TabIndex = 24;
            this.label_lecturename.Text = "LenturerName";
            // 
            // label_lectureid
            // 
            this.label_lectureid.AutoSize = true;
            this.label_lectureid.Location = new System.Drawing.Point(81, 87);
            this.label_lectureid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lectureid.Name = "label_lectureid";
            this.label_lectureid.Size = new System.Drawing.Size(68, 16);
            this.label_lectureid.TabIndex = 23;
            this.label_lectureid.Text = "LecturerID";
            // 
            // UpdateLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 445);
            this.Controls.Add(this.dateTimeOBLecture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_lecture_email);
            this.Controls.Add(this.text_lecture_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_lecture_gender);
            this.Controls.Add(this.text_lecture_name);
            this.Controls.Add(this.text_lecture_id);
            this.Controls.Add(this.label_lecturestatus);
            this.Controls.Add(this.label_lecturegender);
            this.Controls.Add(this.label_lecturename);
            this.Controls.Add(this.label_lectureid);
            this.Controls.Add(this.update_lecture_button);
            this.Name = "UpdateLecturer";
            this.Text = "Update Lecturer";
            this.Load += new System.EventHandler(this.UpdateLecturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update_lecture_button;
        private System.Windows.Forms.DateTimePicker dateTimeOBLecture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_lecture_email;
        private System.Windows.Forms.TextBox text_lecture_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_lecture_gender;
        private System.Windows.Forms.TextBox text_lecture_name;
        private System.Windows.Forms.TextBox text_lecture_id;
        private System.Windows.Forms.Label label_lecturestatus;
        private System.Windows.Forms.Label label_lecturegender;
        private System.Windows.Forms.Label label_lecturename;
        private System.Windows.Forms.Label label_lectureid;
    }
}