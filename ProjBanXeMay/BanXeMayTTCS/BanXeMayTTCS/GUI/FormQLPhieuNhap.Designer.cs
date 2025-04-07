
namespace BanXeMayTTCS.GUI
{
    partial class FormQLPhieuNhap
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnTaiLaiChiTiet = new System.Windows.Forms.ToolStripButton();
            this.btnSuaChiTiet = new System.Windows.Forms.ToolStripButton();
            this.toolStripCTPhieuNhap = new System.Windows.Forms.ToolStrip();
            this.btnThemChiTiet = new System.Windows.Forms.ToolStripButton();
            this.btnXoaChiTiet = new System.Windows.Forms.ToolStripButton();
            this.gridViewCTPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlCTPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.panelCTDonDatHang = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaiLaiDonDatHang = new System.Windows.Forms.ToolStripButton();
            this.btnXoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripPhieuNhap = new System.Windows.Forms.ToolStrip();
            this.panelDonDatHang = new System.Windows.Forms.Panel();
            this.gridControlPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStripCTPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTPhieuNhap)).BeginInit();
            this.panelCTDonDatHang.SuspendLayout();
            this.toolStripPhieuNhap.SuspendLayout();
            this.panelDonDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gray;
            this.splitter1.Location = new System.Drawing.Point(794, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 953);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // btnTaiLaiChiTiet
            // 
            this.btnTaiLaiChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLaiChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLaiChiTiet.Image = global::BanXeMayTTCS.Properties.Resources.reload;
            this.btnTaiLaiChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiLaiChiTiet.Name = "btnTaiLaiChiTiet";
            this.btnTaiLaiChiTiet.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnTaiLaiChiTiet.Size = new System.Drawing.Size(102, 32);
            this.btnTaiLaiChiTiet.Text = "Tải lại";
            this.btnTaiLaiChiTiet.Click += new System.EventHandler(this.btnTaiLaiChiTiet_Click);
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnSuaChiTiet.Image = global::BanXeMayTTCS.Properties.Resources.edit_free_icon_font_blue_24px;
            this.btnSuaChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSuaChiTiet.Size = new System.Drawing.Size(152, 32);
            this.btnSuaChiTiet.Text = "Sửa chi tiết";
            this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
            // 
            // toolStripCTPhieuNhap
            // 
            this.toolStripCTPhieuNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripCTPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCTPhieuNhap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCTPhieuNhap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCTPhieuNhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemChiTiet,
            this.btnSuaChiTiet,
            this.btnXoaChiTiet,
            this.btnTaiLaiChiTiet});
            this.toolStripCTPhieuNhap.Location = new System.Drawing.Point(0, 36);
            this.toolStripCTPhieuNhap.Name = "toolStripCTPhieuNhap";
            this.toolStripCTPhieuNhap.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.toolStripCTPhieuNhap.Size = new System.Drawing.Size(592, 51);
            this.toolStripCTPhieuNhap.TabIndex = 4;
            this.toolStripCTPhieuNhap.Text = "toolStrip1";
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnThemChiTiet.Image = global::BanXeMayTTCS.Properties.Resources.add_free_icon_font_blue_24px;
            this.btnThemChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThemChiTiet.Size = new System.Drawing.Size(170, 32);
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnXoaChiTiet.Image = global::BanXeMayTTCS.Properties.Resources.trash_free_icon_font_blue_24px;
            this.btnXoaChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnXoaChiTiet.Size = new System.Drawing.Size(153, 32);
            this.btnXoaChiTiet.Text = "Xóa chi tiết";
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // gridViewCTPhieuNhap
            // 
            this.gridViewCTPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCTPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.gridViewCTPhieuNhap.DetailHeight = 437;
            this.gridViewCTPhieuNhap.GridControl = this.gridControlCTPhieuNhap;
            this.gridViewCTPhieuNhap.Name = "gridViewCTPhieuNhap";
            this.gridViewCTPhieuNhap.OptionsBehavior.Editable = false;
            this.gridViewCTPhieuNhap.OptionsEditForm.PopupEditFormWidth = 889;
            // 
            // gridControlCTPhieuNhap
            // 
            this.gridControlCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridControlCTPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlCTPhieuNhap.Location = new System.Drawing.Point(0, 87);
            this.gridControlCTPhieuNhap.MainView = this.gridViewCTPhieuNhap;
            this.gridControlCTPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlCTPhieuNhap.Name = "gridControlCTPhieuNhap";
            this.gridControlCTPhieuNhap.Size = new System.Drawing.Size(592, 866);
            this.gridControlCTPhieuNhap.TabIndex = 2;
            this.gridControlCTPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTPhieuNhap});
            // 
            // panelCTDonDatHang
            // 
            this.panelCTDonDatHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCTDonDatHang.Controls.Add(this.gridControlCTPhieuNhap);
            this.panelCTDonDatHang.Controls.Add(this.toolStripCTPhieuNhap);
            this.panelCTDonDatHang.Controls.Add(this.label2);
            this.panelCTDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCTDonDatHang.Location = new System.Drawing.Point(794, 0);
            this.panelCTDonDatHang.Name = "panelCTDonDatHang";
            this.panelCTDonDatHang.Size = new System.Drawing.Size(592, 953);
            this.panelCTDonDatHang.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(9, 8, 0, 0);
            this.label2.Size = new System.Drawing.Size(228, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP";
            // 
            // btnTaiLaiDonDatHang
            // 
            this.btnTaiLaiDonDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLaiDonDatHang.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLaiDonDatHang.Image = global::BanXeMayTTCS.Properties.Resources.reload;
            this.btnTaiLaiDonDatHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiLaiDonDatHang.Name = "btnTaiLaiDonDatHang";
            this.btnTaiLaiDonDatHang.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnTaiLaiDonDatHang.Size = new System.Drawing.Size(102, 32);
            this.btnTaiLaiDonDatHang.Text = "Tải lại";
            this.btnTaiLaiDonDatHang.Click += new System.EventHandler(this.btnTaiLaiDonDatHang_Click);
            // 
            // btnXoaPhieuNhap
            // 
            this.btnXoaPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhieuNhap.Image = global::BanXeMayTTCS.Properties.Resources.trash_free_icon_font_blue_24px;
            this.btnXoaPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            this.btnXoaPhieuNhap.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnXoaPhieuNhap.Size = new System.Drawing.Size(192, 32);
            this.btnXoaPhieuNhap.Text = "Xóa phiếu nhập";
            this.btnXoaPhieuNhap.Click += new System.EventHandler(this.btnXoaPhieuNhap_Click);
            // 
            // toolStripPhieuNhap
            // 
            this.toolStripPhieuNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPhieuNhap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPhieuNhap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripPhieuNhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaPhieuNhap,
            this.btnTaiLaiDonDatHang});
            this.toolStripPhieuNhap.Location = new System.Drawing.Point(0, 36);
            this.toolStripPhieuNhap.Name = "toolStripPhieuNhap";
            this.toolStripPhieuNhap.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.toolStripPhieuNhap.Size = new System.Drawing.Size(794, 51);
            this.toolStripPhieuNhap.TabIndex = 3;
            this.toolStripPhieuNhap.Text = "toolStrip1";
            // 
            // panelDonDatHang
            // 
            this.panelDonDatHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDonDatHang.Controls.Add(this.gridControlPhieuNhap);
            this.panelDonDatHang.Controls.Add(this.toolStripPhieuNhap);
            this.panelDonDatHang.Controls.Add(this.label1);
            this.panelDonDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDonDatHang.Location = new System.Drawing.Point(0, 0);
            this.panelDonDatHang.Name = "panelDonDatHang";
            this.panelDonDatHang.Size = new System.Drawing.Size(794, 953);
            this.panelDonDatHang.TabIndex = 6;
            // 
            // gridControlPhieuNhap
            // 
            this.gridControlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridControlPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlPhieuNhap.Location = new System.Drawing.Point(0, 87);
            this.gridControlPhieuNhap.MainView = this.gridViewPhieuNhap;
            this.gridControlPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlPhieuNhap.Name = "gridControlPhieuNhap";
            this.gridControlPhieuNhap.Size = new System.Drawing.Size(794, 866);
            this.gridControlPhieuNhap.TabIndex = 2;
            this.gridControlPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhieuNhap});
            // 
            // gridViewPhieuNhap
            // 
            this.gridViewPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.gridViewPhieuNhap.DetailHeight = 437;
            this.gridViewPhieuNhap.GridControl = this.gridControlPhieuNhap;
            this.gridViewPhieuNhap.Name = "gridViewPhieuNhap";
            this.gridViewPhieuNhap.OptionsBehavior.Editable = false;
            this.gridViewPhieuNhap.OptionsEditForm.PopupEditFormWidth = 889;
            this.gridViewPhieuNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPhieuNhap_FocusedRowChanged);
            // 
            // FormQLPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 953);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelCTDonDatHang);
            this.Controls.Add(this.panelDonDatHang);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQLPhieuNhap";
            this.Text = "FormQLPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripCTPhieuNhap.ResumeLayout(false);
            this.toolStripCTPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTPhieuNhap)).EndInit();
            this.panelCTDonDatHang.ResumeLayout(false);
            this.panelCTDonDatHang.PerformLayout();
            this.toolStripPhieuNhap.ResumeLayout(false);
            this.toolStripPhieuNhap.PerformLayout();
            this.panelDonDatHang.ResumeLayout(false);
            this.panelDonDatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton btnTaiLaiChiTiet;
        private System.Windows.Forms.ToolStripButton btnSuaChiTiet;
        private System.Windows.Forms.ToolStrip toolStripCTPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTPhieuNhap;
        private DevExpress.XtraGrid.GridControl gridControlCTPhieuNhap;
        private System.Windows.Forms.Panel panelCTDonDatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnTaiLaiDonDatHang;
        private System.Windows.Forms.ToolStripButton btnXoaPhieuNhap;
        private System.Windows.Forms.ToolStrip toolStripPhieuNhap;
        private System.Windows.Forms.Panel panelDonDatHang;
        private DevExpress.XtraGrid.GridControl gridControlPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhieuNhap;
        private System.Windows.Forms.ToolStripButton btnThemChiTiet;
        private System.Windows.Forms.ToolStripButton btnXoaChiTiet;
    }
}