using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using DAL;
using BLL;

using static DAL.DAL_ThongKe;
using GUI;

namespace qlshopthoitrangtreem
{
    public partial class frmThongKe : Form
    {
        BLL_ThongKe blltk = new BLL_ThongKe();
        BLL_SanPham bllsp = new BLL_SanPham();
        BLL_DonHang blldh = new BLL_DonHang();
        BLL_KhachHang bllkh = new BLL_KhachHang();
        UpLoadToFirebaseStorage firebase = new UpLoadToFirebaseStorage();
        public frmThongKe()
        {
            InitializeComponent();
            this.btnThongKe.Click += BtnThongKe_Click;
            this.btnSPCaoNhat.Click += BtnSPCaoNhat_Click;
            this.cboThongKe.SelectedIndexChanged += CboThongKe_SelectedIndexChanged;
            this.btnExportSanPham.Click += btnExportSanPham_Click;
            this.btnExportNguoiDung.Click += BtnExportNguoiDung_Click;
            this.btnExportDonHang.Click += BtnExportDonHang_Click;
        }
        public bool ExportDonHang(List<donhang> dataSource, string templatePath, ref string fileName, bool isPrintPreview)
        {
            if (dataSource == null || dataSource.Count == 0)
            {
                return false;
            }

            // Gán giá trị thứ tự cho thuộc tính id
            for (int i = 1; i <= dataSource.Count; i++)
            {
                dataSource[i - 1].id = i; // Gán giá trị i trực tiếp cho thuộc tính id
            }

            FileInfo templateFile = new FileInfo(templatePath);
            if (!templateFile.Exists)
            {
                throw new FileNotFoundException("Template file not found", templatePath);
            }
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Hoặc LicenseContext.Commercial nếu bạn có giấy phép thương mại

            using (var package = new ExcelPackage(templateFile))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Giả định dữ liệu sẽ được đổ vào worksheet đầu tiên

                // Đổ dữ liệu vào worksheet từ dòng 2, cột 1 (tùy thuộc vào cấu trúc tệp mẫu của bạn)
                int startRow = 7;
                for (int i = 0; i < dataSource.Count; i++)
                {
                    worksheet.Cells[startRow + i, 1].Value = dataSource[i].id; // id đã là kiểu int
                    worksheet.Cells[startRow + i, 2].Value = dataSource[i].tongtien;
                    worksheet.Cells[startRow + i, 3].Value = dataSource[i].trangthaidonhang.trangthai;
                    worksheet.Cells[startRow + i, 4].Value = dataSource[i].khachhang.ten;
                    worksheet.Cells[startRow + i, 5].Value = dataSource[i].ngaytao;
                    worksheet.Cells[startRow + i, 6].Value = dataSource[i].ngaysua;
                    worksheet.Cells[startRow + i, 7].Value = dataSource[i].diachi;

                    // Đặt giá trị ngày và định dạng ngày cho ô
                    var cell1 = worksheet.Cells[startRow + i, 6];
                    var cell2 = worksheet.Cells[startRow + i, 6];
                    cell1.Value = dataSource[i].ngaytao;
                    cell2.Value = dataSource[i].ngaysua;
                    cell1.Style.Numberformat.Format = "yyyy-mm-dd"; // Định dạng ngày theo năm-tháng-ngày
                    cell2.Style.Numberformat.Format = "yyyy-mm-dd"; // Định dạng ngày theo năm-tháng-ngày

                }

                // Lưu tệp mới
                FileInfo fi = new FileInfo(fileName);
                package.SaveAs(fi);
            }

            return true;
        }

