using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DanhMuc
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<danhmuc> layDsDanhMuc()
        {
            return dbcontext.danhmucs.Select(item => item).ToList<danhmuc>();
        }
        public danhmuc layDanhMucByMa(int ma)
        {
            return dbcontext.danhmucs.Where(item => item.id == ma).FirstOrDefault();
        }
        public danhmuc them(danhmuc dmmh)
        {
            try
            {
                dbcontext.danhmucs.InsertOnSubmit(dmmh);
                dbcontext.SubmitChanges();
                return dmmh;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool capNhat(danhmuc dmmh)
        {
            danhmuc manHinh = dbcontext.danhmucs.SingleOrDefault(mh => mh.id == dmmh.id);
            if (manHinh != null)
            {
                manHinh.ten = dmmh.ten;
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoa(int ma)
        {
            danhmuc manHinh = dbcontext.danhmucs.SingleOrDefault(mh => mh.id == ma);
            if (manHinh != null)
            {
                dbcontext.danhmucs.DeleteOnSubmit(manHinh);
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
