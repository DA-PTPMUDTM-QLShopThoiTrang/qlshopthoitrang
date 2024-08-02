using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomNguoiDungManHinh
    {
        public string MaManHinh, TenManHinh;
        public bool CoQuyen;
        public NhomNguoiDungManHinh() { }
        public NhomNguoiDungManHinh(string MaManHinh, string TenManHinh, bool CoQuyen) {
            this.MaManHinh = MaManHinh;
            this.TenManHinh = TenManHinh;
            this.CoQuyen = CoQuyen;
        }
    }
}
