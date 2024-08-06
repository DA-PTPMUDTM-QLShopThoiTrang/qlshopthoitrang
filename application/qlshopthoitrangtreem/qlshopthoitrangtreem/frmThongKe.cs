using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using static DAL.DAL_ThongKe;

namespace qlshopthoitrangtreem
{
    public partial class frmThongKe : Form
    {
        BLL_ThongKe blltk = new BLL_ThongKe();
        public frmThongKe()
        {
            InitializeComponent();
            this.btnThongKe.Click += BtnThongKe_Click;
            this.btnSPCaoNhat.Click += BtnSPCaoNhat_Click;
        }

        private void BtnSPCaoNhat_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBD = dateTimePicker1.Value; // Lấy giá trị ngày bắt đầu từ DateTimePicker
                DateTime ngayKT = dateTimePicker2.Value; // Lấy giá trị ngày kết thúc từ DateTimePicker
                List<SanPhamBanChay> dt = blltk.LaySanPhamBanChay(ngayBD, ngayKT);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBD = dateTimePicker1.Value; // Lấy giá trị ngày bắt đầu từ DateTimePicker
                DateTime ngayKT = dateTimePicker2.Value; // Lấy giá trị ngày kết thúc từ DateTimePicker
                List<DoanhThuTheoNgay> dt = blltk.LayDoanhThu(ngayBD, ngayKT);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
