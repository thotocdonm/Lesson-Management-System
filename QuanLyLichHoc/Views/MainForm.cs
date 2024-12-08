using QuanLyLichHoc.Controls;
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

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            // Tạo instance của StudentControl
            var studentControl = new StudentControl1();

            // Hiển thị StudentControl trong mainContentPanel
            Shared.ShowMainContent(studentControl, MainContent);
        }
    

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
