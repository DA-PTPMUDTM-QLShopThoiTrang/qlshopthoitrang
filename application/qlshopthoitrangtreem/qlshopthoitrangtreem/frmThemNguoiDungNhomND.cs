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
    public partial class frmThemNguoiDungNhomND : Form
    {
        BLL_NguoiDung bllnd = new BLL_NguoiDung();
        BLL_NhomNguoiDung bllnnd = new BLL_NhomNguoiDung();
        BLL_NguoiDungNhomNguoiDung bllndnnd = new BLL_NguoiDungNhomNguoiDung();
        public frmThemNguoiDungNhomND()
        {
            InitializeComponent();
            this.Load += FrmThemNguoiDungNhomND_Load;
            qL_NhomNguoiDungComboBox.SelectedIndexChanged += QL_NhomNguoiDungComboBox_DropDown;
        }

        private void QL_NhomNguoiDungComboBox_DropDown(object sender, EventArgs e)
        {
            qL_NguoiDungNhomNguoiDungDKDataGridView.DataSource = bllndnnd.layDsByMa(qL_NhomNguoiDungComboBox.SelectedValue.ToString());
        }

        private void FrmThemNguoiDungNhomND_Load(object sender, EventArgs e)
        {
            qL_NguoiDungDataGridView.DataSource = bllnd.layDsMH();

            qL_NhomNguoiDungComboBox.DataSource = bllnnd.layDsMH();
            qL_NhomNguoiDungComboBox.DisplayMember = "TenNhom";
            qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mand = qL_NguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
                string mannd = qL_NhomNguoiDungComboBox.SelectedValue.ToString();
                QL_NguoiDungNhomNguoiDung mh = bllndnnd.themNguoiDungNhomNguoiDung(mannd, mand, "");
                if (mh == null)
                {
                    MessageBox.Show("Người dùng này đã được thêm!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    qL_NguoiDungNhomNguoiDungDKDataGridView.DataSource = bllndnnd.layDsByMa(qL_NhomNguoiDungComboBox.SelectedValue.ToString());
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string temdangnhap = qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[0].Value.ToString();
                    string mannd = qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[1].Value.ToString();
                    if (bllndnnd.xoaNguoiDungNhomNguoiDung(mannd, temdangnhap))
                    {
                        MessageBox.Show("Xóa thành công");
                        qL_NguoiDungNhomNguoiDungDKDataGridView.DataSource = bllndnnd.layDsByMa(qL_NhomNguoiDungComboBox.SelectedValue.ToString());
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
