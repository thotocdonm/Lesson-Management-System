using QuanLyLichHoc.Controls.Student;
using QuanLyLichHoc.Utils;
using System.Windows.Forms;

namespace QuanLyLichHoc.Views
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentsBtn_Click(object sender, System.EventArgs e)
        {
            StudentInformationControl control = new StudentInformationControl();
            Shared.ShowMainContent(control, MainContent);
        }

        private void SubjectsBtn_Click(object sender, System.EventArgs e)
        {
            SubjectEnrollmentControl control = new SubjectEnrollmentControl();
            Shared.ShowMainContent(control, MainContent);
        }
    }
}
