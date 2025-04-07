
namespace BanXeMayTTCS.GUI
{
    partial class FormMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelOption = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnQLXeMay = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelOption.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelOption);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 702);
            this.panelMenu.TabIndex = 0;
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.panelOption.Controls.Add(this.btnQLXeMay);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOption.ForeColor = System.Drawing.Color.White;
            this.panelOption.Location = new System.Drawing.Point(0, 200);
            this.panelOption.Name = "panelOption";
            this.panelOption.Padding = new System.Windows.Forms.Padding(8);
            this.panelOption.Size = new System.Drawing.Size(270, 502);
            this.panelOption.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(270, 200);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(270, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(806, 702);
            this.panelContainer.TabIndex = 1;
            // 
            // btnQLXeMay
            // 
            this.btnQLXeMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLXeMay.FlatAppearance.BorderSize = 0;
            this.btnQLXeMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXeMay.Image = global::BanXeMayTTCS.Properties.Resources.clock_five_free_icon_font_white_24px;
            this.btnQLXeMay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMay.Location = new System.Drawing.Point(8, 8);
            this.btnQLXeMay.Name = "btnQLXeMay";
            this.btnQLXeMay.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQLXeMay.Size = new System.Drawing.Size(254, 59);
            this.btnQLXeMay.TabIndex = 0;
            this.btnQLXeMay.Text = "        Quản lý xe máy";
            this.btnQLXeMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLXeMay.UseVisualStyleBackColor = true;
            this.btnQLXeMay.Click += new System.EventHandler(this.btnQLXeMay_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::BanXeMayTTCS.Properties.Resources._500_500_breguet_new;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(270, 200);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 702);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelOption.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnQLXeMay;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}