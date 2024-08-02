using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using static BLL.LoginResultEnum;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace BLL
{
    public class BLL_QLPhanQuyen
    {
        DAL_QLPhanQuyen phanquyen = new DAL_QLPhanQuyen();

        public List<NhomNguoiDungManHinh> layNNDMH(string manhom)
        {
            return phanquyen.LayNhomNguoiDungManHinh(manhom);
        }
       
        public QL_PhanQuyen themNhomNguoiDungManHinh(string manhom, string mamanhinh, bool coquyen)
        {
            if (phanquyen.layNhomNguoiDungManHinhbyMa(manhom, mamanhinh) == null)
            {
                QL_PhanQuyen mh= new QL_PhanQuyen();
                mh.MaManHinh = mamanhinh;
                mh.MaNhomNguoiDung = manhom;
                mh.CoQuyen = coquyen;
                return phanquyen.them(mh);
            }
            return null;
        }
        public bool suaNhomNguoiDungManHinh(string manhom, string mamanhinh, bool coquyen)
        {
            QL_PhanQuyen mh = new QL_PhanQuyen();
            mh.MaManHinh = mamanhinh;
            mh.MaNhomNguoiDung = manhom;
            mh.CoQuyen = coquyen;
            return phanquyen.capNhat(mh);
        }
        public QL_PhanQuyen layNhomNguoiDungManHinhbyMa(string manhom, string mamanhinh)
        {
            QL_PhanQuyen x =  phanquyen.layNhomNguoiDungManHinhbyMa(manhom, mamanhinh);
            return x;
        }
        public List<NhomNguoiDungManHinh> LayDSManHinhPhanQuyen(string manhom)
        {
            return phanquyen.LayDSManHinh(manhom);
        }
    }
}
