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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.dataSet1.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'dataSet1.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet1.QL_NhomNguoiDung);

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_PhanQuyen_DKTableAdapter.Fill_DK(this.dataSet1.QL_PhanQuyen_DK, maNhomNguoiDungToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void LoadDataCondition()
        {
            this.qL_PhanQuyen_DKTableAdapter.Fill_DK(this.dataSet1.QL_PhanQuyen_DK,
            qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString());
        }
        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.LoadDataCondition();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _NhomNguoiDung = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            try
            {
                foreach (DataGridViewRow item in qL_PhanQuyen_DKDataGridView.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        if
                        (qL_PhanQuyen_DKTableAdapter.KiemTraKhoaChinhPhanQuyen(_NhomNguoiDung, item.Cells[0].Value
                        .ToString()) == null)
                        {
                            try
                            {
                                qL_PhanQuyenTableAdapter.Insert(_NhomNguoiDung,
                                item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                            }
                            catch
                            {
                                qL_PhanQuyenTableAdapter.Insert(_NhomNguoiDung,
                                item.Cells[0].Value.ToString(), false);
                            }
                        }
                        else
                        {
                            qL_PhanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false
                           : (bool)(item.Cells[2].Value), _NhomNguoiDung, item.Cells[0].Value.ToString());
                        }
                    }
                }
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception err)
            {

            }
        }
    
    }
}
