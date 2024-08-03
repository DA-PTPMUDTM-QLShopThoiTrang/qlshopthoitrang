using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_SanPham
    {
        int limit = 8;

        DAL_SanPham dllsanpham = new DAL_SanPham();
        public List<sanpham> layDsSP()
        {
            return dllsanpham.layDsSanPham();
        }
        public List<sanpham> layDsSP(int p)
        {
            int skip = (p - 1) * 10;
            return dllsanpham.layDsSanPham(skip, limit);
        }
        public int layTongTrang()
        {
            double tong = (double)dllsanpham.layDsSanPham().Count;
            return (int)Math.Ceiling(tong/limit);
        }
        public sanpham laySanPhamTheoId(int id)
        {
            try
            {
                return dllsanpham.laySanPhamTheoId(id);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public sanpham themSanPham(string ten, string mota, double gia, string gioitinh, int danhmuc_id, string anhdaidien)
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
                return dllsanpham.them(sp);
            }
            catch
            {
                return null;
            }
            return null;
        }
        public bool XoaSanPham(int productId)
        {
            try
            {
                return dllsanpham.xoaSanPham(productId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public sanpham SuaSanPham(sanpham sp)
        {
            try
            {
                return dllsanpham.sua(sp);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<danhmuc> layDsDanhMuc()
        {
            return dllsanpham.layDsDanhMuc();
        }
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
