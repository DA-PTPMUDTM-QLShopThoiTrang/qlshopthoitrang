using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using BLL;

namespace qlshopthoitrangtreem
{
    public partial class frmQLSanPham : Form
    {
        BLL_SanPham bllsp = new BLL_SanPham();
        UpLoadToFirebaseStorage firebase = new UpLoadToFirebaseStorage();
        string urlImage = string.Empty; // duong link anh sau khi da tai

        int trangHienTai = 1;
        int tongTrang = 0;

        public frmQLSanPham()
        {
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            textBox1.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private async void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ma"].Value);
                sanpham sp = bllsp.laySanPhamTheoId(productId);

                if (sp != null)
                {
                    tbMa.Text = sp.id.ToString();
                    tbten.Text = sp.ten;
                    tbgia.Text = sp.gia.ToString();
                    rtbmota.Text = sp.mota;
                    cbgioitinh.SelectedItem = sp.gioitinh;
                    cbdanhmuc.SelectedValue = sp.DanhMuc_id;
                    this.urlImage = sp.anhdaidien;
                    pbanhdaidien.Image = await firebase.LoadImageFromUrl(this.urlImage);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.xoaDlInput();
        }
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ma"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (bllsp.XoaSanPham(productId))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        this.dataGridView1.Rows.Clear();
                        await this.loadData(this.trangHienTai);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ma"].Value);
                        sanpham sp = new sanpham
                        {
                            id = productId,
                            ten = tbten.Text.Trim(),
                            gia = Double.Parse(tbgia.Text.Trim()),
                            mota = rtbmota.Text.Trim(),
                            gioitinh = cbgioitinh.SelectedItem.ToString(),
                            DanhMuc_id = int.Parse(cbdanhmuc.SelectedValue.ToString()),
                            anhdaidien = this.urlImage,
                            ngaytao = DateTime.Now
                        };

                        sanpham updatedProduct = bllsp.SuaSanPham(sp);
                        if (updatedProduct != null)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công!");
                            // Refresh the data grid view
                            this.dataGridView1.Rows.Clear();
                            await this.loadData(this.trangHienTai);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm không thành công!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                }
        }
        void xoaDlInput()
        {
            tbMa.Enabled = true;
            this.urlImage = String.Empty;
            HelperST.removeValueTextBox(new List<TextBox> { tbMa, tbgia, tbMa, tbten });
            rtbmota.Text = "";
            pbanhdaidien.Image = null;
            this.progressBar1.Value = 0;
        }
        public async Task loadData(int trang)
        {
            List<sanpham> dsSP = bllsp.layDsSP(trang);
            List<Task> tasks = new List<Task>();
            foreach (sanpham item in dsSP)
            {
                if (item.anhdaidien.Contains("https://firebasestorage.googleapis.com/v0"))
                {

                    tasks.Add(Task.Run(async () =>
                    {
                        // load anh tu url
                        Bitmap thumbnailBitmap = await firebase.LoadImageFromUrl(item.anhdaidien);

                        
                        dataGridView1.Invoke((MethodInvoker)delegate
                        {
                            dataGridView1.Rows.Add(new object[] { item.id, item.ten, item.danhmuc.ten, item.gioitinh, item.gia, item.ngaytao.ToString("dd/MM/yyyy"), item.mota, thumbnailBitmap });
                            dataGridView1.RowTemplate.Height = thumbnailBitmap.Height;
                        });
                    }));
                }
                else
                {
                    //catch
                }
            }
            await Task.WhenAll(tasks);
        }
        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(pbanhdaidien.Image != null)
                {
                    sanpham sp = bllsp.themSanPham(tbten.Text, rtbmota.Text, Double.Parse(tbgia.Text), cbgioitinh.SelectedItem.ToString(), int.Parse(cbdanhmuc.SelectedValue.ToString()), this.urlImage);
                    if (sp != null)
                    {
                        MessageBox.Show("Thêm thành công");
                        // cap nhat tong trang va load lai datagridview
                        this.trangHienTai = 1;
                        this.tongTrang = bllsp.layTongTrang();
                        this.xoaDlInput();
                        this.dataGridView1.Rows.Clear();
                        this.capNhatTBTrang();
                        this.capNhatBtnTroLai();
                        this.capNhatBtnTiep();
                        await this.loadData(this.trangHienTai);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng tải hình ảnh sản phẩm trước khi lưu!");
                }
               
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thực hiện lại!");
            }
        }

        private async void frmQLSanPham_Load(object sender, EventArgs e)
        {
            cbdanhmuc.DataSource = bllsp.layDsDanhMuc();
            cbdanhmuc.DisplayMember = "ten";
            cbdanhmuc.ValueMember = "id";
            cbgioitinh.SelectedIndex = 0;
            this.tongTrang = bllsp.layTongTrang();
            capNhatTBTrang();
            this.capNhatBtnTroLai();
            this.capNhatBtnTiep();
            await this.loadData(this.trangHienTai);
        }
            
 

        private async void btnTaiAnh_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp";
                        progressBar1.Value = 10;
                        var stream = File.Open(openFileDialog.FileName, FileMode.Open);

                        //upload image 
                        this.urlImage = await firebase.uploadImage(stream, openFileDialog.SafeFileName); 
                        Bitmap thumbnailBitmap = await firebase.LoadImageFromUrl(this.urlImage);

                        //
                        pbanhdaidien.Image = thumbnailBitmap;
                        progressBar1.Value = 100;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btntrolai_Click(object sender, EventArgs e)
        {
            this.setEnableBtn(false);
            this.trangHienTai -= 1;
            this.dataGridView1.Rows.Clear();
            this.capNhatTBTrang();
            await this.loadData(this.trangHienTai);
            this.capNhatBtnTroLai();
            this.capNhatBtnTiep();

        }
        void capNhatBtnTroLai()
        {
            if (this.trangHienTai > 1) btntrolai.Enabled = true;
            else btntrolai.Enabled = false;
        }
        void capNhatBtnTiep()
        {
            if (this.trangHienTai >= this.tongTrang) btntiep.Enabled = false;
            else btntiep.Enabled = true;
        }
        void capNhatTBTrang()
        {
            textBox1.Text = this.trangHienTai + " / " + this.tongTrang;
        }

        void setEnableBtn(bool trangthai)
        {
            this.btntiep.Enabled = trangthai;
            this.btntrolai.Enabled = trangthai;
        }

        private async void btntiep_Click(object sender, EventArgs e)
        {
            this.setEnableBtn(false);
            this.trangHienTai += 1;
            this.dataGridView1.Rows.Clear();
            this.capNhatTBTrang();
            await this.loadData(this.trangHienTai);
            this.capNhatBtnTroLai();
            this.capNhatBtnTiep();
        }

        private async void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ma"].Value);
                sanpham sp = bllsp.laySanPhamTheoId(productId);

                if (sp != null)
                {
                    tbMa.Text = sp.id.ToString();
                    tbten.Text = sp.ten;
                    tbgia.Text = sp.gia.ToString();
                    rtbmota.Text = sp.mota;
                    cbgioitinh.SelectedItem = sp.gioitinh;
                    cbdanhmuc.SelectedValue = sp.DanhMuc_id;
                    this.urlImage = sp.anhdaidien;
                    pbanhdaidien.Image = await firebase.LoadImageFromUrl(this.urlImage);
                }
            }
        }

       
    }
}
