using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NguoiDung;

namespace qlshopthoitrangtreem
{
    public partial class frmMain : Form
    {
        string tendangnhap = "user3";
        Ql_NguoiDung nguoidung = new Ql_NguoiDung();
        
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
            List<string> nhomND = nguoidung.GetMaNhomNguoiDung(this.tendangnhap);
            foreach (string item in nhomND)
            {
                DataTable dsQuyen = nguoidung.GetMaManHinh(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items,
                    mh[0].ToString(), Convert.ToBoolean(mh[2].ToString()));
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
    }
}
