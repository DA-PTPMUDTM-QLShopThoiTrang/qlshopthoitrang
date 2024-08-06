using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using static DAL.DAL_ThongKe;

namespace BLL
{
    public class BLL_ThongKe
    {
        public DAL_ThongKe dalThongKe;

        public BLL_ThongKe()
        {
            dalThongKe = new DAL_ThongKe();
        }

        public List<DoanhThuTheoNgay>LayDoanhThu (DateTime ngayBD, DateTime ngayKT)
        {
            return dalThongKe.LayDoanhThu(ngayBD, ngayKT);
        }

        public List<SanPhamBanChay> LaySanPhamBanChay(DateTime ngayBD, DateTime ngayKT)
        {
            return dalThongKe.LaySanPhamBanChay(ngayBD, ngayKT);
        }
    }
}
