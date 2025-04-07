
namespace BanXeMayTTCS.GUI.CustomComponent
{
    partial class ItemGioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGioHang));
            this.picXeMay = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbHang = new System.Windows.Forms.Label();
            this.lbNhaCc = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.cbDatHang = new System.Windows.Forms.CheckBox();
            this.numSl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picXeMay)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSl)).BeginInit();
            this.SuspendLayout();
            // 
            // picXeMay
            // 
            this.picXeMay.Dock = System.Windows.Forms.DockStyle.Left;
            this.picXeMay.Image = ((System.Drawing.Image)(resources.GetObject("picXeMay.Image")));
            this.picXeMay.Location = new System.Drawing.Point(0, 0);
            this.picXeMay.Name = "picXeMay";
            this.picXeMay.Size = new System.Drawing.Size(263, 259);
            this.picXeMay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXeMay.TabIndex = 2;
            this.picXeMay.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.lbTen);
            this.flowLayoutPanel1.Controls.Add(this.lbGia);
            this.flowLayoutPanel1.Controls.Add(this.lbLoai);
            this.flowLayoutPanel1.Controls.Add(this.lbHang);
            this.flowLayoutPanel1.Controls.Add(this.lbNhaCc);
            this.flowLayoutPanel1.Controls.Add(this.lbTrangThai);
            this.flowLayoutPanel1.Controls.Add(this.lbMoTa);
            this.flowLayoutPanel1.Controls.Add(this.numSl);
            this.flowLayoutPanel1.Controls.Add(this.cbDatHang);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(263, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 259);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(12, 11);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(254, 32);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Xe máy thông minh";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(12, 43);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(156, 23);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá: 1,000,000 VNĐ";
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoai.Location = new System.Drawing.Point(12, 66);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(143, 23);
            this.lbLoai.TabIndex = 5;
            this.lbLoai.Text = "Loại: Thông minh";
            // 
            // lbHang
            // 
            this.lbHang.AutoSize = true;
            this.lbHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHang.Location = new System.Drawing.Point(12, 89);
            this.lbHang.Name = "lbHang";
            this.lbHang.Size = new System.Drawing.Size(132, 23);
            this.lbHang.TabIndex = 6;
            this.lbHang.Text = "Hãng: SamSung";
            // 
            // lbNhaCc
            // 
            this.lbNhaCc.AutoSize = true;
            this.lbNhaCc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCc.Location = new System.Drawing.Point(12, 112);
            this.lbNhaCc.Name = "lbNhaCc";
            this.lbNhaCc.Size = new System.Drawing.Size(251, 23);
            this.lbNhaCc.TabIndex = 7;
            this.lbNhaCc.Text = "Nhà cung cấp: Thế giới di động";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(12, 135);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(168, 23);
            this.lbTrangThai.TabIndex = 4;
            this.lbTrangThai.Text = "Trạng thái: còn hàng";
            // 
            // lbMoTa
            // 
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTa.Location = new System.Drawing.Point(12, 158);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(188, 23);
            this.lbMoTa.TabIndex = 3;
            this.lbMoTa.Text = "Mô tả: chỉ dành cho nữ";
            // 
            // cbDatHang
            // 
            this.cbDatHang.AutoSize = true;
            this.cbDatHang.Location = new System.Drawing.Point(12, 224);
            this.cbDatHang.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cbDatHang.Name = "cbDatHang";
            this.cbDatHang.Size = new System.Drawing.Size(18, 17);
            this.cbDatHang.TabIndex = 8;
            this.cbDatHang.UseVisualStyleBackColor = true;
            this.cbDatHang.CheckedChanged += new System.EventHandler(this.cbDatHang_CheckedChanged);
            // 
            // numSl
            // 
            this.numSl.Location = new System.Drawing.Point(12, 184);
            this.numSl.Name = "numSl";
            this.numSl.Size = new System.Drawing.Size(120, 34);
            this.numSl.TabIndex = 9;
            this.numSl.ValueChanged += new System.EventHandler(this.numSl_ValueChanged);
            // 
            // ItemGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picXeMay);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemGioHang";
            this.Size = new System.Drawing.Size(623, 259);
            ((System.ComponentModel.ISupportInitialize)(this.picXeMay)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picXeMay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbHang;
        private System.Windows.Forms.Label lbNhaCc;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.CheckBox cbDatHang;
        private System.Windows.Forms.NumericUpDown numSl;
    }
}
