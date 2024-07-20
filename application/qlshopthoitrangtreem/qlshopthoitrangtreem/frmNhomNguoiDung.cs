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
    public partial class frmNhomNguoiDung : Form
    {
        public frmNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet1.QL_NhomNguoiDung);

        }
    }
}
