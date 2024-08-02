using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using static BLL.LoginResultEnum;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace BLL
{
    public class BLL_NguoiDung
    {
        DAL_NguoiDung dll_nd = new DAL_NguoiDung();
       
        private string cnn;
        public string Cnn { get => cnn; set => cnn = value; }

        public int Check_Config()
        {
            if (cnn == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(cnn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public LoginResult Check_User(string pUser, string pPass)
        {
            QL_NguoiDung nd = dll_nd.layNguoiDung(pUser, pPass);
            if (nd == null)
                return LoginResult.Invalid;// User không tồn tại
            else if (nd.HoatDong == false)
            {
                return LoginResult.Disabled;// Không hoạt động
            }
            return LoginResult.Success;// Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable dt = instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source = " + pServer + "; Initial Catalog = master; User ID = " + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }
        /*public List<string> GetMaNhomNguoiDung(string _TenDangNhap)
        {
            List<string> dsmanhom = new List<string>();
            DataTable dt = new DataTable();
            string query = "select QL_NhomNguoiDung.* " +
            "from QL_NhomNguoiDung inner join QL_NguoiDungNhomNguoiDung on " +
            "QL_NguoiDungNhomNguoiDung.MaNhomNguoiDung = QL_NhomNguoiDung.MaNhom " +
            "where QL_NguoiDungNhomNguoiDung.TenDangNhap = '" + _TenDangNhap + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, this.cnn);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                dsmanhom.Add(row["MaNhom"].ToString());
            }
            return dsmanhom;
        }*/

        /*public DataTable GetMaManHinh(string MaNhom)
        {
            var result = dbcontext.DM_ManHinhs
     .Join(dbcontext.QL_PhanQuyens,
         manHinh => manHinh.MaManHinh,
         phanQuyen => phanQuyen.MaManHinh,
         (manHinh, phanQuyen) => new { ManHinh = manHinh, PhanQuyen = phanQuyen })
     .Where(joinResult => joinResult.PhanQuyen.MaNhomNguoiDung == "N001"
                          && joinResult.PhanQuyen.CoQuyen == 1)
     .Select(joinResult => new {
         joinResult.ManHinh,
         joinResult.PhanQuyen.CoQuyen
     })
     .ToList();
            return dt;
        }*/
        public List<QL_NguoiDung> layDsMH()
        {
            return dll_nd.layDsNguoiDung();
        }
        public QL_NguoiDung themNguoiDung(string tendangnhap, string matkhau, bool hoatdong)
        {
            if (dll_nd.layNhomNguoiByMa(tendangnhap) == null)
            {
                QL_NguoiDung mh = new QL_NguoiDung();
                mh.TenDangNhap = tendangnhap;
                mh.MatKhau = matkhau;
                mh.HoatDong = hoatdong;
                return dll_nd.them(mh);
            }
            return null;
        }
        public bool xoaNguoiDung(string ma)
        {
            return dll_nd.xoa(ma);
        }
        public bool suaNguoiDung(string tendangnhap, string matkhau, bool hoatdong)
        {
            QL_NguoiDung mh = new QL_NguoiDung();
            mh.TenDangNhap = tendangnhap;
            mh.MatKhau = matkhau;
            mh.HoatDong = hoatdong;
            return dll_nd.capNhat(mh);
        }
    }
}
