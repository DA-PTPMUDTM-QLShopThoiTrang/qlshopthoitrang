using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKe
    {
        DBDataContext dbcontext = new DBDataContext();
        public List<sanpham> layDsSanPham()
        {
            return dbcontext.sanphams.OrderByDescending(item => item.ngaytao).ToList<sanpham>();
        }
        //public List<donhang> layDsDonHang()
        //{
        //    return dbcontext.donhangs.OrderByDescending(item => item.ngaytao).ToList<donhang>();
        //}
        public List<chitietdonhang> layDsChiTetDonHang()
        {
            return dbcontext.chitietdonhangs.Select(item => item).ToList<chitietdonhang>();
        }


        public class SanPhamBanChay
        {
            public int MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public int TongSoLuongBan { get; set; }
        }
        public class DoanhThuTheoNgay
        {
            public DateTime NgayXuatHoaDon { get; set; }
            public double DoanhThu { get; set; }
        }
        public List<DoanhThuTheoNgay> LayDoanhThu(DateTime ngayBD, DateTime ngayKT)
        {
            var result = from dh in dbcontext.donhangs
                         where dh.ngaytao >= ngayBD && dh.ngaytao <= ngayKT
                         group dh by dh.ngaytao.Value.Date into g
                         select new DoanhThuTheoNgay
                         {
                             NgayXuatHoaDon = g.Key,
                             DoanhThu = g.Sum(x => x.tongtien)
                         };
            return result.ToList();
        }

        public List<donhang> ThongKeDonHang(DateTime ngayBD, DateTime ngayKT)
        {
            // Truy vấn các đơn hàng trong khoảng thời gian từ ngayBD đến ngayKT
            var result = from donhang in dbcontext.donhangs
                         where donhang.ngaytao >= ngayBD && donhang.ngaytao < ngayKT.AddDays(1)
                         select donhang;

            return result.ToList();
        }


        // Lấy sản phẩm bán chạy trong khoảng thời gian
        public List<SanPhamBanChay> LaySanPhamBanChay(DateTime ngayBD, DateTime ngayKT)
        {
            var result = from ctdh in dbcontext.chitietdonhangs
                         join dh in dbcontext.donhangs on ctdh.DonHang_id equals dh.id
                         join sp in dbcontext.sanphams on ctdh.SanPham_id equals sp.id
                         where dh.ngaytao >= ngayBD && dh.ngaytao <= ngayKT
                         group ctdh by new { sp.id, sp.ten } into g
                         select new SanPhamBanChay
                         {
                             MaSanPham = g.Key.id,
                             TenSanPham = g.Key.ten,
                             TongSoLuongBan = g.Sum(x => x.soluong)
                         };
            return result.OrderByDescending(x => x.TongSoLuongBan).ToList();
        }
    }
}
