
namespace BanXeMayTTCS.GUI.CustomComponent
{
    partial class ItemDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDatHang));
            this.picSp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbSl = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSp)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSp
            // 
            this.picSp.Dock = System.Windows.Forms.DockStyle.Left;
            this.picSp.Image = ((System.Drawing.Image)(resources.GetObject("picSp.Image")));
            this.picSp.Location = new System.Drawing.Point(0, 0);
            this.picSp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSp.Name = "picSp";
            this.picSp.Size = new System.Drawing.Size(85, 104);
            this.picSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSp.TabIndex = 1;
            this.picSp.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbTen);
            this.flowLayoutPanel1.Controls.Add(this.lbSl);
            this.flowLayoutPanel1.Controls.Add(this.lbGia);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(85, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 104);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(4, 0);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(105, 28);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Xe máy 1";
            // 
            // lbSl
            // 
            this.lbSl.AutoSize = true;
            this.lbSl.Location = new System.Drawing.Point(4, 28);
            this.lbSl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSl.Name = "lbSl";
            this.lbSl.Size = new System.Drawing.Size(32, 28);
            this.lbSl.TabIndex = 1;
            this.lbSl.Text = "x1";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(4, 56);
            this.lbGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(95, 28);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Tổng tiền";
            // 
            // ItemDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picSp);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemDatHang";
            this.Size = new System.Drawing.Size(297, 104);
            ((System.ComponentModel.ISupportInitialize)(this.picSp)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbSl;
        private System.Windows.Forms.Label lbGia;
    }
}
