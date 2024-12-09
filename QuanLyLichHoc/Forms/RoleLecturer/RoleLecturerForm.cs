using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using QuanLyLichHoc.Controls;
using QuanLyLichHoc.Utils;

namespace QuanLyLichHoc.Forms.RoleLecturer
{
    public partial class RoleLecturerForm : Form
    {
        public RoleLecturerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LecturerInfBtn_Click(object sender, EventArgs e)
        {
            LecturerInfControl lecturerInfControl = new LecturerInfControl();
            Shared.ShowMainContent(lecturerInfControl, panelLecture);
        }
    }
}
