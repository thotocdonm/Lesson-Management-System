using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichHoc.Models
{
    internal class FunctionResultService<T>
    {
        public EnumErrCodeService ErrCode { get; set; }//success/fail
        public string ErrDesc { get; set; }
        public T Data { get; set; }
    }
}
