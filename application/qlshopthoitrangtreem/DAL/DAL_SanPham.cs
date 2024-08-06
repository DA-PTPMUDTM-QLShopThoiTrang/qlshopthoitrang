using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        DBDataContext dbcontext = new DBDataContext();

        public List<sanpham> layDsSanPham()
        {
            return dbcontext.sanphams.OrderByDescending(item => item.ngaytao).ToList<sanpham>();
        }
        public List<loaisanpham> layLoaiSP()
        {
            return dbcontext.loaisanphams.Select(l => l).ToList<loaisanpham>();
        }
        public List<kichcosanpham> layKichCoSP()
        {
            return dbcontext.kichcosanphams.Select(k => k).ToList<kichcosanpham>();
        }
        public List<sanpham> layDsSanPham(int skip, int take)
        {
            return dbcontext.sanphams.OrderByDescending(item => item.ngaytao).Skip(skip).Take(take).ToList<sanpham>();
        }
        /*public DM_ManHinh layManHinhByMa(string ma)
        {
            return dbcontext.DM_ManHinhs.Where(item => item.MaManHinh == ma).FirstOrDefault();
        }*/
        public sanpham them(sanpham sp)
        {
            try
            {
                dbcontext.sanphams.InsertOnSubmit(sp);
                dbcontext.SubmitChanges();
                return sp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public loaisanpham them(loaisanpham l)
        {
            try
            {
                dbcontext.loaisanphams.InsertOnSubmit(l);
                dbcontext.SubmitChanges();
                return l;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public kichcosanpham themKichCo(kichcosanpham k)
        {
            try
            {
                dbcontext.kichcosanphams.InsertOnSubmit(k);
                dbcontext.SubmitChanges();
                return k;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public sanpham laySanPhamTheoId(int id)
        {
            try
            {
                return dbcontext.sanphams.SingleOrDefault(p => p.id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public kichcosanpham layKichCoTheoID(int kID)
        {
            try
            {
                return dbcontext.kichcosanphams.SingleOrDefault(p => p.id == kID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public loaisanpham layLoaiTheoId(int id)
        {
            try
            {
                return dbcontext.loaisanphams.SingleOrDefault(p => p.id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public bool xoaKichCo(int kId)
        {
            try
            {
                var xoa = dbcontext.kichcosanphams.SingleOrDefault(p => p.id == kId);
                if (xoa == null)
                {
                    return false;
                }
                dbcontext.kichcosanphams.DeleteOnSubmit(xoa);
                dbcontext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool xoaSanPham(int productId)
        {
            try
            {
                var productToDelete = dbcontext.sanphams.SingleOrDefault(p => p.id== productId);
                if (productToDelete == null)
                {
                    return false;
                }
                dbcontext.sanphams.DeleteOnSubmit(productToDelete);
                dbcontext.SubmitChanges();

                return true;
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
                var sua = dbcontext.kichcosanphams.SingleOrDefault(p => p.id == k.id);
                if (sua == null)
                {
                    throw new Exception("Không tìm thấy kích cỡ cần sửa.");
                }
                sua.soluong = k.soluong;
                sua.kichco = k.kichco;
                sua.LoaiSanPham_id = k.LoaiSanPham_id;
                sua.SanPham_id = k.SanPham_id;
                dbcontext.SubmitChanges();
                return sua;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public sanpham sua(sanpham sp)
        {
            try
            {
                var existingProduct = dbcontext.sanphams.SingleOrDefault(p => p.id == sp.id);
                if (existingProduct == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm cần sửa.");
                }
                existingProduct.ten = sp.ten;
                existingProduct.gia = sp.gia;
                existingProduct.mota = sp.mota;
                existingProduct.gioitinh = sp.gioitinh;
                existingProduct.DanhMuc_id = sp.DanhMuc_id;
                existingProduct.ngaytao = sp.ngaytao;
                existingProduct.anhdaidien = sp.anhdaidien;
                dbcontext.SubmitChanges();
                return existingProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public loaisanpham suaLoai(loaisanpham l)
        {
            try
            {
                var existingProduct = dbcontext.loaisanphams.SingleOrDefault(p => p.id == l.id);
                if (existingProduct == null)
                {
                    throw new Exception("Không tìm thấy loại cần sửa.");
                }
                existingProduct.mausac = l.mausac;
                existingProduct.SanPham_id = l.SanPham_id;
                existingProduct.hinhanh = l.hinhanh;
                dbcontext.SubmitChanges();
                return existingProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<danhmuc> layDsDanhMuc()
        {
            return dbcontext.danhmucs.ToList<danhmuc>();
        }
        
        /*public bool capNhat(DM_ManHinh dmmh)
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
        }*/

    }
}
