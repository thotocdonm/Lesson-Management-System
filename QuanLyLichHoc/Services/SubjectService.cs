using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyLichHoc.Models;
using System.Windows.Forms;

namespace QuanLyLichHoc.Services
{
    internal class SubjectService
    {
        DataClasses1DataContext db = new DataClasses1DataContext("Data Source=LAPTOP-RKQKC3JG\\SQLEXPRESS;Initial Catalog=QuanLyLichHoc;Integrated Security=True");


    public FunctionResultService<List<Subject>> GetAll()
    {
        FunctionResultService<List<Subject>> rs = new FunctionResultService<List<Subject>>(); ;
        try
        {
            var qr = db.Subjects;
            if (qr.Any())
            {
                //lay dc du lieu tu csdl(success)
                rs.ErrCode = EnumErrCodeService.Success;
                rs.ErrDesc = "Lấy dứ liệu thành công";
                rs.Data = qr.ToList();
            }
            else
            {
                //empty
                rs.ErrCode = EnumErrCodeService.Empty;
                rs.ErrDesc = "Dữ liệu trong cơ sở dữ liệu đang trống";
                rs.Data = null;

            }
        }
        catch (Exception ex)
        {
            //error
            rs.ErrCode = EnumErrCodeService.Error;
            rs.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu môn học. Chi tiết lỗi: " + ex.Message;

            rs.Data = null;
        }
        return rs;
    }

    public FunctionResultService<Subject> Them(string subjectId, string subjectName, string creditHours)
    {
        FunctionResultService<Subject> rs = new FunctionResultService<Subject>(); ;
        try
        {
            if (string.IsNullOrEmpty(subjectId) || string.IsNullOrEmpty(subjectName) || string.IsNullOrEmpty(creditHours))
            {
                rs.ErrCode = EnumErrCodeService.InvalidInput;
                rs.ErrDesc = "Vui lòng nhập đầy đủ các trường dữ liệu bắt buộc";
                rs.Data = null;
                return rs;
            }


            Subject obj = new Subject();
            obj.subjectId = subjectId;
            obj.subjectName = subjectName;
            obj.creditHours = creditHours;


            db.Subjects.InsertOnSubmit(obj);
            db.SubmitChanges();

            rs.ErrCode = EnumErrCodeService.Success;
            rs.ErrDesc = "Thêm mới môn học thành công";
            rs.Data = obj;
        }
        catch (Exception ex)
        {
            //error
            rs.ErrCode = EnumErrCodeService.Error;
            rs.ErrDesc = "Có lỗi xảy ra trong quá trình thêm mới dữ liệu môn học.Chi tiết lỗi " + ex.Message;

            rs.Data = null;
        }
        return rs;
    }

    public FunctionResultService<Subject> Sua(string subjectId, string subjectName, string creditHours)
    {
        FunctionResultService<Subject> rs = new FunctionResultService<Subject>(); ;
        try
        {
            if (string.IsNullOrEmpty(subjectId) || string.IsNullOrEmpty(subjectName) || string.IsNullOrEmpty(creditHours))
            {
                rs.ErrCode = EnumErrCodeService.InvalidInput;
                rs.ErrDesc = "Vui lòng nhập đầy đủ các trường dữ liệu bắt buộc";
                rs.Data = null;
                return rs;
            }

            //tbl_TaiKhoan obj = new tbl_TaiKhoan();

            var qr = db.Subjects.Where(o => o.subjectId == subjectId);
            if (qr.Any())
            {
                var obj = qr.SingleOrDefault();
                obj.subjectId = subjectId;
                obj.subjectName = subjectName;
                obj.creditHours = creditHours;


                db.SubmitChanges();

                rs.ErrCode = EnumErrCodeService.Success;
                rs.ErrDesc = "Cập nhật môn học thành công";
                rs.Data = obj;
            }
            else
            {
                rs.ErrCode = EnumErrCodeService.Empty;
                rs.ErrDesc = "Không tìm thấy môn học cần sửa";
                rs.Data = null;
            }


        }
        catch (Exception ex)
        {
            //error
            rs.ErrCode = EnumErrCodeService.Error;
            rs.ErrDesc = "Có lỗi xảy ra trong quá trình cập nhật dữ liệu môn học. Chi tiết lỗi: " + ex.Message;
            rs.Data = null;
        }

        return rs;
    }

    public FunctionResultService<Subject> Xoa(string subjectId)
    {
        FunctionResultService<Subject> rs = new FunctionResultService<Subject>();

        try
        {


            //tbl_TaiKhoan obj = new tbl_TaiKhoan();

            var qr = db.Subjects.Where(o => o.subjectId == subjectId);
            if (qr.Any())
            {
                var obj = qr.SingleOrDefault();

                db.Subjects.DeleteOnSubmit(obj);
                db.SubmitChanges();

                rs.ErrCode = EnumErrCodeService.Success;
                rs.ErrDesc = "Xóa môn học thành công";
                rs.Data = obj;
            }
            else
            {
                rs.ErrCode = EnumErrCodeService.Empty;
                rs.ErrDesc = "Không tìm thấy môn học cần xóa";
                rs.Data = null;
            }


        }
        catch (Exception ex)
        {
            //error
            rs.ErrCode = EnumErrCodeService.Error;
            rs.ErrDesc = "Có lỗi xảy ra trong quá trình xóa dữ liệu môn học. Chi tiết lỗi: " + ex.Message;
            rs.Data = null;
        }

        return rs;
    }
        public FunctionResultService<List<Subject>> TimKiem(string keyword)
        {
            FunctionResultService<List<Subject>> rs = new FunctionResultService<List<Subject>>();

            try
            {
                // Kiểm tra từ khóa có hợp lệ không
                if (string.IsNullOrEmpty(keyword))
                {
                    rs.ErrCode = EnumErrCodeService.InvalidInput;
                    rs.ErrDesc = "Vui lòng nhập từ khóa tìm kiếm";
                    rs.Data = null;
                    return rs;
                }

                // Truy vấn dữ liệu
                var qr = db.Subjects
                           .Where(o => o.subjectName.Contains(keyword));

                if (qr.Any())
                {
                    rs.ErrCode = EnumErrCodeService.Success;
                    rs.ErrDesc = $"Tìm thấy {qr.Count()} môn học với từ khóa '{keyword}'";
                    rs.Data = qr.ToList();
                }
                else
                {
                    rs.ErrCode = EnumErrCodeService.Empty;
                    rs.ErrDesc = "Không tìm thấy môn học phù hợp với từ khóa";
                    rs.Data = null;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                rs.ErrCode = EnumErrCodeService.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong quá trình tìm kiếm. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }

    }
}
