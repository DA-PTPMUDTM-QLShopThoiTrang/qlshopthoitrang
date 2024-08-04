﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlshopthoitrangtreem
{
    public partial class frmLoaiSP : Form
    {
        BLL_SanPham bllsp = new BLL_SanPham();
        UpLoadToFirebaseStorage firebase = new UpLoadToFirebaseStorage();
        string urlImage = string.Empty;
        public frmLoaiSP()
        {
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            txtID.Enabled = false;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private async void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                loaisanpham l = bllsp.layLoaiTheoId(productId);

                if (l != null)
                {
                    txtID.Text = l.id.ToString();
                    txtMau.Text = l.mausac;
                    cboSP.SelectedItem = l.sanpham;
                    this.urlImage = l.hinhanh;
                    pbanhdaidien.Image = await firebase.LoadImageFromUrl(this.urlImage);
                }
            }
        }

        private async void frmLoaiSP_Load(object sender, EventArgs e)
        {
            cboSP.DataSource = bllsp.layDsSP();
            cboSP.DisplayMember = "ten";
            cboSP.ValueMember = "id";
            await this.loadData();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.xoaDlInput();
        }
        void xoaDlInput()
        {
            txtID.Enabled = true;
            this.urlImage = String.Empty;
            txtID.Text = "";
            txtMau.Text = "";
            pbanhdaidien.Image = null;
            this.progressBar1.Value = 0;
        }
        public async Task loadData()
        {
            List<loaisanpham> dsSP = bllsp.loadLoaiSP();
            List<Task> tasks = new List<Task>();
            foreach (loaisanpham item in dsSP)
            {
                if (item.hinhanh.Contains("https://firebasestorage.googleapis.com/v0"))
                {

                    tasks.Add(Task.Run(async () =>
                    {
                        // load anh tu url
                        Bitmap thumbnailBitmap = await firebase.LoadImageFromUrl(item.hinhanh);


                        dataGridView1.Invoke((MethodInvoker)delegate
                        {
                            dataGridView1.Rows.Add(new object[] { item.id, item.mausac, item.sanpham.ten, thumbnailBitmap });
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbanhdaidien.Image != null)
                {
                    string mausac = txtMau.Text;
                    int sanpham_id = int.Parse(cboSP.SelectedValue.ToString()); 
                    string anhdaidien = this.urlImage;
                    loaisanpham l = bllsp.themLoai(mausac, sanpham_id, anhdaidien);

                    if (l != null)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.xoaDlInput();
                        this.dataGridView1.Rows.Clear();
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
                MessageBox.Show($"Đã xảy ra lỗi: {err.Message}");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    loaisanpham l = new loaisanpham
                    {
                        id = productId,
                        mausac = txtMau.Text.Trim(),
                        hinhanh = this.urlImage,
                        SanPham_id = int.Parse(cboSP.SelectedValue.ToString()),
                    };
                    loaisanpham updatedProduct = bllsp.SuaLoai(l);
                    if (updatedProduct != null)
                    {
                        MessageBox.Show("Cập nhật loại thành công!");
                        this.dataGridView1.Rows.Clear();
                        await this.loadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại để sửa!");
            }
        }
    }
}
