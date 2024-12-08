namespace QuanLyLichHoc.Views
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubjectsBtn = new System.Windows.Forms.Button();
            this.StudentsBtn = new System.Windows.Forms.Button();
            this.MainContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(496, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.SubjectsBtn);
            this.panel2.Controls.Add(this.StudentsBtn);
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 596);
            this.panel2.TabIndex = 2;
            // 
            // SubjectsBtn
            // 
            this.SubjectsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectsBtn.FlatAppearance.BorderSize = 0;
            this.SubjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SubjectsBtn.Image")));
            this.SubjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsBtn.Location = new System.Drawing.Point(0, 166);
            this.SubjectsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.SubjectsBtn.Name = "SubjectsBtn";
            this.SubjectsBtn.Size = new System.Drawing.Size(266, 70);
            this.SubjectsBtn.TabIndex = 4;
            this.SubjectsBtn.Text = "Subjects Enrollment";
            this.SubjectsBtn.UseVisualStyleBackColor = false;
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentsBtn.FlatAppearance.BorderSize = 0;
            this.StudentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("StudentsBtn.Image")));
            this.StudentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsBtn.Location = new System.Drawing.Point(0, 46);
            this.StudentsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(266, 70);
            this.StudentsBtn.TabIndex = 3;
            this.StudentsBtn.Text = "Students Information";
            this.StudentsBtn.UseVisualStyleBackColor = false;
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // MainContent
            // 
            this.MainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContent.Location = new System.Drawing.Point(269, 109);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(1069, 596);
            this.MainContent.TabIndex = 3;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 699);
            this.Controls.Add(this.MainContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SubjectsBtn;
        private System.Windows.Forms.Button StudentsBtn;
        private System.Windows.Forms.Panel MainContent;
    }
}