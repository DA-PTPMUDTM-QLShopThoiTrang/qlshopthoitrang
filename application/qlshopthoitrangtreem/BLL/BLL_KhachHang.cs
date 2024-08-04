using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_KhachHang dlkh = new DAL_KhachHang();
        public BLL_KhachHang() { }
        public List<khachhang> layDSKH()
        {
            return dlkh.loadKH();
        }
        public List<khachhang> TimKiemKH(string tk)
        {
            return dlkh.TimKiem(tk);
        }
        public bool XoaKhachHang(int id)
        {
            return dlkh.XoaKhachHang(id);
        }

        public bool SuaKhachHang(khachhang khachhangMoi)
        {
            return dlkh.SuaKhachHang(khachhangMoi);
        }
    }
}
