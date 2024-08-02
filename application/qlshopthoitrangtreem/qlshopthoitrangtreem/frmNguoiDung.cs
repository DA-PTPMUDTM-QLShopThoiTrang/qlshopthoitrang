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
    public partial class frmNguoiDung : Form
    {
        BLL_NguoiDung bllnnd = new BLL_NguoiDung();
        public frmNguoiDung()
        {
            InitializeComponent();
            this.Load += FrmManHinh_Load;
            this.btnThem.Click += btnThem_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.btnLuu.Click += btnLuu_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.btnSua.Click += btnSua_Click;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (bllnnd.suaNguoiDung(tenDangNhapTextBox.Text, matKhauTextBox.Text, hoatDongCheckBox.Checked))
                {
                    MessageBox.Show("Cập nhật thành công");
                    dataGridView1.DataSource = bllnnd.layDsMH();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (bllnnd.xoaNguoiDung(tenDangNhapTextBox.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = bllnnd.layDsMH();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                QL_NguoiDung mh = bllnnd.themNguoiDung(tenDangNhapTextBox.Text, matKhauTextBox.Text, hoatDongCheckBox.Checked);
                if (mh == null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = bllnnd.layDsMH();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tenDangNhapTextBox.Enabled = false;
                tenDangNhapTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                matKhauTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                hoatDongCheckBox.Checked = Boolean.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            }
            catch
            {
                hoatDongCheckBox.Checked = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tenDangNhapTextBox.Enabled = true;
            HelperST.removeValueTextBox(new List<TextBox> { tenDangNhapTextBox, matKhauTextBox });
            hoatDongCheckBox.Checked = false;
        }

        private void FrmManHinh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllnnd.layDsMH();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }
    }
}
