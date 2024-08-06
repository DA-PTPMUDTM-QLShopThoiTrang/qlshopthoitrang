using System.Windows.Forms;
namespace ThuVienControl
{
    public partial class ctDangNhap : UserControl
    {
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
