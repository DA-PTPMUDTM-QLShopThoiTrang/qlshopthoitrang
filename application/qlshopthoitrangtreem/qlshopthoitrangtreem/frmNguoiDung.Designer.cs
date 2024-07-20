
namespace qlshopthoitrangtreem
{
    partial class frmNguoiDung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            this.dataSet1 = new qlshopthoitrangtreem.DataSet1();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungTableAdapter = new qlshopthoitrangtreem.DataSet1TableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new qlshopthoitrangtreem.DataSet1TableAdapters.TableAdapterManager();
            this.qL_NguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qL_NguoiDungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tenDangNhapTextBox = new System.Windows.Forms.TextBox();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.hoatDongCheckBox = new System.Windows.Forms.CheckBox();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).BeginInit();
            this.qL_NguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = qlshopthoitrangtreem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NguoiDungBindingNavigator
            // 
            this.qL_NguoiDungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NguoiDungBindingNavigator.BindingSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NguoiDungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NguoiDungBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qL_NguoiDungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qL_NguoiDungBindingNavigatorSaveItem});
            this.qL_NguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NguoiDungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NguoiDungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NguoiDungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NguoiDungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NguoiDungBindingNavigator.Name = "qL_NguoiDungBindingNavigator";
            this.qL_NguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NguoiDungBindingNavigator.Size = new System.Drawing.Size(1018, 27);
            this.qL_NguoiDungBindingNavigator.TabIndex = 0;
            this.qL_NguoiDungBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // qL_NguoiDungBindingNavigatorSaveItem
            // 
            this.qL_NguoiDungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NguoiDungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NguoiDungBindingNavigatorSaveItem.Image")));
            this.qL_NguoiDungBindingNavigatorSaveItem.Name = "qL_NguoiDungBindingNavigatorSaveItem";
            this.qL_NguoiDungBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.qL_NguoiDungBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NguoiDungBindingNavigatorSaveItem_Click);
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(326, 164);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(661, 220);
            this.qL_NguoiDungDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(46, 167);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(113, 17);
            tenDangNhapLabel.TabIndex = 2;
            tenDangNhapLabel.Text = "Ten Dang Nhap:";
            // 
            // tenDangNhapTextBox
            // 
            this.tenDangNhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NguoiDungBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextBox.Location = new System.Drawing.Point(165, 164);
            this.tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            this.tenDangNhapTextBox.Size = new System.Drawing.Size(104, 22);
            this.tenDangNhapTextBox.TabIndex = 3;
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(46, 195);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(72, 17);
            matKhauLabel.TabIndex = 4;
            matKhauLabel.Text = "Mat Khau:";
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NguoiDungBindingSource, "MatKhau", true));
            this.matKhauTextBox.Location = new System.Drawing.Point(165, 192);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.Size = new System.Drawing.Size(104, 22);
            this.matKhauTextBox.TabIndex = 5;
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(46, 225);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(80, 17);
            hoatDongLabel.TabIndex = 6;
            hoatDongLabel.Text = "Hoat Dong:";
            // 
            // hoatDongCheckBox
            // 
            this.hoatDongCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.qL_NguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckBox.Location = new System.Drawing.Point(165, 220);
            this.hoatDongCheckBox.Name = "hoatDongCheckBox";
            this.hoatDongCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hoatDongCheckBox.TabIndex = 7;
            this.hoatDongCheckBox.Text = "checkBox1";
            this.hoatDongCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 511);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextBox);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextBox);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckBox);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Controls.Add(this.qL_NguoiDungBindingNavigator);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).EndInit();
            this.qL_NguoiDungBindingNavigator.ResumeLayout(false);
            this.qL_NguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private DataSet1TableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NguoiDungBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qL_NguoiDungBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox tenDangNhapTextBox;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.CheckBox hoatDongCheckBox;
    }
}