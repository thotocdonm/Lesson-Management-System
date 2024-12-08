namespace QuanLyLichHoc.Controls.Student
{
    partial class SubjectEnrollmentControl
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lesson_Management_SystemDataSet = new QuanLyLichHoc.Lesson_Management_SystemDataSet();
            this.lessonManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonManagementSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lesson_Management_SystemDataSet
            // 
            this.lesson_Management_SystemDataSet.DataSetName = "Lesson_Management_SystemDataSet";
            this.lesson_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonManagementSystemDataSetBindingSource
            // 
            this.lessonManagementSystemDataSetBindingSource.DataSource = this.lesson_Management_SystemDataSet;
            this.lessonManagementSystemDataSetBindingSource.Position = 0;
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.Location = new System.Drawing.Point(545, 473);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(75, 23);
            this.EnrollBtn.TabIndex = 1;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = true;
            this.EnrollBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enroll Subjects";
            // 
            // SubjectEnrollmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnrollBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubjectEnrollmentControl";
            this.Size = new System.Drawing.Size(684, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonManagementSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lessonManagementSystemDataSetBindingSource;
        private Lesson_Management_SystemDataSet lesson_Management_SystemDataSet;
        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.Label label1;
    }
}
