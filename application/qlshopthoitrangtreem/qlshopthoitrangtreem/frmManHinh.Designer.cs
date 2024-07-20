
namespace qlshopthoitrangtreem
{
    partial class frmManHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinh));
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            this.dataSet1 = new qlshopthoitrangtreem.DataSet1();
            this.dM_ManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ManHinhTableAdapter = new qlshopthoitrangtreem.DataSet1TableAdapters.DM_ManHinhTableAdapter();
            this.tableAdapterManager = new qlshopthoitrangtreem.DataSet1TableAdapters.TableAdapterManager();
            this.dM_ManHinhBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dM_ManHinhBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dM_ManHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tenManHinhTextBox = new System.Windows.Forms.TextBox();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingNavigator)).BeginInit();
            this.dM_ManHinhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_ManHinhBindingSource
            // 
            this.dM_ManHinhBindingSource.DataMember = "DM_ManHinh";
            this.dM_ManHinhBindingSource.DataSource = this.dataSet1;
            // 
            // dM_ManHinhTableAdapter
            // 
            this.dM_ManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = this.dM_ManHinhTableAdapter;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = qlshopthoitrangtreem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_ManHinhBindingNavigator
            // 
            this.dM_ManHinhBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dM_ManHinhBindingNavigator.BindingSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dM_ManHinhBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dM_ManHinhBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dM_ManHinhBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dM_ManHinhBindingNavigatorSaveItem});
            this.dM_ManHinhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dM_ManHinhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dM_ManHinhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dM_ManHinhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dM_ManHinhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dM_ManHinhBindingNavigator.Name = "dM_ManHinhBindingNavigator";
            this.dM_ManHinhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dM_ManHinhBindingNavigator.Size = new System.Drawing.Size(1132, 27);
            this.dM_ManHinhBindingNavigator.TabIndex = 0;
            this.dM_ManHinhBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dM_ManHinhBindingNavigatorSaveItem
            // 
            this.dM_ManHinhBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dM_ManHinhBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dM_ManHinhBindingNavigatorSaveItem.Image")));
            this.dM_ManHinhBindingNavigatorSaveItem.Name = "dM_ManHinhBindingNavigatorSaveItem";
            this.dM_ManHinhBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dM_ManHinhBindingNavigatorSaveItem.Text = "Save Data";
            this.dM_ManHinhBindingNavigatorSaveItem.Click += new System.EventHandler(this.dM_ManHinhBindingNavigatorSaveItem_Click);
            // 
            // dM_ManHinhDataGridView
            // 
            this.dM_ManHinhDataGridView.AutoGenerateColumns = false;
            this.dM_ManHinhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dM_ManHinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dM_ManHinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dM_ManHinhDataGridView.DataSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhDataGridView.Location = new System.Drawing.Point(72, 100);
            this.dM_ManHinhDataGridView.Name = "dM_ManHinhDataGridView";
            this.dM_ManHinhDataGridView.RowHeadersWidth = 51;
            this.dM_ManHinhDataGridView.RowTemplate.Height = 24;
            this.dM_ManHinhDataGridView.Size = new System.Drawing.Size(597, 259);
            this.dM_ManHinhDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(maManHinhLabel);
            this.panel1.Controls.Add(this.maManHinhTextBox);
            this.panel1.Controls.Add(tenManHinhLabel);
            this.panel1.Controls.Add(this.tenManHinhTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 458);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dM_ManHinhDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(431, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 458);
            this.panel2.TabIndex = 3;
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(117, 136);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(95, 17);
            maManHinhLabel.TabIndex = 0;
            maManHinhLabel.Text = "Ma Man Hinh:";
            // 
            // maManHinhTextBox
            // 
            this.maManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dM_ManHinhBindingSource, "MaManHinh", true));
            this.maManHinhTextBox.Location = new System.Drawing.Point(224, 133);
            this.maManHinhTextBox.Name = "maManHinhTextBox";
            this.maManHinhTextBox.Size = new System.Drawing.Size(100, 22);
            this.maManHinhTextBox.TabIndex = 1;
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(117, 164);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(101, 17);
            tenManHinhLabel.TabIndex = 2;
            tenManHinhLabel.Text = "Ten Man Hinh:";
            // 
            // tenManHinhTextBox
            // 
            this.tenManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dM_ManHinhBindingSource, "TenManHinh", true));
            this.tenManHinhTextBox.Location = new System.Drawing.Point(224, 161);
            this.tenManHinhTextBox.Name = "tenManHinhTextBox";
            this.tenManHinhTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenManHinhTextBox.TabIndex = 3;
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dM_ManHinhBindingNavigator);
            this.Name = "frmManHinh";
            this.Text = "frmManHinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingNavigator)).EndInit();
            this.dM_ManHinhBindingNavigator.ResumeLayout(false);
            this.dM_ManHinhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dM_ManHinhBindingSource;
        private DataSet1TableAdapters.DM_ManHinhTableAdapter dM_ManHinhTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dM_ManHinhBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dM_ManHinhBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dM_ManHinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox maManHinhTextBox;
        private System.Windows.Forms.TextBox tenManHinhTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}