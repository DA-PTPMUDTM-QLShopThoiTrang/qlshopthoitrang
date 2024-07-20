using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlshopthoitrangtreem
{
    public partial class frmThemNguoiDungNhomND : Form
    {
        public frmThemNguoiDungNhomND()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmThemNguoiDungNhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSet1.QL_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet1.QL_NhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.dataSet1.QL_NguoiDung);

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_NguoiDungNhomNguoiDungDKTableAdapter.Fill_DK(this.dataSet1.QL_NguoiDungNhomNguoiDungDK, maNhomNguoiDungToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qL_NhomNguoiDungComboBox.SelectedValue != null)
            {
                this.qL_NguoiDungNhomNguoiDungDKTableAdapter.Fill_DK(this.dataSet1.QL_NguoiDungNhomNguoiDungDK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
        }
        void loadDK()
        {
            if (qL_NhomNguoiDungComboBox.SelectedValue != null)
            {
                this.qL_NguoiDungNhomNguoiDungDKTableAdapter.Fill_DK(this.dataSet1.QL_NguoiDungNhomNguoiDungDK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = qL_NguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            string manhomnd = qL_NhomNguoiDungComboBox.SelectedValue.ToString();

            int? kt = (int)this.qL_NguoiDungNhomNguoiDungTableAdapter.kiemTraKhoa(tendangnhap, manhomnd);
            if (kt.Value > 0)
            {
                MessageBox.Show("Trung khoa");
            }
            else
            {
                this.qL_NguoiDungNhomNguoiDungTableAdapter.Insert(tendangnhap, manhomnd, "");
                this.loadDK();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tendangnhap = qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[0].Value.ToString();
            string manhomnguoidung = qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[1].Value.ToString();
            string ghichu = qL_NguoiDungNhomNguoiDungDKDataGridView.CurrentRow.Cells[2].Value.ToString();
            try
            {
                this.qL_NguoiDungNhomNguoiDungTableAdapter.Delete(tendangnhap, manhomnguoidung, ghichu);
                MessageBox.Show("Xóa thành công");
                this.loadDK();
            }catch(Exception err)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thực hiện lại!");
            }
        }
    }
}
