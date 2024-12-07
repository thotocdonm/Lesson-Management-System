namespace QuanLyLichHoc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubjectsBtn = new System.Windows.Forms.Button();
            this.StudentsBtn = new System.Windows.Forms.Button();
            this.LecturerBtn = new System.Windows.Forms.Button();
            this.LessonBtn = new System.Windows.Forms.Button();
            this.MainContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 115);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(596, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lesson Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.SubjectsBtn);
            this.panel2.Controls.Add(this.StudentsBtn);
            this.panel2.Controls.Add(this.LecturerBtn);
            this.panel2.Controls.Add(this.LessonBtn);
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 673);
            this.panel2.TabIndex = 1;
            // 
            // SubjectsBtn
            // 
            this.SubjectsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectsBtn.FlatAppearance.BorderSize = 0;
            this.SubjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SubjectsBtn.Image")));
            this.SubjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsBtn.Location = new System.Drawing.Point(0, 399);
            this.SubjectsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.SubjectsBtn.Name = "SubjectsBtn";
            this.SubjectsBtn.Size = new System.Drawing.Size(266, 70);
            this.SubjectsBtn.TabIndex = 4;
            this.SubjectsBtn.Text = "Subjects";
            this.SubjectsBtn.UseVisualStyleBackColor = false;
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentsBtn.FlatAppearance.BorderSize = 0;
            this.StudentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("StudentsBtn.Image")));
            this.StudentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsBtn.Location = new System.Drawing.Point(0, 279);
            this.StudentsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(266, 70);
            this.StudentsBtn.TabIndex = 3;
            this.StudentsBtn.Text = "Students";
            this.StudentsBtn.UseVisualStyleBackColor = false;
            // 
            // LecturerBtn
            // 
            this.LecturerBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LecturerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LecturerBtn.FlatAppearance.BorderSize = 0;
            this.LecturerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecturerBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerBtn.Image = ((System.Drawing.Image)(resources.GetObject("LecturerBtn.Image")));
            this.LecturerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LecturerBtn.Location = new System.Drawing.Point(0, 159);
            this.LecturerBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.LecturerBtn.Name = "LecturerBtn";
            this.LecturerBtn.Size = new System.Drawing.Size(266, 70);
            this.LecturerBtn.TabIndex = 3;
            this.LecturerBtn.Text = "Lecturers";
            this.LecturerBtn.UseVisualStyleBackColor = false;
            this.LecturerBtn.Click += new System.EventHandler(this.LecturerBtn_Click);
            // 
            // LessonBtn
            // 
            this.LessonBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LessonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LessonBtn.FlatAppearance.BorderSize = 0;
            this.LessonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LessonBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonBtn.Image = ((System.Drawing.Image)(resources.GetObject("LessonBtn.Image")));
            this.LessonBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LessonBtn.Location = new System.Drawing.Point(0, 39);
            this.LessonBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.LessonBtn.Name = "LessonBtn";
            this.LessonBtn.Size = new System.Drawing.Size(266, 70);
            this.LessonBtn.TabIndex = 2;
            this.LessonBtn.Text = "Lesson";
            this.LessonBtn.UseVisualStyleBackColor = false;
            this.LessonBtn.Click += new System.EventHandler(this.LessonBtn_Click);
            // 
            // MainContent
            // 
            this.MainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContent.Location = new System.Drawing.Point(266, 115);
            this.MainContent.Margin = new System.Windows.Forms.Padding(0);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(1444, 673);
            this.MainContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.MainContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LessonBtn;
        private System.Windows.Forms.Button StudentsBtn;
        private System.Windows.Forms.Button LecturerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubjectsBtn;
        private System.Windows.Forms.Panel MainContent;
    }
}

