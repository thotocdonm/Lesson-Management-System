namespace QuanLyLichHoc.Controls
{
    partial class LessonControl
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
            this.lessonDate = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.startTime = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.lecturerValue = new System.Windows.Forms.ComboBox();
            this.subjectValue = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateValue = new System.Windows.Forms.DateTimePicker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timeValue = new System.Windows.Forms.ComboBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.lecturerLabel = new System.Windows.Forms.Label();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 

            // lessonDate
            // 
            this.lessonDate.AutoSize = true;
            this.lessonDate.Location = new System.Drawing.Point(85, 406);
            this.lessonDate.Name = "lessonDate";
            this.lessonDate.Size = new System.Drawing.Size(32, 13);
            this.lessonDate.TabIndex = 0;
            this.lessonDate.Text = "Ngày";
            this.lessonDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 81);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(986, 261);
            this.dataGridView.TabIndex = 1;
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(85, 442);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(72, 13);
            this.startTime.TabIndex = 3;
            this.startTime.Text = "Thời gian học";
            this.startTime.Click += new System.EventHandler(this.startTime_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(553, 498);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(655, 498);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(754, 498);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(235, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(557, 23);
            this.title.TabIndex = 10;
            this.title.Text = "Lesson";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lecturerValue
            // 
            this.lecturerValue.FormattingEnabled = true;
            this.lecturerValue.Location = new System.Drawing.Point(509, 439);
            this.lecturerValue.Name = "lecturerValue";
            this.lecturerValue.Size = new System.Drawing.Size(206, 21);
            this.lecturerValue.TabIndex = 12;
            // 
            // subjectValue
            // 
            this.subjectValue.FormattingEnabled = true;
            this.subjectValue.Location = new System.Drawing.Point(509, 403);
            this.subjectValue.Name = "subjectValue";
            this.subjectValue.Size = new System.Drawing.Size(206, 21);
            this.subjectValue.TabIndex = 13;
            this.subjectValue.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dateValue
            // 
            this.dateValue.Location = new System.Drawing.Point(172, 405);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(200, 20);
            this.dateValue.TabIndex = 14;
            this.dateValue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timeValue
            // 
            this.timeValue.FormattingEnabled = true;
            this.timeValue.Items.AddRange(new object[] {
            "Ca 1 (Từ 6:45 đến 9:00)",
            "Ca 2 (Từ 9:25 đến 11:40)",
            "Ca 3 (Từ 12:15 đến 14:40)",
            "Ca 4 (Từ 14:55 đến 17:15)"});
            this.timeValue.Location = new System.Drawing.Point(172, 439);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(200, 21);
            this.timeValue.TabIndex = 15;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(442, 406);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(49, 13);
            this.subjectLabel.TabIndex = 16;
            this.subjectLabel.Text = "Môn học";
            // 
            // lecturerLabel
            // 
            this.lecturerLabel.AutoSize = true;
            this.lecturerLabel.Location = new System.Drawing.Point(442, 442);
            this.lecturerLabel.Name = "lecturerLabel";
            this.lecturerLabel.Size = new System.Drawing.Size(52, 13);
            this.lecturerLabel.TabIndex = 17;
            this.lecturerLabel.Text = "Giáo viên";
            this.lecturerLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(172, 367);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(200, 20);
            this.searchValue.TabIndex = 18;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(88, 365);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
     

            // 
            // LessonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.lecturerLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.subjectValue);
            this.Controls.Add(this.lecturerValue);
            this.Controls.Add(this.title);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lessonDate);
            this.Name = "LessonControl";
            this.Size = new System.Drawing.Size(1026, 556);

            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lessonDate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox lecturerValue;
        private System.Windows.Forms.ComboBox subjectValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateValue;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.ComboBox timeValue;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label lecturerLabel;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Button searchBtn;
    }
}
