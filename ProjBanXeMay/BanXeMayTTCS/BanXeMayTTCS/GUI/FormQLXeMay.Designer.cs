
namespace BanXeMayTTCS.GUI
{
    partial class FormQLXeMay
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnNgungKinhDoanh = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.btnThoatChucNang = new System.Windows.Forms.ToolStripButton();
            this.gridControlXeMay = new DevExpress.XtraGrid.GridControl();
            this.gridViewXeMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.comboBoxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.comboBoxHang = new System.Windows.Forms.ComboBox();
            this.comboBoxLoai = new System.Windows.Forms.ComboBox();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenXeMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaXeMay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHinhAnh = new System.Windows.Forms.PictureBox();
            this.openFileDialogChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXeMay)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnNgungKinhDoanh,
            this.btnTaiLai,
            this.btnThoatChucNang});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(8);
            this.toolStripMenu.Size = new System.Drawing.Size(1247, 44);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::BanXeMayTTCS.Properties.Resources.add_free_icon_font_blue_24px;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThem.Size = new System.Drawing.Size(85, 25);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::BanXeMayTTCS.Properties.Resources.edit_free_icon_font_blue_24px;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSua.Size = new System.Drawing.Size(71, 25);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.Black;
            this.btnGhi.Image = global::BanXeMayTTCS.Properties.Resources.disk_free_icon_font_blue_24px;
            this.btnGhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnGhi.Size = new System.Drawing.Size(68, 25);
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::BanXeMayTTCS.Properties.Resources.trash_free_icon_font_blue_24px;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnXoa.Size = new System.Drawing.Size(71, 25);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNgungKinhDoanh
            // 
            this.btnNgungKinhDoanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgungKinhDoanh.ForeColor = System.Drawing.Color.Black;
            this.btnNgungKinhDoanh.Image = global::BanXeMayTTCS.Properties.Resources.trash_free_icon_font_blue_24px;
            this.btnNgungKinhDoanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNgungKinhDoanh.Name = "btnNgungKinhDoanh";
            this.btnNgungKinhDoanh.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnNgungKinhDoanh.Size = new System.Drawing.Size(187, 25);
            this.btnNgungKinhDoanh.Text = "Ngừng kinh doanh";
            this.btnNgungKinhDoanh.Click += new System.EventHandler(this.btnNgungKinhDoanh_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLai.Image = global::BanXeMayTTCS.Properties.Resources.reload;
            this.btnTaiLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnTaiLai.Size = new System.Drawing.Size(88, 25);
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnThoatChucNang
            // 
            this.btnThoatChucNang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatChucNang.ForeColor = System.Drawing.Color.Black;
            this.btnThoatChucNang.Image = global::BanXeMayTTCS.Properties.Resources.sign_out_alt_free_icon_font_blue_24px;
            this.btnThoatChucNang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoatChucNang.Name = "btnThoatChucNang";
            this.btnThoatChucNang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThoatChucNang.Size = new System.Drawing.Size(170, 25);
            this.btnThoatChucNang.Text = "Thoát chức năng";
            this.btnThoatChucNang.Click += new System.EventHandler(this.btnThoatChucNang_Click);
            // 
            // gridControlXeMay
            // 
            this.gridControlXeMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlXeMay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(15);
            this.gridControlXeMay.Location = new System.Drawing.Point(0, 44);
            this.gridControlXeMay.MainView = this.gridViewXeMay;
            this.gridControlXeMay.Margin = new System.Windows.Forms.Padding(15);
            this.gridControlXeMay.Name = "gridControlXeMay";
            this.gridControlXeMay.Size = new System.Drawing.Size(1247, 500);
            this.gridControlXeMay.TabIndex = 1;
            this.gridControlXeMay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXeMay});
            // 
            // gridViewXeMay
            // 
            this.gridViewXeMay.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewXeMay.Appearance.Row.Options.UseFont = true;
            this.gridViewXeMay.DetailHeight = 437;
            this.gridViewXeMay.GridControl = this.gridControlXeMay;
            this.gridViewXeMay.Name = "gridViewXeMay";
            this.gridViewXeMay.OptionsBehavior.Editable = false;
            this.gridViewXeMay.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewXeMay_FocusedRowChanged);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.comboBoxNhaCungCap);
            this.panelInput.Controls.Add(this.comboBoxHang);
            this.panelInput.Controls.Add(this.comboBoxLoai);
            this.panelInput.Controls.Add(this.comboBoxTrangThai);
            this.panelInput.Controls.Add(this.txtMoTa);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtSoLuongTon);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.txtGia);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtTenXeMay);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtMaXeMay);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.pictureBoxHinhAnh);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 544);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1247, 409);
            this.panelInput.TabIndex = 2;
            // 
            // comboBoxNhaCungCap
            // 
            this.comboBoxNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNhaCungCap.FormattingEnabled = true;
            this.comboBoxNhaCungCap.Location = new System.Drawing.Point(746, 183);
            this.comboBoxNhaCungCap.Name = "comboBoxNhaCungCap";
            this.comboBoxNhaCungCap.Size = new System.Drawing.Size(190, 29);
            this.comboBoxNhaCungCap.TabIndex = 8;
            // 
            // comboBoxHang
            // 
            this.comboBoxHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHang.FormattingEnabled = true;
            this.comboBoxHang.Location = new System.Drawing.Point(746, 125);
            this.comboBoxHang.Name = "comboBoxHang";
            this.comboBoxHang.Size = new System.Drawing.Size(190, 29);
            this.comboBoxHang.TabIndex = 7;
            // 
            // comboBoxLoai
            // 
            this.comboBoxLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoai.FormattingEnabled = true;
            this.comboBoxLoai.Location = new System.Drawing.Point(746, 69);
            this.comboBoxLoai.Name = "comboBoxLoai";
            this.comboBoxLoai.Size = new System.Drawing.Size(190, 29);
            this.comboBoxLoai.TabIndex = 6;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(746, 18);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(190, 29);
            this.comboBoxTrangThai.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(957, 49);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(287, 178);
            this.txtMoTa.TabIndex = 9;
            this.txtMoTa.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(952, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mô tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hãng xe máy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại xe máy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(379, 185);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(180, 29);
            this.txtSoLuongTon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng tồn:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(379, 127);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(180, 29);
            this.txtGia.TabIndex = 3;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá bán (VNĐ):";
            // 
            // txtTenXeMay
            // 
            this.txtTenXeMay.Location = new System.Drawing.Point(379, 71);
            this.txtTenXeMay.MaxLength = 50;
            this.txtTenXeMay.Name = "txtTenXeMay";
            this.txtTenXeMay.Size = new System.Drawing.Size(180, 29);
            this.txtTenXeMay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên xe máy:";
            // 
            // txtMaXeMay
            // 
            this.txtMaXeMay.Location = new System.Drawing.Point(379, 15);
            this.txtMaXeMay.MaxLength = 20;
            this.txtMaXeMay.Name = "txtMaXeMay";
            this.txtMaXeMay.Size = new System.Drawing.Size(180, 29);
            this.txtMaXeMay.TabIndex = 1;
            this.txtMaXeMay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaXeMay_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã xe máy:";
            // 
            // pictureBoxHinhAnh
            // 
            this.pictureBoxHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHinhAnh.ErrorImage = global::BanXeMayTTCS.Properties.Resources.error_image;
            this.pictureBoxHinhAnh.InitialImage = global::BanXeMayTTCS.Properties.Resources.init_image;
            this.pictureBoxHinhAnh.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            this.pictureBoxHinhAnh.Size = new System.Drawing.Size(230, 230);
            this.pictureBoxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinhAnh.TabIndex = 0;
            this.pictureBoxHinhAnh.TabStop = false;
            this.pictureBoxHinhAnh.Click += new System.EventHandler(this.pictureBoxHinhAnh_Click);
            // 
            // openFileDialogChonAnh
            // 
            this.openFileDialogChonAnh.FileName = "openFileDialog";
            // 
            // FormQLXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 953);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gridControlXeMay);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQLXeMay";
            this.Text = "FormQLXeMay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXeMay)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private System.Windows.Forms.ToolStripButton btnThoatChucNang;
        private DevExpress.XtraGrid.GridControl gridControlXeMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXeMay;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.PictureBox pictureBoxHinhAnh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenXeMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaXeMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNhaCungCap;
        private System.Windows.Forms.ComboBox comboBoxHang;
        private System.Windows.Forms.ComboBox comboBoxLoai;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonAnh;
        private System.Windows.Forms.ToolStripButton btnNgungKinhDoanh;
    }
}