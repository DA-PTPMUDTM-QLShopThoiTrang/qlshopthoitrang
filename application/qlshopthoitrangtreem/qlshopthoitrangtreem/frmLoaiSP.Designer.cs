﻿namespace qlshopthoitrangtreem
{
    partial class frmLoaiSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbanhdaidien = new System.Windows.Forms.PictureBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanhdaidien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mausac,
            this.sanpham,
            this.hinhanh});
            this.dataGridView1.Location = new System.Drawing.Point(214, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(828, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 78.53403F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // mausac
            // 
            this.mausac.FillWeight = 94.77197F;
            this.mausac.HeaderText = "Màu sắc";
            this.mausac.MinimumWidth = 8;
            this.mausac.Name = "mausac";
            // 
            // sanpham
            // 
            this.sanpham.FillWeight = 108.4251F;
            this.sanpham.HeaderText = "Sản phẩm";
            this.sanpham.MinimumWidth = 8;
            this.sanpham.Name = "sanpham";
            // 
            // hinhanh
            // 
            this.hinhanh.FillWeight = 118.2689F;
            this.hinhanh.HeaderText = "Hình ";
            this.hinhanh.MinimumWidth = 8;
            this.hinhanh.Name = "hinhanh";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(118, 222);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(118, 261);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(118, 306);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(414, 168);
            this.cboSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(123, 24);
            this.cboSP.TabIndex = 4;
            this.cboSP.SelectedIndexChanged += new System.EventHandler(this.cboSP_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(413, 53);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 22);
            this.txtID.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(917, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(917, 38);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(100, 34);
            this.btnTaiAnh.TabIndex = 24;
            this.btnTaiAnh.Text = "Tải ảnh";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hình ảnh";
            // 
            // pbanhdaidien
            // 
            this.pbanhdaidien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbanhdaidien.Location = new System.Drawing.Point(744, 38);
            this.pbanhdaidien.Name = "pbanhdaidien";
            this.pbanhdaidien.Size = new System.Drawing.Size(110, 115);
            this.pbanhdaidien.TabIndex = 22;
            this.pbanhdaidien.TabStop = false;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(414, 111);
            this.txtMau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(123, 22);
            this.txtMau.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Màu sắc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sản phẩm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(589, 158);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 33);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(118, 346);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 38);
            this.btnLoad.TabIndex = 31;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 524);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbanhdaidien);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboSP);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoaiSP";
            this.Text = "frmLoaiSP";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanhdaidien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbanhdaidien;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mausac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
        private System.Windows.Forms.Button btnLoad;
    }
}