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
namespace qlshopthoitrangtreem
{
    public partial class frmQLDonHang : Form
    {
        BLL_DonHang blldonhang = new BLL_DonHang();
        UpLoadToFirebaseStorage firebase = new UpLoadToFirebaseStorage();
        public frmQLDonHang()
        {
            InitializeComponent();
            dtgvdonhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvdonhang.ScrollBars = ScrollBars.Vertical;
            dtgvchitietdonhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvchitietdonhang.ScrollBars = ScrollBars.Vertical;
        }


        private void frmQLDonHang_Load(object sender, EventArgs e)
        {
            cbtrangthai.DataSource = blldonhang.layDsTrangThaiDonHang();
            cbtrangthai.DisplayMember = "trangthai";
            cbtrangthai.ValueMember = "id";

            this.loadData(Int32.Parse(cbtrangthai.SelectedValue.ToString()));
            this.cbtrangthai.SelectionChangeCommitted += Cbtrangthai_SelectionChangeCommitted;
            this.dtgvdonhang.SelectionChanged += Dtgvdonhang_SelectionChanged;

        }
        bool isChangeCB = false;
        private void Cbtrangthai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isChangeCB = true;
            this.dtgvdonhang.Rows.Clear();
            this.loadData(Int32.Parse(cbtrangthai.SelectedValue.ToString()));
        }
        
        void capNhatBtn(int trangthai)
        {
            if (trangthai == 1)
            {
                btnhuy.Enabled = true;
                btnxacnhan.Enabled = true;
                btnvanchuyen.Enabled = false;
                btnhoanthanh.Enabled = false;
            }
            else if (trangthai == 2)
            {
                btnhuy.Enabled = false;
                btnvanchuyen.Enabled = true;
                btnxacnhan.Enabled = false;
                btnhoanthanh.Enabled = false;
            }
            else
            {
                btnhoanthanh.Enabled = false;
                btnhuy.Enabled = false;
                btnvanchuyen.Enabled = false;
                btnxacnhan.Enabled = false;
            }
        }

        private async void Dtgvdonhang_SelectionChanged(object sender, EventArgs e)
        {
            if (!isChangeCB)
            {
                tbiddonhang.Text = dtgvdonhang.CurrentRow.Cells[0].Value.ToString();
                tbkhachhang.Text = dtgvdonhang.CurrentRow.Cells[1].Value.ToString();
                tbtrangthai.Text = dtgvdonhang.CurrentRow.Cells[3].Value.ToString();
                rbdiachi.Text = dtgvdonhang.CurrentRow.Cells[4].Value.ToString();
                lbtongtien.Text = dtgvdonhang.CurrentRow.Cells[2].Value.ToString();
                this.capNhatBtn(Int32.Parse(cbtrangthai.SelectedValue.ToString()));

                List<ChiTietDonHangSanPham> dscthd = blldonhang.layChiTietDonHang(Int32.Parse(this.dtgvdonhang.CurrentRow.Cells[0].Value.ToString()));
                this.dtgvchitietdonhang.Rows.Clear();
                List<Task> tasks = new List<Task>();
                foreach (ChiTietDonHangSanPham item in dscthd)
                {
                    if (item.hinhanh.Contains("https://firebasestorage.googleapis.com/v0"))
                    {

                        tasks.Add(Task.Run(async () =>
                        {
                            // load anh tu url
                            Bitmap thumbnailBitmap = await firebase.LoadImageFromUrl(item.hinhanh);


                            dtgvchitietdonhang.Invoke((MethodInvoker)delegate
                            {
                                dtgvchitietdonhang.Rows.Add(new object[] { item.id, item.tensanpham, item.mausac, item.kichco, item.gia, item.gia, thumbnailBitmap });
                                dtgvchitietdonhang.RowTemplate.Height = thumbnailBitmap.Height;
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
            this.isChangeCB = false;
        }

        public void loadData(int trangthai)
        {
            List<donhang> dsdh = blldonhang.layDsDH(trangthai);
            foreach (donhang item in dsdh)
            {
                this.dtgvdonhang.Rows.Add(new object[]{
                    item.id,
                    item.khachhang.ten,
                    item.tongtien,
                    item.trangthaidonhang.trangthai,
                    item.diachi,
                    item.isThanhToan,
                    item.ngaytao,
                    item.ngaysua
                });
            }
        }


        DialogResult ctmessageBox(string mes)
        {
            return MessageBox.Show(mes, "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ctmessageBox("Bạn có chắc chắn muốn hủy đơn hàng này không?") == DialogResult.OK)
                {
                    bool isOk = blldonhang.capNhatDH(Int32.Parse(tbiddonhang.Text), 4);
                    if (isOk)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        isChangeCB = true;
                        this.dtgvdonhang.Rows.Clear();
                        this.dtgvchitietdonhang.Rows.Clear();
                        this.loadData(Int32.Parse(cbtrangthai.SelectedValue.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thực hiện lại!");
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ctmessageBox("Bạn có chắc chắn muốn xác nhận đơn hàng này không?") == DialogResult.OK)
                {
                    bool isOk = blldonhang.capNhatDH(Int32.Parse(tbiddonhang.Text), 2);
                    if (isOk)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        isChangeCB = true;
                        this.dtgvdonhang.Rows.Clear();
                        this.dtgvchitietdonhang.Rows.Clear();
                        this.loadData(Int32.Parse(cbtrangthai.SelectedValue.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thực hiện lại!");
            }
        }

        private void btnvanchuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ctmessageBox("Bạn có chắc chắn đơn hàng đã được giao không?") == DialogResult.OK)
                {
                    bool isOk = blldonhang.capNhatDH(Int32.Parse(tbiddonhang.Text), 3);
                    if (isOk)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        isChangeCB = true;
                        this.dtgvdonhang.Rows.Clear();
                        this.dtgvchitietdonhang.Rows.Clear();
                        this.loadData(Int32.Parse(cbtrangthai.SelectedValue.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thực hiện lại!");
            }
        }
    }
}
