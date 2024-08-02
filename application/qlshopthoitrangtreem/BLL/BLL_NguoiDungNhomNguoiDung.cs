using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_NguoiDungNhomNguoiDung
    {
        DAL_NguoiDungNhomNguoiDung ndnnd = new DAL_NguoiDungNhomNguoiDung();
        public List<QL_NguoiDungNhomNguoiDung> layDsByMa(string manhom)
        {
            return ndnnd.layDsNguoiDungNhomNguoiDungByMa(manhom);
        }
        public QL_NguoiDungNhomNguoiDung themNguoiDungNhomNguoiDung(string manhom, string tendangnhap, string ghichu)
        {
            QL_NguoiDungNhomNguoiDung nd = new QL_NguoiDungNhomNguoiDung();
            nd.MaNhomNguoiDung = manhom;
            nd.TenDangNhap = tendangnhap;
            nd.GhiChu = ghichu;
            if (ndnnd.timNguoiDungNhomNguoiDung(nd) == null)
            {
                return ndnnd.them(nd);
            }
            return null;
        }
        public bool xoaNguoiDungNhomNguoiDung(string manhom, string tendangnhap)
        {
            QL_NguoiDungNhomNguoiDung nd = new QL_NguoiDungNhomNguoiDung();
            nd.MaNhomNguoiDung = manhom;
            nd.TenDangNhap = tendangnhap;
            return ndnnd.xoa(nd);
        }

    }
}
