using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NguoiDung;
using static QL_NguoiDung.LoginResultEnum;

namespace qlshopthoitrangtreem
{
    public partial class frmDangNhap : Form
    {
        Ql_NguoiDung qlnguoidung = new Ql_NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
            qlnguoidung.Cnn = Properties.Settings.Default.cnn;
            this.ctDangNhap1.btndangnhap.Click += Btndangnhap_Click;
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            bool kt = this.ctDangNhap1.ktTextBox();
            if (kt)
            {
                int kq = qlnguoidung.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
                if (kq == 0)
                {
                    ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
                }
                if (kq == 1)
                {
                    MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                    ProcessConfig();
                }
                if (kq == 2)
                {
                    MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                    ProcessConfig();
                }
            }
        }
        public void ProcessLogin()
        {
            LoginResult result;
            result = qlnguoidung.Check_User(this.ctDangNhap1.tbtendangnhap.Text, this.ctDangNhap1.tbmatkhau.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + this.ctDangNhap1.lbtendangnhap.Text + " Hoặc " + this.ctDangNhap1.lbmatkhau.Text);
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain(this.ctDangNhap1.tbtendangnhap.Text);
            }
            this.Visible = false;
            Program.mainForm.ShowDialog();
            this.Close();
        }
        public void ProcessConfig()
        {
            this.hienFrmCauHinh();
        }

        void hienFrmCauHinh()
        {
            frmCauHinh form = new frmCauHinh();
            this.Visible = true;
            form.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.hienFrmCauHinh();
        }

      
    }
}
