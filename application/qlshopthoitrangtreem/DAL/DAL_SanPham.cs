using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<sanpham> layDsSanPham()
        {
            return dbcontext.sanphams.OrderByDescending(item=>item.ngaytao).ToList<sanpham>();
        }
        public List<sanpham> layDsSanPham(int skip, int take)
        {
            return dbcontext.sanphams.OrderByDescending(item => item.ngaytao).Skip(skip).Take(take).ToList<sanpham>();
        }
        /*public DM_ManHinh layManHinhByMa(string ma)
        {
            return dbcontext.DM_ManHinhs.Where(item => item.MaManHinh == ma).FirstOrDefault();
        }*/
        public sanpham them(sanpham sp)
        {
            try
            {
                dbcontext.sanphams.InsertOnSubmit(sp);
                dbcontext.SubmitChanges();
                return sp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<danhmuc> layDsDanhMuc()
        {
            return dbcontext.danhmucs.ToList<danhmuc>();
        }
        /*public bool capNhat(DM_ManHinh dmmh)
        {
            DM_ManHinh manHinh = dbcontext.DM_ManHinhs.SingleOrDefault(mh => mh.MaManHinh == dmmh.MaManHinh);
            if (manHinh != null)
            {
                manHinh.TenManHinh = dmmh.TenManHinh;
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoa(string ma)
        {
            DM_ManHinh manHinh = dbcontext.DM_ManHinhs.SingleOrDefault(mh => mh.MaManHinh == ma);
            if (manHinh != null)
            {
                dbcontext.DM_ManHinhs.DeleteOnSubmit(manHinh);
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }*/

    }
}
