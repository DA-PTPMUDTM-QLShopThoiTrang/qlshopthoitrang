using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_NhomNguoiDung
    {
        DAL_NhomNguoiDung nhomnguoidung = new DAL_NhomNguoiDung();
        public List<QL_NhomNguoiDung> layDsMH()
        {
            return nhomnguoidung.layDsNhomNguoiDung();
        }
        public QL_NhomNguoiDung themNhomNguoiDung(string ma, string ten, string ghichu)
        {
            if(nhomnguoidung.layNhomNguoiDungByMa(ma) == null)
            {
                QL_NhomNguoiDung mh = new QL_NhomNguoiDung();
                mh.MaNhom = ma;
                mh.TenNhom = ten;
                mh.GhiChu = ghichu;
                return nhomnguoidung.them(mh);
            }
            return null;
        }
        public bool xoaNhomNguoiDung(string ma)
        {
            return nhomnguoidung.xoa(ma);
        }
        public bool suaNhomNguoiDung(string ma, string ten, string ghichu)
        {
            QL_NhomNguoiDung mh = new QL_NhomNguoiDung();
            mh.MaNhom = ma;
            mh.TenNhom = ten;
            mh.GhiChu = ghichu;
            return nhomnguoidung.capNhat(mh);
        }
        public List<string> layDsNhomNguoiDungTypeLString(string tendangnhap)
        {
            return nhomnguoidung.layDsNhomNguoiDungTypeLString(tendangnhap);
        }

    }
}
