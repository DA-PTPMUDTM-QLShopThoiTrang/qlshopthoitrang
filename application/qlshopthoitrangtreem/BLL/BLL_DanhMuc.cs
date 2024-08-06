using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_DanhMuc
    {
        DAL_DanhMuc manhinh = new DAL_DanhMuc();
        public List<danhmuc> layDsDM()
        {
            return manhinh.layDsDanhMuc();
        }
        public danhmuc themDanhMuc(int ma, string ten)
        {
            if (manhinh.layDanhMucByMa(ma) == null)
            {
                danhmuc mh = new danhmuc();
                mh.id= ma;
                mh.ten = ten;
                return manhinh.them(mh);
            }
            return null;
        }
        public bool xoaDanhMuc(int ma)
        {
            return manhinh.xoa(ma);
        }
        public bool suaDanhMuc(int ma, string ten)
        {
            danhmuc mh = new danhmuc();
            mh.id = ma;
            mh.ten = ten;
            return manhinh.capNhat(mh);
        }
    }
}
