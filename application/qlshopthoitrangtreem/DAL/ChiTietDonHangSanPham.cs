namespace DAL
{
    public class ChiTietDonHangSanPham
    {
        public int id, soluong;
        public string tensanpham, mausac, hinhanh, kichco;
        public double gia;
        public ChiTietDonHangSanPham() { }
        public ChiTietDonHangSanPham(int id, int soluong, string tensanpham, string mausac, string hinhanh, string kichco, double gia) {
            this.id = id;
            this.soluong = soluong;
            this.tensanpham = tensanpham;
            this.mausac = mausac;
            this.hinhanh = hinhanh;
            this.kichco = kichco;
            this.gia = gia;
        }
    }
}
