﻿using QuanLyLichHoc.Controls;
using QuanLyLichHoc.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LessonBtn_Click(object sender, EventArgs e)
        {
            LessonControl control = new LessonControl();
            Shared.ShowMainContent(control, MainContent);
        }

        private void SubjectsBtn_Click(object sender, EventArgs e)
        {
            SubjectControls control = new SubjectControls();
            Shared.ShowMainContent(control, MainContent);
        }

        private void LecturerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
