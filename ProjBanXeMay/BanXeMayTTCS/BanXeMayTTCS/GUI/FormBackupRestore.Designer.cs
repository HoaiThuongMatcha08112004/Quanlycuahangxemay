
namespace BanXeMayTTCS.GUI
{
    partial class FormBackupRestore
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
            this.gridControlBK = new DevExpress.XtraGrid.GridControl();
            this.gridViewBK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbBackupType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRestoreType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBK)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBK
            // 
            this.gridControlBK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlBK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControlBK.Location = new System.Drawing.Point(0, 0);
            this.gridControlBK.MainView = this.gridViewBK;
            this.gridControlBK.Margin = new System.Windows.Forms.Padding(6);
            this.gridControlBK.Name = "gridControlBK";
            this.gridControlBK.Size = new System.Drawing.Size(1229, 562);
            this.gridControlBK.TabIndex = 0;
            this.gridControlBK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBK});
            // 
            // gridViewBK
            // 
            this.gridViewBK.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBK.Appearance.Row.Options.UseFont = true;
            this.gridViewBK.DetailHeight = 437;
            this.gridViewBK.GridControl = this.gridControlBK;
            this.gridViewBK.Name = "gridViewBK";
            this.gridViewBK.OptionsBehavior.Editable = false;
            // 
            // cmbBackupType
            // 
            this.cmbBackupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupType.FormattingEnabled = true;
            this.cmbBackupType.Location = new System.Drawing.Point(127, 611);
            this.cmbBackupType.Name = "cmbBackupType";
            this.cmbBackupType.Size = new System.Drawing.Size(221, 36);
            this.cmbBackupType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(382, 600);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(128, 45);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Submit";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(1014, 603);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(128, 45);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Submit";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Restore";
            // 
            // cmbRestoreType
            // 
            this.cmbRestoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestoreType.FormattingEnabled = true;
            this.cmbRestoreType.Location = new System.Drawing.Point(759, 614);
            this.cmbRestoreType.Name = "cmbRestoreType";
            this.cmbRestoreType.Size = new System.Drawing.Size(221, 36);
            this.cmbRestoreType.TabIndex = 4;
            // 
            // FormBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 685);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRestoreType);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBackupType);
            this.Controls.Add(this.gridControlBK);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBackupRestore";
            this.Text = "FormBackupRestore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBK;
        private System.Windows.Forms.ComboBox cmbBackupType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRestoreType;
    }
}