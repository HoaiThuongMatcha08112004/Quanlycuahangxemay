
namespace BanXeMayTTCS.GUI
{
    partial class FormMainNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainNV));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelOption = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLNhapHang = new System.Windows.Forms.Button();
            this.btnQLDonDatHang = new System.Windows.Forms.Button();
            this.btnQLXeMay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelContainer);
            this.panelControl1.Controls.Add(this.panelOption);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1669, 790);
            this.panelControl1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(2, 63);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1665, 725);
            this.panelContainer.TabIndex = 5;
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.Orchid;
            this.panelOption.Controls.Add(this.btnQLTaiKhoan);
            this.panelOption.Controls.Add(this.btnBackupRestore);
            this.panelOption.Controls.Add(this.btnQLNhanVien);
            this.panelOption.Controls.Add(this.btnQLNhapHang);
            this.panelOption.Controls.Add(this.btnQLDonDatHang);
            this.panelOption.Controls.Add(this.btnQLXeMay);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOption.ForeColor = System.Drawing.Color.White;
            this.panelOption.Location = new System.Drawing.Point(2, 2);
            this.panelOption.Name = "panelOption";
            this.panelOption.Padding = new System.Windows.Forms.Padding(8);
            this.panelOption.Size = new System.Drawing.Size(1665, 61);
            this.panelOption.TabIndex = 2;
            this.panelOption.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOption_Paint);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnQLTaiKhoan.Image = global::BanXeMayTTCS.Properties.Resources.account_white_20px;
            this.btnQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(1349, 8);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(308, 45);
            this.btnQLTaiKhoan.TabIndex = 6;
            this.btnQLTaiKhoan.Text = "        Full name";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackupRestore.FlatAppearance.BorderSize = 0;
            this.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupRestore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupRestore.ForeColor = System.Drawing.Color.Black;
            this.btnBackupRestore.Image = global::BanXeMayTTCS.Properties.Resources.folder_download_free_icon_font;
            this.btnBackupRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupRestore.Location = new System.Drawing.Point(1024, 8);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBackupRestore.Size = new System.Drawing.Size(284, 45);
            this.btnBackupRestore.TabIndex = 4;
            this.btnBackupRestore.Text = "        Back up và Restore";
            this.btnBackupRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupRestore.UseVisualStyleBackColor = true;
            this.btnBackupRestore.Visible = false;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnQLNhanVien.Image = global::BanXeMayTTCS.Properties.Resources.users_free_icon_font;
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(770, 8);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(254, 45);
            this.btnQLNhanVien.TabIndex = 3;
            this.btnQLNhanVien.Text = "        Quản lý nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Visible = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnQLNhapHang
            // 
            this.btnQLNhapHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLNhapHang.FlatAppearance.BorderSize = 0;
            this.btnQLNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhapHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnQLNhapHang.Image = global::BanXeMayTTCS.Properties.Resources.sign_in_free_icon_font;
            this.btnQLNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhapHang.Location = new System.Drawing.Point(516, 8);
            this.btnQLNhapHang.Name = "btnQLNhapHang";
            this.btnQLNhapHang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLNhapHang.Size = new System.Drawing.Size(254, 45);
            this.btnQLNhapHang.TabIndex = 1;
            this.btnQLNhapHang.Text = "        Quản lý nhập hàng";
            this.btnQLNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhapHang.UseVisualStyleBackColor = true;
            this.btnQLNhapHang.Click += new System.EventHandler(this.btnQLNhapHang_Click);
            // 
            // btnQLDonDatHang
            // 
            this.btnQLDonDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLDonDatHang.FlatAppearance.BorderSize = 0;
            this.btnQLDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDonDatHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDonDatHang.ForeColor = System.Drawing.Color.Black;
            this.btnQLDonDatHang.Image = global::BanXeMayTTCS.Properties.Resources.document_free_icon_font;
            this.btnQLDonDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDonDatHang.Location = new System.Drawing.Point(262, 8);
            this.btnQLDonDatHang.Name = "btnQLDonDatHang";
            this.btnQLDonDatHang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLDonDatHang.Size = new System.Drawing.Size(254, 45);
            this.btnQLDonDatHang.TabIndex = 2;
            this.btnQLDonDatHang.Text = "        Quản lý đơn đặt hàng";
            this.btnQLDonDatHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDonDatHang.UseVisualStyleBackColor = true;
            this.btnQLDonDatHang.Click += new System.EventHandler(this.btnQLDonDatHang_Click);
            // 
            // btnQLXeMay
            // 
            this.btnQLXeMay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLXeMay.FlatAppearance.BorderSize = 0;
            this.btnQLXeMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXeMay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLXeMay.ForeColor = System.Drawing.Color.Black;
            this.btnQLXeMay.Image = global::BanXeMayTTCS.Properties.Resources.clock_five_free_icon_font_white_24px;
            this.btnQLXeMay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMay.Location = new System.Drawing.Point(8, 8);
            this.btnQLXeMay.Name = "btnQLXeMay";
            this.btnQLXeMay.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLXeMay.Size = new System.Drawing.Size(254, 45);
            this.btnQLXeMay.TabIndex = 0;
            this.btnQLXeMay.Text = "        Quản lý xe máy";
            this.btnQLXeMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMay.UseVisualStyleBackColor = true;
            this.btnQLXeMay.Click += new System.EventHandler(this.btnQLXeMay_Click);
            // 
            // FormMainNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 790);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainNV";
            this.Text = "CỬA HÀNG XE MÁY PHÁT TÀI LUÔN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnBackupRestore;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLNhapHang;
        private System.Windows.Forms.Button btnQLDonDatHang;
        private System.Windows.Forms.Button btnQLXeMay;
        private System.Windows.Forms.Panel panelContainer;
    }
}