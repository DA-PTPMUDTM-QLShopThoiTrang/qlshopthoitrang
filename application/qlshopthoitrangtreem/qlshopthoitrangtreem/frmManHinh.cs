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
    public partial class frmManHinh : Form
    {
        BLL_ManHinh bllmh = new BLL_ManHinh();
        public frmManHinh()
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
                if (bllmh.suaManHinh(maManHinhTextBox.Text, tenManHinhTextBox.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    dataGridView1.DataSource = bllmh.layDsMH();
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
                    if (bllmh.xoaManHinh(maManHinhTextBox.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = bllmh.layDsMH();
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
                DM_ManHinh mh = bllmh.themManHinh(maManHinhTextBox.Text, tenManHinhTextBox.Text);
                if (mh == null)
                {
                    MessageBox.Show("Mã màn hình đã tồn tại!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = bllmh.layDsMH();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            maManHinhTextBox.Enabled = false;
            maManHinhTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tenManHinhTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maManHinhTextBox.Enabled = true;
            HelperST.removeValueTextBox(new List<TextBox> { maManHinhTextBox, tenManHinhTextBox });
        }

        private void FrmManHinh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllmh.layDsMH();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
