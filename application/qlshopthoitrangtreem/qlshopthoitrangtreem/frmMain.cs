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
    public partial class frmMain : Form
    {
        string tendangnhap = "admin";
        BLL_NguoiDung nguoidung = new BLL_NguoiDung();
        
        public frmMain()
        {
            InitializeComponent();
            this.nguoidung.Cnn = Properties.Settings.Default.cnn;
        }
        public frmMain(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.nguoidung.Cnn = Properties.Settings.Default.cnn;
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanQuyen form = new frmPhanQuyen();
            form.MdiParent = this;
            form.Show();
        }

        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems, pScreenName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BLL_NhomNguoiDung bllnnd = new BLL_NhomNguoiDung();
            BLL_QLPhanQuyen bllpq = new BLL_QLPhanQuyen();
            List<string> nhomND = bllnnd.layDsNhomNguoiDungTypeLString(this.tendangnhap);
            foreach (string item in nhomND)
            {
                List<NhomNguoiDungManHinh> dsQuyen = bllpq.LayDSManHinhPhanQuyen(item);
                foreach (NhomNguoiDungManHinh mh in dsQuyen)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items,
                    mh.MaManHinh, Convert.ToBoolean(mh.CoQuyen));
                }
            }
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung form = new frmNguoiDung();
            form.MdiParent = this;
            form.Show();
        }

        private void nhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhomNguoiDung form = new frmNhomNguoiDung();
            form.MdiParent = this;
            form.Show();
        }

        private void thêmNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungNhomND form = new frmThemNguoiDungNhomND();
            form.MdiParent = this;
            form.Show();
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManHinh form = new frmManHinh();
            form.MdiParent = this;
            form.Show();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSanPham form = new frmQLSanPham();
            form.MdiParent = this;
            form.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSP form = new frmLoaiSP();
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhachHang form = new frmQLKhachHang();
            form.MdiParent = this;
            form.Show();
        }

        private void kíchCỡSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKichCo frm = new frmKichCo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
