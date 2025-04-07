
namespace BanXeMayTTCS.GUI
{
    partial class FormRestoreLog
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
            this.dateRestore = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateRestore
            // 
            this.dateRestore.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRestore.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateRestore.Location = new System.Drawing.Point(29, 55);
            this.dateRestore.MaxDate = new System.DateTime(2022, 6, 4, 17, 34, 46, 0);
            this.dateRestore.Name = "dateRestore";
            this.dateRestore.Size = new System.Drawing.Size(297, 30);
            this.dateRestore.TabIndex = 0;
            this.dateRestore.Value = new System.DateTime(2022, 6, 4, 0, 0, 0, 0);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(507, 45);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 51);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Restore";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(332, 55);
            this.timePicker.MaxDate = new System.DateTime(2022, 6, 4, 17, 34, 46, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(151, 30);
            this.timePicker.TabIndex = 2;
            this.timePicker.Value = new System.DateTime(2022, 6, 4, 0, 0, 0, 0);
            // 
            // FormRestoreLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 157);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dateRestore);
            this.Name = "FormRestoreLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỊCH SỬ SAO LƯU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateRestore;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}