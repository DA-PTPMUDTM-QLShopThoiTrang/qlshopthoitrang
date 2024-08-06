
namespace qlshopthoitrangtreem
{
    partial class frmThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboThongKe = new System.Windows.Forms.ComboBox();
            this.btnExportDonHang = new System.Windows.Forms.Button();
            this.btnExportNguoiDung = new System.Windows.Forms.Button();
            this.btnExportSanPham = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NgayBD = new System.Windows.Forms.Label();
            this.btnSPCaoNhat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboThongKe);
            this.panel1.Controls.Add(this.btnExportDonHang);
            this.panel1.Controls.Add(this.btnExportNguoiDung);
            this.panel1.Controls.Add(this.btnExportSanPham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NgayBD);
            this.panel1.Controls.Add(this.btnSPCaoNhat);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 445);
            this.panel1.TabIndex = 0;
            // 
            // cboThongKe
            // 
            this.cboThongKe.FormattingEnabled = true;
            this.cboThongKe.Items.AddRange(new object[] {
            "Danh sách sản phẩm",
            "Danh sách người dùng",
            "Đơn hàng"});
            this.cboThongKe.Location = new System.Drawing.Point(816, 39);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Size = new System.Drawing.Size(182, 28);
            this.cboThongKe.TabIndex = 10;
            // 
            // btnExportDonHang
            // 
            this.btnExportDonHang.Location = new System.Drawing.Point(1052, 168);
            this.btnExportDonHang.Name = "btnExportDonHang";
            this.btnExportDonHang.Size = new System.Drawing.Size(92, 54);
            this.btnExportDonHang.TabIndex = 9;
            this.btnExportDonHang.Text = "Xuất Đơn hàng";
            this.btnExportDonHang.UseVisualStyleBackColor = true;
            // 
            // btnExportNguoiDung
            // 
            this.btnExportNguoiDung.Location = new System.Drawing.Point(859, 182);
            this.btnExportNguoiDung.Name = "btnExportNguoiDung";
            this.btnExportNguoiDung.Size = new System.Drawing.Size(139, 40);
            this.btnExportNguoiDung.TabIndex = 8;
            this.btnExportNguoiDung.Text = "Xuất khách hàng";
            this.btnExportNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btnExportSanPham
            // 
            this.btnExportSanPham.Location = new System.Drawing.Point(604, 168);
            this.btnExportSanPham.Name = "btnExportSanPham";
            this.btnExportSanPham.Size = new System.Drawing.Size(110, 54);
            this.btnExportSanPham.TabIndex = 7;
            this.btnExportSanPham.Text = "Xuất sản phẩm";
            this.btnExportSanPham.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày Kết Thúc";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSize = true;
            this.NgayBD.Location = new System.Drawing.Point(25, 47);
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Size = new System.Drawing.Size(108, 20);
            this.NgayBD.TabIndex = 5;
            this.NgayBD.Text = "Ngày Bắt Đầu";
            // 
            // btnSPCaoNhat
            // 
            this.btnSPCaoNhat.Location = new System.Drawing.Point(388, 168);
            this.btnSPCaoNhat.Name = "btnSPCaoNhat";
            this.btnSPCaoNhat.Size = new System.Drawing.Size(125, 54);
            this.btnSPCaoNhat.TabIndex = 4;
            this.btnSPCaoNhat.Text = "Xem sản phẩm bán chạy";
            this.btnSPCaoNhat.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(155, 168);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(126, 54);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê Doanh Thu";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(155, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Xuất báo cáo";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NgayBD;
        private System.Windows.Forms.Button btnSPCaoNhat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboThongKe;
        private System.Windows.Forms.Button btnExportDonHang;
        private System.Windows.Forms.Button btnExportNguoiDung;
        private System.Windows.Forms.Button btnExportSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}