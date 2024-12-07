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
            this.text_lecture_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update_lecture_button = new System.Windows.Forms.Button();
            this.comboBox_lecture_status = new System.Windows.Forms.ComboBox();
            this.comboBox_lecture_gender = new System.Windows.Forms.ComboBox();
            this.text_lecture_name = new System.Windows.Forms.TextBox();
            this.text_lecture_id = new System.Windows.Forms.TextBox();
            this.label_lecturestatus = new System.Windows.Forms.Label();
            this.label_lecturegender = new System.Windows.Forms.Label();
            this.label_lecturename = new System.Windows.Forms.Label();
            this.label_lectureid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_lecture_address
            // 
            this.text_lecture_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_lecture_address.Location = new System.Drawing.Point(577, 128);
            this.text_lecture_address.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_address.Name = "text_lecture_address";
            this.text_lecture_address.Size = new System.Drawing.Size(189, 22);
            this.text_lecture_address.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Address";
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
            // comboBox_lecture_status
            // 
            this.comboBox_lecture_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_lecture_status.FormattingEnabled = true;
            this.comboBox_lecture_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox_lecture_status.Location = new System.Drawing.Point(577, 72);
            this.comboBox_lecture_status.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_lecture_status.Name = "comboBox_lecture_status";
            this.comboBox_lecture_status.Size = new System.Drawing.Size(217, 24);
            this.comboBox_lecture_status.TabIndex = 21;
            // 
            // comboBox_lecture_gender
            // 
            this.comboBox_lecture_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_lecture_gender.FormattingEnabled = true;
            this.comboBox_lecture_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_lecture_gender.Location = new System.Drawing.Point(271, 198);
            this.comboBox_lecture_gender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_lecture_gender.Name = "comboBox_lecture_gender";
            this.comboBox_lecture_gender.Size = new System.Drawing.Size(217, 24);
            this.comboBox_lecture_gender.TabIndex = 20;
            // 
            // text_lecture_name
            // 
            this.text_lecture_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_lecture_name.Location = new System.Drawing.Point(271, 138);
            this.text_lecture_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_name.Name = "text_lecture_name";
            this.text_lecture_name.Size = new System.Drawing.Size(189, 22);
            this.text_lecture_name.TabIndex = 19;
            // 
            // text_lecture_id
            // 
            this.text_lecture_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_lecture_id.Location = new System.Drawing.Point(271, 75);
            this.text_lecture_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_id.Name = "text_lecture_id";
            this.text_lecture_id.Size = new System.Drawing.Size(189, 22);
            this.text_lecture_id.TabIndex = 18;
            // 
            // label_lecturestatus
            // 
            this.label_lecturestatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_lecturestatus.AutoSize = true;
            this.label_lecturestatus.Location = new System.Drawing.Point(501, 75);
            this.label_lecturestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturestatus.Name = "label_lecturestatus";
            this.label_lecturestatus.Size = new System.Drawing.Size(44, 16);
            this.label_lecturestatus.TabIndex = 17;
            this.label_lecturestatus.Text = "Status";
            // 
            // label_lecturegender
            // 
            this.label_lecturegender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_lecturegender.AutoSize = true;
            this.label_lecturegender.Location = new System.Drawing.Point(131, 202);
            this.label_lecturegender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturegender.Name = "label_lecturegender";
            this.label_lecturegender.Size = new System.Drawing.Size(52, 16);
            this.label_lecturegender.TabIndex = 16;
            this.label_lecturegender.Text = "Gender";
            // 
            // label_lecturename
            // 
            this.label_lecturename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_lecturename.AutoSize = true;
            this.label_lecturename.Location = new System.Drawing.Point(131, 138);
            this.label_lecturename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturename.Name = "label_lecturename";
            this.label_lecturename.Size = new System.Drawing.Size(92, 16);
            this.label_lecturename.TabIndex = 15;
            this.label_lecturename.Text = "LenturerName";
            // 
            // label_lectureid
            // 
            this.label_lectureid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_lectureid.AutoSize = true;
            this.label_lectureid.Location = new System.Drawing.Point(131, 75);
            this.label_lectureid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lectureid.Name = "label_lectureid";
            this.label_lectureid.Size = new System.Drawing.Size(68, 16);
            this.label_lectureid.TabIndex = 14;
            this.label_lectureid.Text = "LecturerID";
            // 
            // UpdateLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 445);
            this.Controls.Add(this.text_lecture_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_lecture_button);
            this.Controls.Add(this.comboBox_lecture_status);
            this.Controls.Add(this.comboBox_lecture_gender);
            this.Controls.Add(this.text_lecture_name);
            this.Controls.Add(this.text_lecture_id);
            this.Controls.Add(this.label_lecturestatus);
            this.Controls.Add(this.label_lecturegender);
            this.Controls.Add(this.label_lecturename);
            this.Controls.Add(this.label_lectureid);
            this.Name = "UpdateLecturer";
            this.Text = "Update Lecturer";
            this.Load += new System.EventHandler(this.UpdateLecturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_lecture_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_lecture_button;
        private System.Windows.Forms.ComboBox comboBox_lecture_status;
        private System.Windows.Forms.ComboBox comboBox_lecture_gender;
        private System.Windows.Forms.TextBox text_lecture_name;
        private System.Windows.Forms.TextBox text_lecture_id;
        private System.Windows.Forms.Label label_lecturestatus;
        private System.Windows.Forms.Label label_lecturegender;
        private System.Windows.Forms.Label label_lecturename;
        private System.Windows.Forms.Label label_lectureid;
    }
}