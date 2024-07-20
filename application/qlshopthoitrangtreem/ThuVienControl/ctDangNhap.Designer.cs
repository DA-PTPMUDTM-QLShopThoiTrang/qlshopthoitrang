namespace ThuVienControl
{
    partial class ctDangNhap
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbtendangnhap = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.lbtendangnhap = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // tbtendangnhap
            // 
            this.tbtendangnhap.Location = new System.Drawing.Point(148, 79);
            this.tbtendangnhap.Name = "tbtendangnhap";
            this.tbtendangnhap.Size = new System.Drawing.Size(267, 22);
            this.tbtendangnhap.TabIndex = 1;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(148, 126);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.PasswordChar = '*';
            this.tbmatkhau.Size = new System.Drawing.Size(267, 22);
            this.tbmatkhau.TabIndex = 2;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(148, 179);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(113, 35);
            this.btndangnhap.TabIndex = 3;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            // 
            // lbtendangnhap
            // 
            this.lbtendangnhap.AutoSize = true;
            this.lbtendangnhap.Location = new System.Drawing.Point(30, 79);
            this.lbtendangnhap.Name = "lbtendangnhap";
            this.lbtendangnhap.Size = new System.Drawing.Size(109, 17);
            this.lbtendangnhap.TabIndex = 5;
            this.lbtendangnhap.Text = "Tên đăng nhập:";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(30, 131);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(70, 17);
            this.lbmatkhau.TabIndex = 6;
            this.lbmatkhau.Text = "Mật khẩu:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(302, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ctDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtendangnhap);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtendangnhap);
            this.Controls.Add(this.label1);
            this.Name = "ctDangNhap";
            this.Size = new System.Drawing.Size(463, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbtendangnhap;
        public System.Windows.Forms.TextBox tbmatkhau;
        public System.Windows.Forms.Button btndangnhap;
        public System.Windows.Forms.Label lbtendangnhap;
        public System.Windows.Forms.Label lbmatkhau;
        public System.Windows.Forms.Button btnThoat;
    }
}
