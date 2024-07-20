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
    public partial class frmCauHinh : Form
    {
        Ql_NguoiDung CauHinh = new Ql_NguoiDung();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.SaveConfig(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text);
            this.Close();
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            qlshopthoitrangtreem.Properties.Settings.Default.cnn = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            qlshopthoitrangtreem.Properties.Settings.Default.Save();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = CauHinh.GetServerName();
            comboBox1.DisplayMember = "ServerName";
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.DataSource = CauHinh.GetDBName(comboBox1.Text, textBox1.Text, textBox2.Text);
            comboBox2.DisplayMember = "name";
        }
    }
}