        private void BtnExportDonHang_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất");
                    return;
                }

                List<donhang> pListDonHang = new List<donhang>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    // Kiểm tra nếu hàng không phải là hàng mới hoặc không chứa giá trị hợp lệ
                    if (item.Cells[0].Value != null &&
                        item.Cells[1].Value != null &&
                        item.Cells[4].Value != null &&
                        item.Cells[3].Value != null &&
                        item.Cells[5].Value != null)
                    {
                        try
                        {
                            donhang i = new donhang
                            {
                                id = int.Parse(item.Cells[0].Value.ToString()), // Chuyển đổi giá trị ID thành số nguyên
                                diachi = item.Cells[6].Value.ToString(),          // Chuyển đổi giá trị tên thành chuỗi
                                tongtien = Convert.ToDouble(item.Cells[1].Value),   // Chuyển đổi giá trị giá thành số thực
                                ngaysua = Convert.ToDateTime(item.Cells[3].Value.ToString()), // Chuyển đổi giá trị ngày tạo thành kiểu DateTime
                                ngaytao = Convert.ToDateTime(item.Cells[2].Value.ToString()), // Chuyển đổi giá trị ngày tạo thành kiểu DateTime
                                khachhang = new khachhang() // Khởi tạo đối tượng DanhMuc
                                {
                                    // Cần có thông tin ID danh mục để ánh xạ đến tên danh mục
                                    ten = item.Cells[5].Value.ToString() // Ví dụ: lấy tên danh mục từ cột 6
                                },
                                trangthaidonhang=new trangthaidonhang()
                                {
                                    trangthai=item.Cells[4].Value.ToString()
                                }
                            };
                            pListDonHang.Add(i); // Thêm đối tượng sanpham vào danh sách
                        }
                        catch (FormatException ex)
                        {
                            // Xử lý lỗi chuyển đổi dữ liệu, ví dụ: ghi log hoặc thông báo cho người dùng
                            MessageBox.Show($"Lỗi định dạng dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            // Xử lý lỗi khác
                            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


                string path = saveFile.FileName;
                string projectPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
                string templatePath = projectPath + "\\DanhSachDonHang.xlsx";

                if (ExportDonHang(pListDonHang, templatePath, ref path, false))
                {
                    if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                }
                else
                {
                    MessageBox.Show("Xuất dữ liệu thất bại");
                }
            }
        }
        public bool ExportkhachHang(List<khachhang> dataSource, string templatePath, ref string fileName, bool isPrintPreview)
        {
            if (dataSource == null || dataSource.Count == 0)
            {
                return false;
            }

            // Gán giá trị thứ tự cho thuộc tính id
            for (int i = 1; i <= dataSource.Count; i++)
            {
                dataSource[i - 1].id = i; // Gán giá trị i trực tiếp cho thuộc tính id
            }

            FileInfo templateFile = new FileInfo(templatePath);
            if (!templateFile.Exists)
            {
                throw new FileNotFoundException("Template file not found", templatePath);
            }
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Hoặc LicenseContext.Commercial nếu bạn có giấy phép thương mại

            using (var package = new ExcelPackage(templateFile))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Giả định dữ liệu sẽ được đổ vào worksheet đầu tiên

                // Đổ dữ liệu vào worksheet từ dòng 2, cột 1 (tùy thuộc vào cấu trúc tệp mẫu của bạn)
                int startRow = 7;
                for (int i = 0; i < dataSource.Count; i++)
                {
                    worksheet.Cells[startRow + i, 1].Value = dataSource[i].id; // id đã là kiểu int
                    worksheet.Cells[startRow + i, 2].Value = dataSource[i].ten;
                    worksheet.Cells[startRow + i, 3].Value = dataSource[i].email;
                    worksheet.Cells[startRow + i, 4].Value = dataSource[i].sdt;
                    worksheet.Cells[startRow + i, 5].Value = dataSource[i].matkhau;



                }

                // Lưu tệp mới
                FileInfo fi = new FileInfo(fileName);
                package.SaveAs(fi);
            }

            return true;
        }

        private void BtnExportNguoiDung_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất");
                    return;
                }

                List<khachhang> pListSanPham = new List<khachhang>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    // Kiểm tra nếu hàng không phải là hàng mới hoặc không chứa giá trị hợp lệ
                    if (item.Cells[0].Value != null &&
                        item.Cells[1].Value != null &&
                        item.Cells[4].Value != null &&
                        item.Cells[3].Value != null )
                    {
                        try
                        {
                            khachhang i = new khachhang
                            {
                                id = int.Parse(item.Cells[0].Value.ToString()), // Chuyển đổi giá trị ID thành số nguyên
                                ten = item.Cells[1].Value.ToString(),          // Chuyển đổi giá trị tên thành chuỗi
                                sdt =item.Cells[3].Value.ToString(),   // Chuyển đổi giá trị giá thành số thực
                                email = item.Cells[2].Value.ToString(),     // Chuyển đổi giá trị giới tính thành chuỗi
                                matkhau = item.Cells[4].Value.ToString(),     // Chuyển đổi giá trị giới tính thành chuỗi
                            };
                            pListSanPham.Add(i); // Thêm đối tượng sanpham vào danh sách
                        }
                        catch (FormatException ex)
                        {
                            // Xử lý lỗi chuyển đổi dữ liệu, ví dụ: ghi log hoặc thông báo cho người dùng
                            MessageBox.Show($"Lỗi định dạng dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            // Xử lý lỗi khác
                            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


                string path = saveFile.FileName;
                string projectPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
                string templatePath = projectPath + "\\DanhSachKhacHang.xlsx";

                if (ExportkhachHang(pListSanPham, templatePath, ref path, false))
                {
                    if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                }
                else
                {
                    MessageBox.Show("Xuất dữ liệu thất bại");
                }
            }
        }

        public bool ExportSanPham(List<sanpham> dataSource, string templatePath, ref string fileName, bool isPrintPreview)
        {
            if (dataSource == null || dataSource.Count == 0)
            {
                return false;
            }

            // Gán giá trị thứ tự cho thuộc tính id
            for (int i = 1; i <= dataSource.Count; i++)
            {
                dataSource[i - 1].id = i; // Gán giá trị i trực tiếp cho thuộc tính id
            }

            FileInfo templateFile = new FileInfo(templatePath);
            if (!templateFile.Exists)
            {
                throw new FileNotFoundException("Template file not found", templatePath);
            }
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Hoặc LicenseContext.Commercial nếu bạn có giấy phép thương mại

            using (var package = new ExcelPackage(templateFile))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Giả định dữ liệu sẽ được đổ vào worksheet đầu tiên

                // Đổ dữ liệu vào worksheet từ dòng 2, cột 1 (tùy thuộc vào cấu trúc tệp mẫu của bạn)
                int startRow = 7;
                for (int i = 0; i < dataSource.Count; i++)
                {
                    worksheet.Cells[startRow + i, 1].Value = dataSource[i].id; // id đã là kiểu int
                    worksheet.Cells[startRow + i, 2].Value = dataSource[i].ten;
                    worksheet.Cells[startRow + i, 3].Value = dataSource[i].gia;
                    worksheet.Cells[startRow + i, 4].Value = dataSource[i].danhmuc.ten;
                    worksheet.Cells[startRow + i, 5].Value = dataSource[i].gioitinh;
                    worksheet.Cells[startRow + i, 6].Value = dataSource[i].ngaytao;

                    // Đặt giá trị ngày và định dạng ngày cho ô
                    var cell = worksheet.Cells[startRow + i, 6];
                    cell.Value = dataSource[i].ngaytao;
                    cell.Style.Numberformat.Format = "yyyy-mm-dd"; // Định dạng ngày theo năm-tháng-ngày
                }

                // Lưu tệp mới
                FileInfo fi = new FileInfo(fileName);
                package.SaveAs(fi);
            }

            return true;
        }

        private void btnExportSanPham_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất");
                    return;
                }

                List<sanpham> pListSanPham = new List<sanpham>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    // Kiểm tra nếu hàng không phải là hàng mới hoặc không chứa giá trị hợp lệ
                    if (item.Cells[0].Value != null &&
                        item.Cells[1].Value != null &&
                        item.Cells[4].Value != null &&
                        item.Cells[3].Value != null &&
                        item.Cells[5].Value != null)
                    {
                        try
                        {
                            sanpham i = new sanpham
                            {
                                id = int.Parse(item.Cells[0].Value.ToString()), // Chuyển đổi giá trị ID thành số nguyên
                                ten = item.Cells[1].Value.ToString(),          // Chuyển đổi giá trị tên thành chuỗi
                                gia = Convert.ToDouble(item.Cells[4].Value),   // Chuyển đổi giá trị giá thành số thực
                                gioitinh = item.Cells[3].Value.ToString(),     // Chuyển đổi giá trị giới tính thành chuỗi
                                ngaytao = Convert.ToDateTime(item.Cells[5].Value.ToString()), // Chuyển đổi giá trị ngày tạo thành kiểu DateTime
                                danhmuc = new danhmuc() // Khởi tạo đối tượng DanhMuc
                                {
                                    // Cần có thông tin ID danh mục để ánh xạ đến tên danh mục
                                    ten = item.Cells[2].Value.ToString() // Ví dụ: lấy tên danh mục từ cột 6
                                }
                            };
                            pListSanPham.Add(i); // Thêm đối tượng sanpham vào danh sách
                        }
                        catch (FormatException ex)
                        {
                            // Xử lý lỗi chuyển đổi dữ liệu, ví dụ: ghi log hoặc thông báo cho người dùng
                            MessageBox.Show($"Lỗi định dạng dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            // Xử lý lỗi khác
                            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


                string path = saveFile.FileName;
                string projectPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
                string templatePath = projectPath + "\\DanhSachSanPham.xlsx";

                if (ExportSanPham(pListSanPham, templatePath, ref path, false))
                {
                    if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                }
                else
                {
                    MessageBox.Show("Xuất dữ liệu thất bại");
                }
            }
        }

        private void CboThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThongKe.SelectedItem.ToString() == "Danh sách sản phẩm")
            {
                //dataGridView1.DataSource=loadData();
                ShowProducts();
            }
            else if (cboThongKe.SelectedItem.ToString() == "Danh sách người dùng")
            {
                ShowKhachHang();

            }
            else if (cboThongKe.SelectedItem.ToString() == "Đơn hàng")
            {
                ShowDonhang();
            }
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
        private void ShowDonhang()
        {
            var products = blldh.layDsDH();

            // Tạo DataTable mới với 6 cột cần thiết
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Ngày tạo");
            dt.Columns.Add("Ngày sửa");
            dt.Columns.Add("Trạng Thái Đơn hàng");
            dt.Columns.Add("Khách hàng");
            dt.Columns.Add("Địa chỉ");



            foreach (var product in products)
            {
                DateTime ngayTao = product.ngaytao ?? DateTime.MinValue; // Xử lý null nếu cần
                DateTime ngaySua = product.ngaysua ?? DateTime.MinValue;

                dt.Rows.Add(product.id,
                            product.tongtien,
                            ngayTao.ToString("dd/MM/yyyy"),
                            ngaySua.ToString("dd/MM/yyyy"),
                            product.trangthaidonhang.trangthai,
                            product.khachhang.ten,
                            product.diachi);
            }


            // Đặt DataSource cho DataGridView
            dataGridView1.DataSource = dt;
        }
        private void ShowProducts()
        {
            var products = bllsp.layDsSP();

            // Tạo DataTable mới với 6 cột cần thiết
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Danh mục");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Ngày tạo");

            foreach (var product in products)
            {
                dt.Rows.Add(product.id, product.ten, product.danhmuc.ten, product.gioitinh, product.gia, product.ngaytao.ToString("dd/MM/yyyy"));
            }

            // Đặt DataSource cho DataGridView
            dataGridView1.DataSource = dt;
        }
        private void ShowKhachHang()
        {
            var products = bllkh.layDSKH();

            // Tạo DataTable mới với 6 cột cần thiết
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Email");
            dt.Columns.Add("Số Điện thoại");
            dt.Columns.Add("Mật Khẩu");

            foreach (var product in products)
            {
                dt.Rows.Add(product.id, product.ten, product.email, product.sdt, product.matkhau);
            }

            // Đặt DataSource cho DataGridView
            dataGridView1.DataSource = dt;
        }

        private void btnExportSanPham_Click_1(object sender, EventArgs e)
        {

        }
    }
}
