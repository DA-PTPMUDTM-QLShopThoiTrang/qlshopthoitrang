using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NguoiDung
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<QL_NguoiDung> layDsNguoiDung()
        {
            return dbcontext.QL_NguoiDungs.Select(item => item).ToList<QL_NguoiDung>();
        }
        public QL_NguoiDung layNguoiDung(string tendangnhap, string matkhau)
        {
            return dbcontext.QL_NguoiDungs.Where(item => item.TenDangNhap == tendangnhap && item.MatKhau == matkhau).FirstOrDefault();
        }
        public QL_NguoiDung them(QL_NguoiDung nd)
        {
            try
            {
                dbcontext.QL_NguoiDungs.InsertOnSubmit(nd);
                dbcontext.SubmitChanges();
                return nd;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool capNhat(QL_NguoiDung nd)
        {
            QL_NguoiDung NguoiDung = dbcontext.QL_NguoiDungs.SingleOrDefault(mh => mh.TenDangNhap == nd.TenDangNhap);
            if (NguoiDung != null)
            {
                NguoiDung.MatKhau = nd.MatKhau;
                NguoiDung.HoatDong = nd.HoatDong;
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoa(string temdangnhap)
        {
            QL_NguoiDung NguoiDung = dbcontext.QL_NguoiDungs.SingleOrDefault(mh => mh.TenDangNhap == temdangnhap);
            if (NguoiDung != null)
            {
                dbcontext.QL_NguoiDungs.DeleteOnSubmit(NguoiDung);
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }
        public QL_NguoiDung layNhomNguoiByMa(string tendangnhap)
        {
            return dbcontext.QL_NguoiDungs.Where(item => item.TenDangNhap == tendangnhap).FirstOrDefault();
        }
    }
}
