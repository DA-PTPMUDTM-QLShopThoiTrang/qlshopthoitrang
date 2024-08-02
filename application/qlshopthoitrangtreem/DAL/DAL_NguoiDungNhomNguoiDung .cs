using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NguoiDungNhomNguoiDung
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<QL_NguoiDungNhomNguoiDung> layDsNguoiDungNhomNguoiDungByMa(string manhom)
        {
            return dbcontext.QL_NguoiDungNhomNguoiDungs.Where(item => item.MaNhomNguoiDung == manhom).ToList<QL_NguoiDungNhomNguoiDung>();
        }

        public QL_NguoiDungNhomNguoiDung timNguoiDungNhomNguoiDung(QL_NguoiDungNhomNguoiDung ndnnd)
        {
            QL_NguoiDungNhomNguoiDung x=  dbcontext.QL_NguoiDungNhomNguoiDungs.Where(item=>item.MaNhomNguoiDung == ndnnd.MaNhomNguoiDung && item.TenDangNhap == ndnnd.TenDangNhap).FirstOrDefault();
            return x;
        }

        public QL_NguoiDungNhomNguoiDung them(QL_NguoiDungNhomNguoiDung dmmh)
        {
            try
            {
                dbcontext.QL_NguoiDungNhomNguoiDungs.InsertOnSubmit(dmmh);
                dbcontext.SubmitChanges();
                return dmmh;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool xoa(QL_NguoiDungNhomNguoiDung dmmh)
        {
            QL_NguoiDungNhomNguoiDung NhomNguoiDung = dbcontext.QL_NguoiDungNhomNguoiDungs.SingleOrDefault(mh => mh.TenDangNhap == dmmh.TenDangNhap && mh.MaNhomNguoiDung == dmmh.MaNhomNguoiDung);
            if (NhomNguoiDung != null)
            {
                dbcontext.QL_NguoiDungNhomNguoiDungs.DeleteOnSubmit(NhomNguoiDung);
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }

    }
}
