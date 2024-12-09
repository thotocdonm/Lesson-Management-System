using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichHoc.Controls
{
    public partial class HomeControlDay : UserControl
    {
        public HomeControlDay()
        {
            InitializeComponent();
        }

        private void HomeControlDay_Load(object sender, EventArgs e)
        {

        }

        public void days(string numDay)
        {
            lbDay.Text = numDay;
        }
        public void labels(string label)
        {
            labelValue.Text = label;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
