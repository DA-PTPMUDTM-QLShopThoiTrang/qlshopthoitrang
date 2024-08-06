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
    public partial class frmDanhMuc : Form
    {
        BLL_DanhMuc blldm = new BLL_DanhMuc();
        public frmDanhMuc()
        {
            InitializeComponent();
            this.btnXoa.Click += BtnXoa_Click;
            this.btnLuu.Click += BtnLuu_Click;
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.Load += FrmDanhMuc_Load;
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = blldm.layDsDM();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMaDanhMuc.Enabled = false;
            txtMaDanhMuc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenDanhMuc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (blldm.suaDanhMuc(int.Parse( txtMaDanhMuc.Text), txtTenDanhMuc.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    dataGridView1.DataSource = blldm.layDsDM();
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

        private void BtnThem_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Enabled = true;
            HelperST.removeValueTextBox(new List<TextBox> { txtMaDanhMuc, txtTenDanhMuc });
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                danhmuc mh = blldm.themDanhMuc(int.Parse(txtMaDanhMuc.Text), txtTenDanhMuc.Text);
                if (mh == null)
                {
                    MessageBox.Show("Mã màn hình đã tồn tại!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = blldm.layDsDM();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (blldm.xoaDanhMuc(int.Parse(txtMaDanhMuc.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = blldm.layDsDM();
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
    }
}
