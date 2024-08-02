using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QLPhanQuyen
    {
        DBDataContext dbcontext = new DBDataContext();
        public List<NhomNguoiDungManHinh> LayNhomNguoiDungManHinh(string manhom)
        {
            List<DM_ManHinh> dmmh = dbcontext.DM_ManHinhs.Select(item => item).ToList<DM_ManHinh>();

            List<QL_PhanQuyen> qlpq = dbcontext.QL_PhanQuyens.Where(item => item.MaNhomNguoiDung == manhom).ToList<QL_PhanQuyen>();

            List<NhomNguoiDungManHinh> ds = new List<NhomNguoiDungManHinh>();
            foreach (DM_ManHinh item in dmmh)
            {
                QL_PhanQuyen pq = qlpq.Find(row => row.MaManHinh == item.MaManHinh);
                if (pq != null)
                {
                    ds.Add(new NhomNguoiDungManHinh(item.MaManHinh, item.TenManHinh, pq.CoQuyen));
                }
                else
                {
                    ds.Add(new NhomNguoiDungManHinh(item.MaManHinh, item.TenManHinh, false));
                }
            }
            return ds;
        }
        public QL_PhanQuyen layNhomNguoiDungManHinhbyMa(string manhom, string mamanhinh)
        {
            return dbcontext.QL_PhanQuyens.Where(item => item.MaNhomNguoiDung == manhom && item.MaManHinh == mamanhinh).FirstOrDefault();
        }


        public QL_PhanQuyen them(QL_PhanQuyen dmmh)
        {
            try
            {
                dbcontext.QL_PhanQuyens.InsertOnSubmit(dmmh);
                dbcontext.SubmitChanges();
                return dmmh;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool capNhat(QL_PhanQuyen dmmh)
        {
            QL_PhanQuyen manHinh = dbcontext.QL_PhanQuyens.Where(item => item.MaNhomNguoiDung == dmmh.MaNhomNguoiDung && item.MaManHinh == dmmh.MaManHinh).FirstOrDefault();
            if (manHinh != null)
            {
                manHinh.CoQuyen = dmmh.CoQuyen;
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }
        public List<NhomNguoiDungManHinh> LayDSManHinh(string manhom)
        {
            List<DM_ManHinh> dmmh = dbcontext.DM_ManHinhs.Select(item => item).ToList<DM_ManHinh>();

            List<QL_PhanQuyen> qlpq = dbcontext.QL_PhanQuyens.Where(item => item.MaNhomNguoiDung == manhom).ToList<QL_PhanQuyen>();

            List<NhomNguoiDungManHinh> ds = new List<NhomNguoiDungManHinh>();
            foreach (DM_ManHinh item in dmmh)
            {
                QL_PhanQuyen pq = qlpq.Find(row => row.MaManHinh == item.MaManHinh && row.CoQuyen == true);
                if (pq != null)
                {
                    ds.Add(new NhomNguoiDungManHinh(item.MaManHinh,  item.TenManHinh, pq.CoQuyen));
                }
            }
            return ds;
        }
    }
}
