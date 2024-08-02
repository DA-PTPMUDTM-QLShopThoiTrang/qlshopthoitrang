using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhomNguoiDung
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<QL_NhomNguoiDung> layDsNhomNguoiDung()
        {
            return dbcontext.QL_NhomNguoiDungs.Select(item => item).ToList<QL_NhomNguoiDung>();
        }
        public QL_NhomNguoiDung layNhomNguoiDungByMa(string ma)
        {
            return dbcontext.QL_NhomNguoiDungs.Where(item => item.MaNhom == ma).FirstOrDefault();
        }
        public QL_NhomNguoiDung them(QL_NhomNguoiDung dmmh)
        {
            try
            {
                dbcontext.QL_NhomNguoiDungs.InsertOnSubmit(dmmh);
                dbcontext.SubmitChanges();
                return dmmh;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool capNhat(QL_NhomNguoiDung dmmh)
        {
            QL_NhomNguoiDung NhomNguoiDung = dbcontext.QL_NhomNguoiDungs.SingleOrDefault(mh => mh.MaNhom == dmmh.MaNhom);
            if (NhomNguoiDung != null)
            {
                NhomNguoiDung.TenNhom = dmmh.TenNhom;
                NhomNguoiDung.GhiChu = dmmh.GhiChu;
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoa(string ma)
        {
            QL_NhomNguoiDung NhomNguoiDung = dbcontext.QL_NhomNguoiDungs.SingleOrDefault(mh => mh.MaNhom == ma);
            if (NhomNguoiDung != null)
            {
                dbcontext.QL_NhomNguoiDungs.DeleteOnSubmit(NhomNguoiDung);
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }
        public List<string> layDsNhomNguoiDungTypeLString(string tendangnhap)
        {
            var result = from nnd in dbcontext.QL_NhomNguoiDungs
                         join ndnnd in dbcontext.QL_NguoiDungNhomNguoiDungs on nnd.MaNhom equals ndnnd.MaNhomNguoiDung
                         where ndnnd.TenDangNhap == tendangnhap
                         select nnd;
            List<string> listMaNhom = new List<string>();
            foreach(object item in result)
            {
                listMaNhom.Add((string)item.GetType().GetProperty("MaNhom").GetValue(item, null));
            }
            return listMaNhom;
        }
    }
}
