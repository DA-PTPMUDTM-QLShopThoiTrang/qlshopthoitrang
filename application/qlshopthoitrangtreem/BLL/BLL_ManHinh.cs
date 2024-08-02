using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_ManHinh
    {
        DAL_ManHinh manhinh = new DAL_ManHinh();
        public List<DM_ManHinh> layDsMH()
        {
            return manhinh.layDsManHinh();
        }
        public DM_ManHinh themManHinh(string ma, string ten)
        {
            if(manhinh.layManHinhByMa(ma) == null)
            {
                DM_ManHinh mh = new DM_ManHinh();
                mh.MaManHinh = ma;
                mh.TenManHinh = ten;
                return manhinh.them(mh);
            }
            return null;
        }
        public bool xoaManHinh(string ma)
        {
            return manhinh.xoa(ma);
        }
        public bool suaManHinh(string ma, string ten)
        {
            DM_ManHinh mh = new DM_ManHinh();
            mh.MaManHinh = ma;
            mh.TenManHinh = ten;
            return manhinh.capNhat(mh);
        }

    }
}
