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
        public List<loaisanpham> loadLoaiSP()
        {
            return dllsanpham.layLoaiSP();
        }
        public List<kichcosanpham> loadKichCo()
        {
            return dllsanpham.layKichCoSP();
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
        public kichcosanpham layKichCoTheoID(int kID)
        {

            try
            {
                return dllsanpham.layKichCoTheoID(kID);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public loaisanpham layLoaiTheoId(int id)
        {
            try
            {
                return dllsanpham.layLoaiTheoId(id);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public kichcosanpham themKichCo(string kichco, int soluong, int sanpham_id, int loai_id)
        {
            try
            {
                var k = new kichcosanpham
                {
                    kichco = kichco,
                    soluong = soluong,
                    SanPham_id = sanpham_id,
                    LoaiSanPham_id = loai_id
                };
                return dllsanpham.themKichCo(k);
            }
            catch
            {
                return null;
            }
        }
        public loaisanpham themLoai(string mausac, int sanpham_id, string anhdaidien)
        {
            try
            {
                loaisanpham l = new loaisanpham();
                l.mausac = mausac;
                l.SanPham_id = sanpham_id;
                l.hinhanh = anhdaidien;
                return dllsanpham.them(l);
            }
            catch
            {
                return null;
            }
            return null;
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
        public bool xoaKichCo(int kID)
        {
            try
            {
                return dllsanpham.xoaKichCo(kID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public kichcosanpham suaKichCo(kichcosanpham k)
        {
            try
            {
                return dllsanpham.suaKichCo(k);
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
        public loaisanpham SuaLoai(loaisanpham l)
        {
            try
            {
                return dllsanpham.suaLoai(l);
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
