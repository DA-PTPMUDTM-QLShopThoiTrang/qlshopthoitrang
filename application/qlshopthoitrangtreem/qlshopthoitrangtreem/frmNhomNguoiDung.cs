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
    public partial class frmNhomNguoiDung : Form
    {
        BLL_NhomNguoiDung bllnnd = new BLL_NhomNguoiDung();
        public frmNhomNguoiDung()
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
                if (bllnnd.suaNhomNguoiDung(maNhomTextBox.Text, tenNhomTextBox.Text, ghiChuTextBox.Text))
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
                    if (bllnnd.xoaNhomNguoiDung(maNhomTextBox.Text))
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
                QL_NhomNguoiDung mh = bllnnd.themNhomNguoiDung(maNhomTextBox.Text, tenNhomTextBox.Text, ghiChuTextBox.Text);
                if (mh == null)
                {
                    MessageBox.Show("Mã nhóm người dùng đã tồn tại!");
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
                maNhomTextBox.Enabled = false;
                maNhomTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tenNhomTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ghiChuTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                ghiChuTextBox.Text = "";

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maNhomTextBox.Enabled = true;
            HelperST.removeValueTextBox(new List<TextBox> { maNhomTextBox, tenNhomTextBox, ghiChuTextBox});
        }

        private void FrmManHinh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllnnd.layDsMH();
        }
    }
}
