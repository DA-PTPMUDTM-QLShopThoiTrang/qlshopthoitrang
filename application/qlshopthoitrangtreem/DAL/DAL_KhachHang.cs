using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        DBDataContext db = new DBDataContext();
        public DAL_KhachHang() { }
        public List<khachhang> loadKH()
        {
            return db.khachhangs.Select(kh => kh).ToList<khachhang>();
        }
        public List<khachhang> TimKiem(string tk)
        {
            return db.khachhangs.Where(kh => kh.id.ToString().Contains(tk) ||kh.ten.Contains(tk) ||kh.sdt.Contains(tk) ||kh.email.Contains(tk)).ToList();
        }
        public bool XoaKhachHang(int id)
        {
            try
            {
                var khachhang = db.khachhangs.SingleOrDefault(kh => kh.id == id);
                if (khachhang != null)
                {
                    db.khachhangs.DeleteOnSubmit(khachhang);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaKhachHang(khachhang khachhangMoi)
        {
            try
            {
                var khachhang = db.khachhangs.SingleOrDefault(kh => kh.id == khachhangMoi.id);
                if (khachhang != null)
                {
                    khachhang.ten = khachhangMoi.ten;
                    khachhang.email = khachhangMoi.email;
                    khachhang.sdt = khachhangMoi.sdt;
                    khachhang.matkhau = khachhangMoi.matkhau;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
