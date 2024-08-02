using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ManHinh
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<DM_ManHinh> layDsManHinh()
        {
            return dbcontext.DM_ManHinhs.Select(item => item).ToList<DM_ManHinh>();
        }
        public DM_ManHinh layManHinhByMa(string ma)
        {
            return dbcontext.DM_ManHinhs.Where(item => item.MaManHinh == ma).FirstOrDefault();
        }
        public DM_ManHinh them(DM_ManHinh dmmh)
        {
            try
            {
                dbcontext.DM_ManHinhs.InsertOnSubmit(dmmh);
                dbcontext.SubmitChanges();
                return dmmh;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool capNhat(DM_ManHinh dmmh)
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
        }

    }
}
