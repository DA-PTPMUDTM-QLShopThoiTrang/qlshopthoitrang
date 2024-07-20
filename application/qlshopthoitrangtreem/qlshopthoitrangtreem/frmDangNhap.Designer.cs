
namespace qlshopthoitrangtreem
{
    partial class frmDangNhap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ctDangNhap1 = new ThuVienControl.ctDangNhap();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(308, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ctDangNhap1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(492, 279);
            this.panel5.TabIndex = 3;
            // 
            // ctDangNhap1
            // 
            this.ctDangNhap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctDangNhap1.Location = new System.Drawing.Point(0, 0);
            this.ctDangNhap1.Name = "ctDangNhap1";
            this.ctDangNhap1.Size = new System.Drawing.Size(492, 279);
            this.ctDangNhap1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 97);
            this.panel4.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tùy chỉnh cấu hình";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 74);
            this.panel3.TabIndex = 1;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private ThuVienControl.ctDangNhap ctDangNhap1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

