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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeControl control = new HomeControl();
            Shared.ShowMainContent(control, MainContent);
        }

        private void LecturerBtn_Click(object sender, EventArgs e)
        {

        }

        private void SubjectsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
