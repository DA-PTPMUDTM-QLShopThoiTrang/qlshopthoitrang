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
    public partial class frmPhanQuyen : Form
    {
        BLL_NhomNguoiDung bllnnd = new BLL_NhomNguoiDung();
        BLL_QLPhanQuyen bllpq = new BLL_QLPhanQuyen();
        public frmPhanQuyen()
        {
            InitializeComponent();
            this.Load += FrmPhanQuyen_Load;
            qL_NhomNguoiDungDataGridView.SelectionChanged += QL_NhomNguoiDungDataGridView_SelectionChanged;
        }

        private void QL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // load
            dataGridView1.Rows.Clear();
            string manhom = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            List<NhomNguoiDungManHinh> nhomNguoiDungManHinhs = bllpq.layNNDMH(manhom);
            foreach(NhomNguoiDungManHinh item in nhomNguoiDungManHinhs)
            {
                dataGridView1.Rows.Add(new object[] { item.MaManHinh, item.TenManHinh, item.CoQuyen});
            }
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            List<QL_NhomNguoiDung> nhomNguoiDungManHinhs = bllnnd.layDsMH();

            qL_NhomNguoiDungDataGridView.DataSource = nhomNguoiDungManHinhs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNhom = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        if
                        (bllpq.layNhomNguoiDungManHinhbyMa(maNhom, item.Cells[0].Value
                        .ToString()) == null)
                        {
                            try
                            {
                                bllpq.themNhomNguoiDungManHinh(maNhom,
                                item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                            }
                            catch
                            {
                                bllpq.themNhomNguoiDungManHinh(maNhom,
                                item.Cells[0].Value.ToString(), false);
                            }
                        }
                        else
                        {
                            bllpq.suaNhomNguoiDungManHinh(maNhom, item.Cells[0].Value.ToString(), (item.Cells[2] == null) ? false
                           : (bool)(item.Cells[2].Value));
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
