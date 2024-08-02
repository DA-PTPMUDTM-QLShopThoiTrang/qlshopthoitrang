
namespace qlshopthoitrangtreem
{
    partial class frmThemNguoiDungNhomND
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
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_NguoiDungNhomNguoiDungDKDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungDKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(12, 122);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(441, 220);
            this.qL_NguoiDungDataGridView.TabIndex = 1;
            // 
            // qL_NguoiDungNhomNguoiDungDKDataGridView
            // 
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.Location = new System.Drawing.Point(603, 122);
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.Name = "qL_NguoiDungNhomNguoiDungDKDataGridView";
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.Size = new System.Drawing.Size(442, 220);
            this.qL_NguoiDungNhomNguoiDungDKDataGridView.TabIndex = 3;
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DisplayMember = "MaNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(603, 57);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(442, 24);
            this.qL_NhomNguoiDungComboBox.TabIndex = 4;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmThemNguoiDungNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 575);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Controls.Add(this.qL_NguoiDungNhomNguoiDungDKDataGridView);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Name = "frmThemNguoiDungNhomND";
            this.Text = "frmThemNguoiDungNhomND";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungDKDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.DataGridView qL_NguoiDungNhomNguoiDungDKDataGridView;
        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}