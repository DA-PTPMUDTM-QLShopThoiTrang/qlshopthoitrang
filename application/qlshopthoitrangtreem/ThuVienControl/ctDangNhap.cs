using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NguoiDung;



namespace ThuVienControl
{
    public partial class ctDangNhap: UserControl
    {
        Ql_NguoiDung Ql_NguoiDung = new Ql_NguoiDung();
        public ctDangNhap()
        {
            InitializeComponent();
        }

        public bool ktTextBox()
        {
            if (string.IsNullOrEmpty(tbtendangnhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label1.Text.ToLower());
                this.tbtendangnhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.tbmatkhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lbtendangnhap.Text.ToLower());
                this.tbmatkhau.Focus();
                return false;
            }
            return true;
        }
    }
}
