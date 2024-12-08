using QuanLyLichHoc.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichHoc.Controls
{
    public partial class SubjectControls : UserControl
    {
        public SubjectControls()
        {
            InitializeComponent();
        }
        SubjectService ctrl = new SubjectService();
        public void LoadData(bool isAscending = true)
        {
            var rs = ctrl.GetAll();
            switch (rs.ErrCode)
            {
                case Models.EnumErrCodeService.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCodeService.Success:
                    var allData = rs.Data;

                    // Sắp xếp dữ liệu theo số tín chỉ
                    if (isAscending)
                        allData = allData.OrderBy(x => x.creditHours).ToList();
                    else
                        allData = allData.OrderByDescending(x => x.creditHours).ToList();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = allData;
                    break;

                case Models.EnumErrCodeService.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.DataSource = null;
                    break;
            }
        }


        private void SubjectControls_Load(object sender, EventArgs e)
        {
            cbSortOrder.Items.Clear();
            cbSortOrder.Items.Add("Tăng dần");
            cbSortOrder.Items.Add("Giảm dần");
            cbSortOrder.SelectedIndex = 0; // Mặc định chọn "Sắp xếp tăng dần"
            var rs = ctrl.GetAll();
            //switch tab tab - rs.err- enter
            switch (rs.ErrCode)
            {
                case Models.EnumErrCodeService.Error:
                    MessageBox.Show(rs.ErrDesc, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCodeService.Success:
                    dataGridView1.DataSource = rs.Data;
                    break;
                case Models.EnumErrCodeService.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
            btn_Sua.Visible = false;
            btn_Xoa.Visible = false;
            btn_Back.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_Sua.Visible)
            {
                //người dùng đang trong tác vụ sửa/xóa
                if (MessageBox.Show("Bạn có muốn hủy tác vụ hiện tại không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //đã xác nhận hủy tác vụ hiện tại.
                    btn_Sua.Visible = false;
                    btn_Xoa.Visible = false;

                    txt_MaMH.ReadOnly = false;

                    txt_MaMH.Text = "";
                    txt_TenMH.Text = "";
                    txt_SoTC.Text = "";

                    return;
                }
            }
            string subjectId = txt_MaMH.Text;
            string subjectName = txt_TenMH.Text;
            string creditHours = txt_SoTC.Text;

            var rs = ctrl.Them(subjectId, subjectName, creditHours);


            switch (rs.ErrCode)
            {
                case Models.EnumErrCodeService.Error:
                    MessageBox.Show(rs.ErrDesc, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCodeService.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Models.EnumErrCodeService.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                    break;
                case Models.EnumErrCodeService.InvalidInput:
                    MessageBox.Show(rs.ErrDesc, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
            txt_MaMH.Text = "";
            txt_TenMH.Text = "";
            txt_SoTC.Text = "";
            btn_Sua.Visible = false;
            btn_Xoa.Visible = false;
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string subjectId = txt_MaMH.Text;
            string subjectName = txt_TenMH.Text;
            string creditHours = txt_SoTC.Text;

            var rs = ctrl.Sua(subjectId, subjectName, creditHours);
            switch (rs.ErrCode)
            {
                case Models.EnumErrCodeService.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCodeService.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Models.EnumErrCodeService.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    break;
                case Models.EnumErrCodeService.InvalidInput:
                    MessageBox.Show(rs.ErrDesc, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
            txt_MaMH.Text = "";
            txt_TenMH.Text = "";
            txt_SoTC.Text = "";
            btn_Sua.Visible = false;
            btn_Xoa.Visible = false;
        }

        private void frm_QLMH_Load(object sender, EventArgs e)
        {

            var rs = ctrl.GetAll();
            //switch tab tab - rs.err- enter
            switch (rs.ErrCode)
            {
                case Models.EnumErrCodeService.Error:
                    MessageBox.Show(rs.ErrDesc, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCodeService.Success:
                    dataGridView1.DataSource = rs.Data;
                    break;
                case Models.EnumErrCodeService.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không?", "Xác nhận xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string subjectId = txt_MaMH.Text;
                var rs = ctrl.Xoa(subjectId);

                switch (rs.ErrCode)
                {
                    case Models.EnumErrCodeService.Error:
                        MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Models.EnumErrCodeService.Empty:
                        MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case Models.EnumErrCodeService.Success:
                        MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        break;
                    case Models.EnumErrCodeService.InvalidInput:
                        MessageBox.Show(rs.ErrDesc, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                txt_MaMH.Text = "";
                txt_TenMH.Text = "";
                txt_SoTC.Text = "";
                btn_Sua.Visible = false;
                btn_Xoa.Visible = false;
            }
            else
            {
                LoadData();
                txt_MaMH.Text = "";
                txt_TenMH.Text = "";
                txt_SoTC.Text = "";
                btn_Sua.Visible = false;
                btn_Xoa.Visible = false;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dataGridView1.Rows[e.RowIndex];

            txt_MaMH.Text = r.Cells[0].Value.ToString();
            txt_TenMH.Text = r.Cells[1].Value.ToString();
            txt_SoTC.Text = r.Cells[2].Value.ToString();


            btn_Sua.Visible = true;
            btn_Xoa.Visible = true;
            txt_MaMH.ReadOnly = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text.Trim();

            // Gọi hàm tìm kiếm từ lớp điều khiển
            var rs = ctrl.TimKiem(keyword);

            // Xử lý kết quả trả về
            switch (rs.ErrCode)
            {
                case Models.EnumErrCodeService.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCodeService.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Xóa dữ liệu hiển thị nếu không tìm thấy
                    dataGridView1.DataSource = null;
                    btn_Back.Visible = true; // Hiển thị nút Back
                    break;
                case Models.EnumErrCodeService.Success:
                    // Hiển thị kết quả tìm kiếm lên DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = rs.Data;
                    MessageBox.Show(rs.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Back.Visible = true; // Hiển thị nút Back
                    btn_Them.Visible = false;
                    btn_Sua.Visible=false;
                    btn_Xoa.Visible=false;
                    cbSortOrder.Visible=false;

                    break;
                case Models.EnumErrCodeService.InvalidInput:
                    MessageBox.Show(rs.ErrDesc, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            LoadData();

            // Ẩn nút Back
            btn_Back.Visible = false;

            // Xóa từ khóa tìm kiếm
            txt_Search.Text = string.Empty;
        }

       

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txt_MaMH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortOrder.SelectedIndex == 0)
            {
                LoadData(true); // Sắp xếp tăng dần
            }
            else if (cbSortOrder.SelectedIndex == 1)
            {
                LoadData(false); // Sắp xếp giảm dần
            }
        }
    }
}