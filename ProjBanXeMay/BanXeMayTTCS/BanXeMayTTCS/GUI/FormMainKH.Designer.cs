
namespace BanXeMayTTCS.GUI
{
    partial class FormMainKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainKH));
            this.panelOption = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnQLDonDatHang = new System.Windows.Forms.Button();
            this.btnQLXeMay = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnXemDonDatHang = new System.Windows.Forms.Button();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.Orchid;
            this.panelOption.Controls.Add(this.btnXemDonDatHang);
            this.panelOption.Controls.Add(this.btnQLTaiKhoan);
            this.panelOption.Controls.Add(this.btnQLDonDatHang);
            this.panelOption.Controls.Add(this.btnQLXeMay);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOption.ForeColor = System.Drawing.Color.White;
            this.panelOption.Location = new System.Drawing.Point(2, 2);
            this.panelOption.Name = "panelOption";
            this.panelOption.Padding = new System.Windows.Forms.Padding(8);
            this.panelOption.Size = new System.Drawing.Size(1564, 63);
            this.panelOption.TabIndex = 1;
            this.panelOption.Click += new System.EventHandler(this.btnQLDonDatHang_Click);
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
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(1193, 8);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(363, 47);
            this.btnQLTaiKhoan.TabIndex = 7;
            this.btnQLTaiKhoan.Text = "        Full name";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnQLDonDatHang
            // 
            this.btnQLDonDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLDonDatHang.FlatAppearance.BorderSize = 0;
            this.btnQLDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDonDatHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDonDatHang.ForeColor = System.Drawing.Color.Black;
            this.btnQLDonDatHang.Image = global::BanXeMayTTCS.Properties.Resources.shopping_cart_free_icon_font;
            this.btnQLDonDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDonDatHang.Location = new System.Drawing.Point(265, 8);
            this.btnQLDonDatHang.Name = "btnQLDonDatHang";
            this.btnQLDonDatHang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLDonDatHang.Size = new System.Drawing.Size(257, 47);
            this.btnQLDonDatHang.TabIndex = 2;
            this.btnQLDonDatHang.Text = "        Giỏ hàng";
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
            this.btnQLXeMay.Image = global::BanXeMayTTCS.Properties.Resources.home_free_icon_font;
            this.btnQLXeMay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMay.Location = new System.Drawing.Point(8, 8);
            this.btnQLXeMay.Name = "btnQLXeMay";
            this.btnQLXeMay.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLXeMay.Size = new System.Drawing.Size(257, 47);
            this.btnQLXeMay.TabIndex = 0;
            this.btnQLXeMay.Text = "     Trang chủ";
            this.btnQLXeMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMay.UseVisualStyleBackColor = true;
            this.btnQLXeMay.Click += new System.EventHandler(this.btnQLXeMay_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelContainer);
            this.panelControl1.Controls.Add(this.panelOption);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1568, 621);
            this.panelControl1.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(2, 65);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1564, 554);
            this.panelContainer.TabIndex = 9;
            // 
            // btnXemDonDatHang
            // 
            this.btnXemDonDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXemDonDatHang.FlatAppearance.BorderSize = 0;
            this.btnXemDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDonDatHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDonDatHang.ForeColor = System.Drawing.Color.Black;
            this.btnXemDonDatHang.Image = global::BanXeMayTTCS.Properties.Resources.shopping_cart_free_icon_font;
            this.btnXemDonDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDonDatHang.Location = new System.Drawing.Point(522, 8);
            this.btnXemDonDatHang.Name = "btnXemDonDatHang";
            this.btnXemDonDatHang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnXemDonDatHang.Size = new System.Drawing.Size(257, 47);
            this.btnXemDonDatHang.TabIndex = 8;
            this.btnXemDonDatHang.Text = "       Đơn hàng đã đặt";
            this.btnXemDonDatHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDonDatHang.UseVisualStyleBackColor = true;
            // 
            // FormMainKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 621);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainKH";
            this.Text = "CỬA HÀNG XE MÁY PHÁT TÀI LUÔN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainKH_Load);
            this.panelOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnQLDonDatHang;
        private System.Windows.Forms.Button btnQLXeMay;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnXemDonDatHang;
    }
}