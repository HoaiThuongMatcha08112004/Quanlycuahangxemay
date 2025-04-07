
namespace BanXeMayTTCS.GUI
{
    partial class FormQLTaiKhoan
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbNhom = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDiaChi = new System.Windows.Forms.Button();
            this.btnSdt = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.btnDiaChi);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btnSdt);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(32, 48, 32, 32);
            this.panel1.Size = new System.Drawing.Size(1229, 906);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbNhom);
            this.panel2.Controls.Add(this.lbTaiKhoan);
            this.panel2.Controls.Add(this.lbHoTen);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 145);
            this.panel2.TabIndex = 0;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(145, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbHoTen.Size = new System.Drawing.Size(1020, 70);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "FULL NAME";
            this.lbHoTen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbTaiKhoan.Location = new System.Drawing.Point(145, 70);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Padding = new System.Windows.Forms.Padding(12, 2, 0, 0);
            this.lbTaiKhoan.Size = new System.Drawing.Size(1020, 28);
            this.lbTaiKhoan.TabIndex = 4;
            this.lbTaiKhoan.Text = "Account";
            // 
            // lbNhom
            // 
            this.lbNhom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNhom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhom.Location = new System.Drawing.Point(145, 98);
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lbNhom.Size = new System.Drawing.Size(1020, 28);
            this.lbNhom.TabIndex = 3;
            this.lbNhom.Text = "Role";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(32, 193);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1165, 40);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(32, 278);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1165, 10);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(32, 333);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1165, 10);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(32, 388);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1165, 10);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.White;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Image = global::BanXeMayTTCS.Properties.Resources.next_black_16px;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.Location = new System.Drawing.Point(32, 398);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(1165, 45);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDiaChi
            // 
            this.btnDiaChi.BackColor = System.Drawing.Color.White;
            this.btnDiaChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiaChi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaChi.Image = global::BanXeMayTTCS.Properties.Resources.next_black_16px;
            this.btnDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiaChi.Location = new System.Drawing.Point(32, 343);
            this.btnDiaChi.Name = "btnDiaChi";
            this.btnDiaChi.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnDiaChi.Size = new System.Drawing.Size(1165, 45);
            this.btnDiaChi.TabIndex = 6;
            this.btnDiaChi.Text = "Địa chỉ";
            this.btnDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiaChi.UseVisualStyleBackColor = false;
            // 
            // btnSdt
            // 
            this.btnSdt.BackColor = System.Drawing.Color.White;
            this.btnSdt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSdt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSdt.Image = global::BanXeMayTTCS.Properties.Resources.next_black_16px;
            this.btnSdt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSdt.Location = new System.Drawing.Point(32, 288);
            this.btnSdt.Name = "btnSdt";
            this.btnSdt.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnSdt.Size = new System.Drawing.Size(1165, 45);
            this.btnSdt.TabIndex = 4;
            this.btnSdt.Text = "Số điện thoại";
            this.btnSdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSdt.UseVisualStyleBackColor = false;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Image = global::BanXeMayTTCS.Properties.Resources.next_black_16px;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(32, 233);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnDoiMatKhau.Size = new System.Drawing.Size(1165, 45);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::BanXeMayTTCS.Properties.Resources.user_gradient_128px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 906);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQLTaiKhoan";
            this.Text = "FormQLTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbNhom;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnDiaChi;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnSdt;
        private System.Windows.Forms.Splitter splitter2;
    }
}