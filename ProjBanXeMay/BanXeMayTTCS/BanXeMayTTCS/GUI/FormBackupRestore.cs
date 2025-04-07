using BanXeMayTTCS.DAO;
using BanXeMayTTCS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel; // thiết kế và triển khai các thành phần trong ứng dụng,lk giữa đối tượng và giao diện ng dùng
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.GUI
{
    public partial class FormBackupRestore : Form
    {
        private List<BackupHistory> listBKHistory;
        private BindingSource bindingSource = new BindingSource();
        public FormBackupRestore()
        {
            InitializeComponent();// thường tự động được tạo
            LoadData();
            LoadUI();
        }

    // Tải DL từ csdl (gridControlBK) và hiển thị lên giao diện
        private void LoadData()
        {
            listBKHistory = BackupDAO.Instance.GetListBackupHistory();
            //Gán danh sách listBKHistory làm nguồn dữ liệu (DataSource) cho bindingSource
            //bindingSource sẽ quản lý danh sách listBKHistory
            //cung cấp dữ liệu cho các thành phần giao diện được liên kết với nó.
            bindingSource.DataSource = listBKHistory;
            gridControlBK.DataSource = bindingSource;
            // =>gridControlBK được liên kết với bindingSource, sẽ hiển thị ds listBKHistory
            // mỗi cột trong gridControlBK tương ứng với một thuộc tính của lớp BackupHistory
            bindingSource.Position = 0;  
        }

        private void LoadUI()
        {
            //Backup Types
            List<string> backupTypes = new List<string>
            {
                "Full Backup",
                "Differential Backup",
                "Transaction Log Backup"
            };
            //gán ds backupTypes làm nguồn DL cho cmbBackupType
            cmbBackupType.DataSource = backupTypes;

            //Restore Type
            List<string> restoreTypes = new List<string>
            {
                "Full Restore",
                "Differential Restore",
                "Transaction Log Restore"
            };
            cmbRestoreType.DataSource = restoreTypes;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string backupType = cmbBackupType.SelectedValue.ToString();
            if(backupType.Equals("Full Backup"))
            {
                if(BackupDAO.Instance.FullBackup())
                {
                    MessageBox.Show("Backup Full thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                    return;
                }
            }
            else if (backupType.Equals("Differential Backup"))
            {
                if (BackupDAO.Instance.DifferentialBackup())
                {
                    MessageBox.Show("Backup Differential thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                    return;
                }
            }
            else
            {
                if (    BackupDAO.Instance.TransactionLogBackup())
                {
                    MessageBox.Show("Backup Log thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                    return;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.SetConnectionStrRestore();
            string restoreType = cmbRestoreType.SelectedValue.ToString();
            if (restoreType.Equals("Full Restore"))
            {
                //full
                if (BackupDAO.Instance.FullRestore())
                {
                    MessageBox.Show("Restore Full thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (restoreType.Equals("Differential Restore"))
            {
                //diff
                if (BackupDAO.Instance.DifferentialRestore())
                {
                    MessageBox.Show("Restore Differential thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //log
                FormRestoreLog formLog = new FormRestoreLog();
                formLog.ShowDialog();
            }
            DataProvider.Instance.SetConnectionStrNhanVien();
        }
    }
}
