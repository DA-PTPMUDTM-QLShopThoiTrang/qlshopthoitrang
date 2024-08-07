using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_DonHang
    {
        int limit = 10;

        DAL_DonHang dlldonhang = new DAL_DonHang();
        public List<donhang> layDsDH()
        {
            return dlldonhang.layDsDonHang();
        }
        public List<donhang> layDsDH(int trangthai)
        {
            return dlldonhang.layDsDonHang(trangthai);
        }
        public int layTongTrang()
        {
            double tong = (double)dlldonhang.layDsDonHang().Count;
            return (int)Math.Ceiling(tong / limit);
        }


        //public List<trangthaidonhang> layDsTrangThaiDonHang()
        //{
        //    return dlldonhang.layDsTrangThaiDonHang();
        //}
        //public List<ChiTietDonHangSanPham> layChiTietDonHang(int donhang_id)
        //{
        //    return dlldonhang.layChiTietDonHang(donhang_id);
        //}
        //public bool capNhatDH(int donhang_id, int trangthai)
        //{
        //    return dlldonhang.capNhat(donhang_id, trangthai);
        //}
        public List<trangthaidonhang> layDsTrangThaiDonHang()
        {
            return dlldonhang.layDsTrangThaiDonHang();
        }
        public List<ChiTietDonHangSanPham> layChiTietDonHang(int donhang_id)
        {
            return dlldonhang.layChiTietDonHang(donhang_id);
        }
        public bool capNhatDH(int donhang_id, int trangthai)
        {
            return dlldonhang.capNhat(donhang_id, trangthai);
        }


        /*public sanpham themSanPham(string ten, string mota, double gia, string gioitinh, int danhmuc_id, string anhdaidien)
        {
            try
            {
                sanpham sp = new sanpham();
                sp.ten = ten;
                sp.mota = mota;
                sp.gia = gia;
                sp.gioitinh = gioitinh;
                sp.DanhMuc_id = danhmuc_id;
                sp.anhdaidien = anhdaidien;
                sp.ngaytao = DateTime.Now;
                return dlldonhang.them(sp);
            }
            catch
            {
                return null;
            }
            return null;
        }*/
        /*public bool xoaManHinh(string ma)
        {
            return manhinh.xoa(ma);
        }
        public bool suaManHinh(string ma, string ten)
        {
            DM_ManHinh mh = new DM_ManHinh();
            mh.MaManHinh = ma;
            mh.TenManHinh = ten;
            return manhinh.capNhat(mh);
        }*/

    }
}
