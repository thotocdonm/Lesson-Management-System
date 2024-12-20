﻿namespace QuanLyLichHoc.Forms.RoleLecturer
{
    partial class RoleLecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleLecturerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LecturerInfBtn = new System.Windows.Forms.Button();
            this.LessonBtn = new System.Windows.Forms.Button();
            this.panelLecture = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2280, 142);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(795, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Dashboard";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.LecturerInfBtn);
            this.panel2.Controls.Add(this.LessonBtn);
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 828);
            this.panel2.TabIndex = 2;
            // 
            // LecturerInfBtn
            // 
            this.LecturerInfBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LecturerInfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LecturerInfBtn.FlatAppearance.BorderSize = 0;
            this.LecturerInfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecturerInfBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerInfBtn.Image = ((System.Drawing.Image)(resources.GetObject("LecturerInfBtn.Image")));
            this.LecturerInfBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LecturerInfBtn.Location = new System.Drawing.Point(0, 196);
            this.LecturerInfBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 62);
            this.LecturerInfBtn.Name = "LecturerInfBtn";
            this.LecturerInfBtn.Size = new System.Drawing.Size(355, 86);
            this.LecturerInfBtn.TabIndex = 3;
            this.LecturerInfBtn.Text = "Information";
            this.LecturerInfBtn.UseVisualStyleBackColor = false;
            this.LecturerInfBtn.Click += new System.EventHandler(this.LecturerInfBtn_Click);
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
            this.LessonBtn.Location = new System.Drawing.Point(0, 48);
            this.LessonBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 62);
            this.LessonBtn.Name = "LessonBtn";
            this.LessonBtn.Size = new System.Drawing.Size(355, 86);
            this.LessonBtn.TabIndex = 2;
            this.LessonBtn.Text = "Lesson";
            this.LessonBtn.UseVisualStyleBackColor = false;
            // 
            // panelLecture
            // 
            this.panelLecture.Location = new System.Drawing.Point(358, 145);
            this.panelLecture.Name = "panelLecture";
            this.panelLecture.Size = new System.Drawing.Size(1564, 469);
            this.panelLecture.TabIndex = 3;
            // 
            // RoleLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 614);
            this.Controls.Add(this.panelLecture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RoleLecturerForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button LecturerInfBtn;
        private System.Windows.Forms.Button LessonBtn;
        private System.Windows.Forms.Panel panelLecture;
    }
}