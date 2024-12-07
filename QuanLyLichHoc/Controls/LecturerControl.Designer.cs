namespace QuanLyLichHoc.Controls
{
    partial class LecturerControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delete_lecture_button = new System.Windows.Forms.Button();
            this.clear_lecture_button = new System.Windows.Forms.Button();
            this.update_lecture_button = new System.Windows.Forms.Button();
            this.add_lecture_button = new System.Windows.Forms.Button();
            this.comboBox_lecture_status = new System.Windows.Forms.ComboBox();
            this.comboBox_lecture_gender = new System.Windows.Forms.ComboBox();
            this.text_lecture_name = new System.Windows.Forms.TextBox();
            this.text_lecture_id = new System.Windows.Forms.TextBox();
            this.label_lecturestatus = new System.Windows.Forms.Label();
            this.label_lecturename = new System.Windows.Forms.Label();
            this.label_lectureid = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.text_lecture_search = new System.Windows.Forms.TextBox();
            this.label_lecturesearch = new System.Windows.Forms.Label();
            this.text_lecture_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_lecturegender = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 123);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyLichHoc.Properties.Resources.icons8_teacher_48;
            this.pictureBox1.Location = new System.Drawing.Point(528, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(599, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 56);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Lecturer";
            // 
            // delete_lecture_button
            // 
            this.delete_lecture_button.Location = new System.Drawing.Point(987, 209);
            this.delete_lecture_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_lecture_button.Name = "delete_lecture_button";
            this.delete_lecture_button.Size = new System.Drawing.Size(100, 28);
            this.delete_lecture_button.TabIndex = 11;
            this.delete_lecture_button.Text = "Delete";
            this.delete_lecture_button.UseVisualStyleBackColor = true;
            this.delete_lecture_button.Click += new System.EventHandler(this.delete_lecture_button_Click);
            // 
            // clear_lecture_button
            // 
            this.clear_lecture_button.Location = new System.Drawing.Point(830, 209);
            this.clear_lecture_button.Margin = new System.Windows.Forms.Padding(4);
            this.clear_lecture_button.Name = "clear_lecture_button";
            this.clear_lecture_button.Size = new System.Drawing.Size(100, 28);
            this.clear_lecture_button.TabIndex = 10;
            this.clear_lecture_button.Text = "Clear";
            this.clear_lecture_button.UseVisualStyleBackColor = true;
            // 
            // update_lecture_button
            // 
            this.update_lecture_button.Location = new System.Drawing.Point(666, 210);
            this.update_lecture_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_lecture_button.Name = "update_lecture_button";
            this.update_lecture_button.Size = new System.Drawing.Size(100, 28);
            this.update_lecture_button.TabIndex = 9;
            this.update_lecture_button.Text = "Update";
            this.update_lecture_button.UseVisualStyleBackColor = true;
            this.update_lecture_button.Click += new System.EventHandler(this.update_lecture_button_Click);
            // 
            // add_lecture_button
            // 
            this.add_lecture_button.Location = new System.Drawing.Point(519, 210);
            this.add_lecture_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_lecture_button.Name = "add_lecture_button";
            this.add_lecture_button.Size = new System.Drawing.Size(100, 28);
            this.add_lecture_button.TabIndex = 8;
            this.add_lecture_button.Text = "Add";
            this.add_lecture_button.UseVisualStyleBackColor = true;
            this.add_lecture_button.Click += new System.EventHandler(this.add_lecture_button_Click);
            // 
            // comboBox_lecture_status
            // 
            this.comboBox_lecture_status.FormattingEnabled = true;
            this.comboBox_lecture_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox_lecture_status.Location = new System.Drawing.Point(642, 82);
            this.comboBox_lecture_status.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_lecture_status.Name = "comboBox_lecture_status";
            this.comboBox_lecture_status.Size = new System.Drawing.Size(160, 24);
            this.comboBox_lecture_status.TabIndex = 7;
            // 
            // comboBox_lecture_gender
            // 
            this.comboBox_lecture_gender.FormattingEnabled = true;
            this.comboBox_lecture_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_lecture_gender.Location = new System.Drawing.Point(157, 139);
            this.comboBox_lecture_gender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_lecture_gender.Name = "comboBox_lecture_gender";
            this.comboBox_lecture_gender.Size = new System.Drawing.Size(160, 24);
            this.comboBox_lecture_gender.TabIndex = 6;
            // 
            // text_lecture_name
            // 
            this.text_lecture_name.Location = new System.Drawing.Point(157, 79);
            this.text_lecture_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_name.Name = "text_lecture_name";
            this.text_lecture_name.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_name.TabIndex = 5;
            // 
            // text_lecture_id
            // 
            this.text_lecture_id.Location = new System.Drawing.Point(157, 16);
            this.text_lecture_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_id.Name = "text_lecture_id";
            this.text_lecture_id.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_id.TabIndex = 4;
            // 
            // label_lecturestatus
            // 
            this.label_lecturestatus.AutoSize = true;
            this.label_lecturestatus.Location = new System.Drawing.Point(566, 85);
            this.label_lecturestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturestatus.Name = "label_lecturestatus";
            this.label_lecturestatus.Size = new System.Drawing.Size(44, 16);
            this.label_lecturestatus.TabIndex = 3;
            this.label_lecturestatus.Text = "Status";
            // 
            // label_lecturename
            // 
            this.label_lecturename.AutoSize = true;
            this.label_lecturename.Location = new System.Drawing.Point(17, 79);
            this.label_lecturename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturename.Name = "label_lecturename";
            this.label_lecturename.Size = new System.Drawing.Size(92, 16);
            this.label_lecturename.TabIndex = 1;
            this.label_lecturename.Text = "LenturerName";
            // 
            // label_lectureid
            // 
            this.label_lectureid.AutoSize = true;
            this.label_lectureid.Location = new System.Drawing.Point(17, 16);
            this.label_lectureid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lectureid.Name = "label_lectureid";
            this.label_lectureid.Size = new System.Drawing.Size(68, 16);
            this.label_lectureid.TabIndex = 0;
            this.label_lectureid.Text = "LecturerID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Controls.Add(this.btn_Search);
            this.btnSearch.Controls.Add(this.text_lecture_search);
            this.btnSearch.Controls.Add(this.label_lecturesearch);
            this.btnSearch.Controls.Add(this.text_lecture_address);
            this.btnSearch.Controls.Add(this.label1);
            this.btnSearch.Controls.Add(this.delete_lecture_button);
            this.btnSearch.Controls.Add(this.clear_lecture_button);
            this.btnSearch.Controls.Add(this.update_lecture_button);
            this.btnSearch.Controls.Add(this.add_lecture_button);
            this.btnSearch.Controls.Add(this.comboBox_lecture_status);
            this.btnSearch.Controls.Add(this.comboBox_lecture_gender);
            this.btnSearch.Controls.Add(this.text_lecture_name);
            this.btnSearch.Controls.Add(this.text_lecture_id);
            this.btnSearch.Controls.Add(this.label_lecturestatus);
            this.btnSearch.Controls.Add(this.label_lecturegender);
            this.btnSearch.Controls.Add(this.label_lecturename);
            this.btnSearch.Controls.Add(this.label_lectureid);
            this.btnSearch.Location = new System.Drawing.Point(4, 442);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(1287, 273);
            this.btnSearch.TabIndex = 8;
            // 
            // text_lecture_search
            // 
            this.text_lecture_search.Location = new System.Drawing.Point(642, 19);
            this.text_lecture_search.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_search.Name = "text_lecture_search";
            this.text_lecture_search.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_search.TabIndex = 15;
            // 
            // label_lecturesearch
            // 
            this.label_lecturesearch.AutoSize = true;
            this.label_lecturesearch.Location = new System.Drawing.Point(566, 22);
            this.label_lecturesearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturesearch.Name = "label_lecturesearch";
            this.label_lecturesearch.Size = new System.Drawing.Size(0, 16);
            this.label_lecturesearch.TabIndex = 14;
            // 
            // text_lecture_address
            // 
            this.text_lecture_address.Location = new System.Drawing.Point(642, 138);
            this.text_lecture_address.Margin = new System.Windows.Forms.Padding(4);
            this.text_lecture_address.Name = "text_lecture_address";
            this.text_lecture_address.Size = new System.Drawing.Size(132, 22);
            this.text_lecture_address.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Address";
            // 
            // label_lecturegender
            // 
            this.label_lecturegender.AutoSize = true;
            this.label_lecturegender.Location = new System.Drawing.Point(17, 143);
            this.label_lecturegender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lecturegender.Name = "label_lecturegender";
            this.label_lecturegender.Size = new System.Drawing.Size(52, 16);
            this.label_lecturegender.TabIndex = 2;
            this.label_lecturegender.Text = "Gender";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(4, 161);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1287, 273);
            this.dataGridView.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(549, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // LecturerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView);
            this.Name = "LecturerControl";
            this.Size = new System.Drawing.Size(1305, 744);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnSearch.ResumeLayout(false);
            this.btnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button delete_lecture_button;
        private System.Windows.Forms.Button clear_lecture_button;
        private System.Windows.Forms.Button update_lecture_button;
        private System.Windows.Forms.Button add_lecture_button;
        private System.Windows.Forms.ComboBox comboBox_lecture_status;
        private System.Windows.Forms.ComboBox comboBox_lecture_gender;
        private System.Windows.Forms.TextBox text_lecture_name;
        private System.Windows.Forms.TextBox text_lecture_id;
        private System.Windows.Forms.Label label_lecturestatus;
        private System.Windows.Forms.Label label_lecturename;
        private System.Windows.Forms.Label label_lectureid;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.Label label_lecturegender;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox text_lecture_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_lecture_search;
        private System.Windows.Forms.Label label_lecturesearch;
        private System.Windows.Forms.Button btn_Search;
    }
}
