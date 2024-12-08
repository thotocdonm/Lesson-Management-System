using QuanLyLichHoc.Services;
using System;
using System.Windows.Forms;

namespace QuanLyLichHoc.Controls.Student
{
    public partial class SubjectEnrollmentControl : UserControl
    {
        public SubjectEnrollmentControl()
        {
            InitializeComponent();
            LoadData();
        }
        SubjectEnrollmentService ctrl = new SubjectEnrollmentService();

        public void LoadData(bool isAscending = true)
        {
            var rs = ctrl.GetAll();
            if (rs.Count > 0)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = rs;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
