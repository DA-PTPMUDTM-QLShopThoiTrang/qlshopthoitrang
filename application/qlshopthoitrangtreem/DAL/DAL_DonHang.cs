using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DonHang
    {
        DBDataContext dbcontext = new DBDataContext();
        public List<donhang> layDsDonHang()
        {
            return dbcontext.donhangs.OrderByDescending(item => item.ngaytao).ToList<donhang>();
        }
        public List<donhang> layDsDonHang(int skip, int take)
        {
            return dbcontext.donhangs.OrderByDescending(item => item.ngaytao).Skip(skip).Take(take).ToList<donhang>();
        }
        public List<donhang> layDsDonHang(int trangthai = 1)
        {
            if (trangthai == 1)
            {
                return dbcontext.donhangs.Where(item => item.TrangThaiDonHang_id == trangthai).OrderByDescending(item => item.ngaytao).ToList<donhang>();
            }
            return dbcontext.donhangs.Where(item => item.TrangThaiDonHang_id == trangthai).OrderByDescending(item => item.ngaysua).ToList<donhang>();
        }

        public List<trangthaidonhang> layDsTrangThaiDonHang()
        {
            return dbcontext.trangthaidonhangs.ToList<trangthaidonhang>();
        }


        //public List<ChiTietDonHangSanPham> layChiTietDonHang(int donhang_id)
        //{
        //    var result = from chitiet in dbcontext.chitietdonhangs 
        //                 join kichco in dbcontext.kichcosanphams on chitiet.SanPham_id equals kichco.id
        //                 join loai in dbcontext.loaisanphams on kichco.LoaiSanPham_id equals loai.id
        //                 join sanpham in dbcontext.sanphams on loai.SanPham_id equals sanpham.id
        //                 where chitiet.DonHang_id == donhang_id
        //                 select new
        //                 {
        //                     id = chitiet.DonHang_id,
        //                     tensanpham = sanpham.ten,
        //                     mausac = loai.mausac,
        //                     hinhanh = loai.hinhanh,
        //                     kichco = kichco.kichco,
        //                     gia = chitiet.gia,
        //                     soluong = chitiet.soluong,
        //                 };
        //    List<ChiTietDonHangSanPham> dsctdh = new List<ChiTietDonHangSanPham>();
        //    foreach(object item in result)
        //    {
        //        var id = item.GetType().GetProperty("id").GetValue(item, null);
        //        var tensanpham = item.GetType().GetProperty("tensanpham").GetValue(item, null);
        //        var mausac = item.GetType().GetProperty("mausac").GetValue(item, null);
        //        var hinhanh = item.GetType().GetProperty("hinhanh").GetValue(item, null);
        //        var kichco = item.GetType().GetProperty("kichco").GetValue(item, null);
        //        var gia = item.GetType().GetProperty("gia").GetValue(item, null);
        //        var soluong = item.GetType().GetProperty("soluong").GetValue(item, null);
        //        dsctdh.Add(new ChiTietDonHangSanPham((int)id, (int)soluong, (string)tensanpham, (string)mausac, (string)hinhanh, (string)kichco, (double)gia));
        //    }
        //    return dsctdh;
        //}
        //public bool capNhat(int donhang_id, int trangthai)
        //{
        //    donhang dh = dbcontext.donhangs.FirstOrDefault(item => item.id == donhang_id);
        //    if (dh != null)
        //    {

        //        dh.trangthaidonhang = dbcontext.trangthaidonhangs.Single(d => d.id == trangthai);
        //        if(trangthai == 3)
        //        {
        //            dh.isThanhToan = true;
        //        }
        //        dbcontext.SubmitChanges();
        //        return true;
        //    }
        //    return false;
        //}
        public List<ChiTietDonHangSanPham> layChiTietDonHang(int donhang_id)
        {
            var result = from chitiet in dbcontext.chitietdonhangs
                         join kichco in dbcontext.kichcosanphams on chitiet.SanPham_id equals kichco.id
                         join loai in dbcontext.loaisanphams on kichco.LoaiSanPham_id equals loai.id
                         join sanpham in dbcontext.sanphams on loai.SanPham_id equals sanpham.id
                         where chitiet.DonHang_id == donhang_id
                         select new
                         {
                             id = chitiet.DonHang_id,
                             tensanpham = sanpham.ten,
                             mausac = loai.mausac,
                             hinhanh = loai.hinhanh,
                             kichco = kichco.kichco,
                             gia = chitiet.gia,
                             soluong = chitiet.soluong,
                         };
            List<ChiTietDonHangSanPham> dsctdh = new List<ChiTietDonHangSanPham>();
            foreach (object item in result)
            {
                var id = item.GetType().GetProperty("id").GetValue(item, null);
                var tensanpham = item.GetType().GetProperty("tensanpham").GetValue(item, null);
                var mausac = item.GetType().GetProperty("mausac").GetValue(item, null);
                var hinhanh = item.GetType().GetProperty("hinhanh").GetValue(item, null);
                var kichco = item.GetType().GetProperty("kichco").GetValue(item, null);
                var gia = item.GetType().GetProperty("gia").GetValue(item, null);
                var soluong = item.GetType().GetProperty("soluong").GetValue(item, null);
                dsctdh.Add(new ChiTietDonHangSanPham((int)id, (int)soluong, (string)tensanpham, (string)mausac, (string)hinhanh, (string)kichco, (double)gia));
            }
            return dsctdh;
        }
        public bool capNhat(int donhang_id, int trangthai)
        {
            donhang dh = dbcontext.donhangs.FirstOrDefault(item => item.id == donhang_id);
            if (dh != null)
            {
                dh.trangthaidonhang = dbcontext.trangthaidonhangs.Single(d => d.id == trangthai);
                if (trangthai == 3)
                {
                    dh.isThanhToan = true;
                    dh.ngaysua = DateTime.Now;
                }
                dbcontext.SubmitChanges();
                return true;
            }
            return false;
        }

        /*public DM_ManHinh them(DM_ManHinh dmmh)
        {
            try
            {
                dbcontext.DM_ManHinhs.InsertOnSubmit(dmmh);
                dbcontext.SubmitChanges();
                return dmmh;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool capNhat(DM_ManHinh dmmh)
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
