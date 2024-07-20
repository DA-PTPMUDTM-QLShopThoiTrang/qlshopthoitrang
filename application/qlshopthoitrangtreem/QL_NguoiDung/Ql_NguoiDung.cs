using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static QL_NguoiDung.LoginResultEnum;
using System.Data;
using System.Data.Sql;

namespace QL_NguoiDung
{
    public class Ql_NguoiDung
    {
        private string cnn;


        public Ql_NguoiDung() { }
        
        public string Cnn { get => cnn; set => cnn = value; }

        public int Check_Config()
        {
            /*Properties.Settings.Default.cnn*/
            if (cnn == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            /*Properties.Settings.Default.cnn*/
            SqlConnection _Sqlconn = new SqlConnection(cnn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap = '" + pUser + "' and MatKhau = '" + pPass + "'", cnn); // Properties.Settings.Default.cnn
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() ==
            "False")
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
        public List<string> GetMaNhomNguoiDung(string _TenDangNhap)
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
        }

        public DataTable GetMaManHinh(string MaNhom)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DM_ManHinh.*, QL_PhanQuyen.CoQuyen from DM_ManHinh " +
            "inner join QL_PhanQuyen on QL_PhanQuyen.MaManHinh = DM_ManHinh.MaManHinh " +
            "where QL_PhanQuyen.MaNhomNguoiDung = '"+ MaNhom + "' and QL_PhanQuyen.CoQuyen = 1", 
            this.cnn);
            da.Fill(dt);
            return dt;
        }

        /*public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            _2001216321_NguyenTanTruongVu_Buoi6.Properties.Settings.Default.cnn = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            _2001216321_NguyenTanTruongVu_Buoi6.Properties.Settings.Default.Save();
        }*/
    }
}
