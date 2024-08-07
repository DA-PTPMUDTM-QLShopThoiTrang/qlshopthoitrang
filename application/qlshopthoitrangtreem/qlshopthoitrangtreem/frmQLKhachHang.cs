using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace qlshopthoitrangtreem
{
    public partial class frmQLKhachHang : Form
    {
        BLL_KhachHang bllkh = new BLL_KhachHang();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKH.MultiSelect = false;
            dgvKH.DataSource = bllkh.layDSKH();
            BindData();
        }
        private void BindData()
        {
            txtTen.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();

            txtTen.DataBindings.Add("Text", dgvKH.DataSource, "ten");
            txtEmail.DataBindings.Add("Text", dgvKH.DataSource, "email");
            txtSDT.DataBindings.Add("Text", dgvKH.DataSource, "sdt");
            txtMatKhau.DataBindings.Add("Text", dgvKH.DataSource, "matkhau");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                await TimKiemKhachHang(keyword);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
            }
        }
        private async Task TimKiemKhachHang(string tk)
        {
            try
            {
                List<khachhang> dsKhachHang = bllkh.TimKiemKH(tk);
                if (dsKhachHang != null && dsKhachHang.Count > 0)
                {
                    dgvKH.DataSource = null;
                    dgvKH.DataSource = dsKhachHang;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKH.SelectedRows[0].Cells["id"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (bllkh.XoaKhachHang(id))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        dgvKH.DataSource = bllkh.layDSKH();
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvKH.SelectedRows[0].Cells["id"].Value);
                    string hashedPassword = HelperST.HashPassword(txtMatKhau.Text.Trim());
                    khachhang kh = new khachhang
                    {
                        id = id,
                        ten = txtTen.Text.Trim(),
                        email = txtEmail.Text.Trim(),
                        sdt = txtSDT.Text.Trim(),
                        matkhau = hashedPassword
                    };

                    if (bllkh.SuaKhachHang(kh))
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                        dgvKH.DataSource = bllkh.layDSKH();
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!HelperST.IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ. Vui lòng nhập lại.");
                txtEmail.Focus(); // Đặt lại tiêu điểm để người dùng sửa
            }
        }
    }
}
