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
    public partial class frmKichCo : Form
    {
        BLL_SanPham bll = new BLL_SanPham();
        public frmKichCo()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            txtID.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xoaDlInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int sizeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (bll.xoaKichCo(sizeId))
                    {
                        MessageBox.Show("Xóa thành công!");
                        this.dataGridView1.Rows.Clear();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kích cỡ để xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int sizeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    string kichco = txtKichCo.Text.Trim();
                    if (string.IsNullOrEmpty(kichco))
                    {
                        MessageBox.Show("Kích cỡ không được để trống.");
                        return;
                    }

                    if (!int.TryParse(txtSoLuong.Text.Trim(), out int soluong))
                    {
                        MessageBox.Show("Số lượng phải là một số hợp lệ.");
                        return;
                    }

                    if (cboSP.SelectedValue == null || !int.TryParse(cboSP.SelectedValue.ToString(), out int sanPhamId))
                    {
                        MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ.");
                        return;
                    }

                    if (cboLoai.SelectedValue == null || !int.TryParse(cboLoai.SelectedValue.ToString(), out int loaiId))
                    {
                        MessageBox.Show("Vui lòng chọn loại sản phẩm hợp lệ.");
                        return;
                    }
                    kichcosanpham k = new kichcosanpham
                    {
                        id = sizeId,
                        kichco = kichco,
                        soluong = soluong,
                        SanPham_id = sanPhamId,
                        LoaiSanPham_id = loaiId,
                    };
                    kichcosanpham updatedSize = bll.suaKichCo(k);
                    if (updatedSize != null)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        dataGridView1.Rows.Clear();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kích cỡ để sửa!");
            }
        }

        private void frmKichCo_Load(object sender, EventArgs e)
        {
            loadData();
           
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int sizeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                kichcosanpham k = bll.layKichCoTheoID (sizeId);

                if (k != null)
                {
                    txtID.Text = k.id.ToString();
                    txtKichCo.Text = k.kichco;
                    txtSoLuong.Text = k.soluong.ToString();
                    cboSP.SelectedValue = k.SanPham_id;
                    cboLoai.SelectedValue = k.LoaiSanPham_id;
                }
            }
        }

        public void loadData()
        {
            cboLoai.DataSource = bll.loadLoaiSP();
            cboLoai.DisplayMember = "mausac";
            cboLoai.ValueMember = "id";
            cboSP.DataSource = bll.layDsSP();
            cboSP.DisplayMember = "ten";
            cboSP.ValueMember = "id";
            List<kichcosanpham> dsSP = bll.loadKichCo();
            foreach (kichcosanpham item in dsSP)
            {
                var sanPham = bll.layDsSP().FirstOrDefault(sp => sp.id == item.SanPham_id);
                var loaiSP = bll.loadLoaiSP().FirstOrDefault(l => l.id == item.LoaiSanPham_id);

                string sanPhamName = sanPham != null ? sanPham.ten : "Unknown";
                string loaiSPName = loaiSP != null ? loaiSP.mausac : "Unknown";

                dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.Rows.Add(new object[] { item.id, item.kichco, item.soluong, sanPhamName,loaiSPName }); ;
                });
            }
        }
        void xoaDlInput()
        {
            txtID.Enabled = false;
            HelperST.removeValueTextBox(new List<TextBox> { txtID, txtKichCo, txtSoLuong });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure ComboBox values are retrieved correctly
                int sanPhamId = Convert.ToInt32(cboSP.SelectedValue);
                int loaiId = Convert.ToInt32(cboLoai.SelectedValue);
                string kichco = txtKichCo.Text.Trim();
                int soluong = int.Parse(txtSoLuong.Text.Trim());

                // Validate inputs
                if (string.IsNullOrEmpty(kichco) || soluong <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra lại dữ liệu.");
                    return;
                }

                // Call BLL method to add new record
                kichcosanpham k = bll.themKichCo(kichco, soluong, sanPhamId, loaiId);

                if (k != null)
                {
                    MessageBox.Show("Thêm thành công");
                    xoaDlInput();  // Clear the input fields
                    dataGridView1.Rows.Clear();  // Clear the DataGridView
                    loadData();  // Reload the data
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {err.Message}");
            }
        }
        private void loadLoaiForSelectedProduct()
        {
            if (cboSP.SelectedValue != null && int.TryParse(cboSP.SelectedValue.ToString(), out int sanPhamId))
            {
                var loaiList = bll.loadLoaiSP().Where(l => l.SanPham_id == sanPhamId).ToList();
                cboLoai.DataSource = loaiList;
                cboLoai.DisplayMember = "mausac";
                cboLoai.ValueMember = "id";
            }
        }
        private void loadDataForSelectedType()
        {
            if (cboLoai.SelectedValue != null && int.TryParse(cboLoai.SelectedValue.ToString(), out int loaiId))
            {
                dataGridView1.Rows.Clear();
                List<kichcosanpham> dsSP = bll.loadKichCo().Where(k => k.LoaiSanPham_id == loaiId).ToList();
                foreach (kichcosanpham item in dsSP)
                {
                    var sanPham = bll.layDsSP().FirstOrDefault(sp => sp.id == item.SanPham_id);
                    var loaiSP = bll.loadLoaiSP().FirstOrDefault(l => l.id == item.LoaiSanPham_id);

                    string sanPhamName = sanPham != null ? sanPham.ten : "Unknown";
                    string loaiSPName = loaiSP != null ? loaiSP.mausac : "Unknown";

                    dataGridView1.Invoke((MethodInvoker)delegate
                    {
                        dataGridView1.Rows.Add(new object[] { item.id, item.kichco, item.soluong, sanPhamName, loaiSPName });
                    });
                }
            }
        }
        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLoaiForSelectedProduct();
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataForSelectedType();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
