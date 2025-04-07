using BanXeMayTTCS.DAO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.GUI
{
    public partial class FormRestoreLog : DevExpress.XtraEditors.XtraForm
    {
        public FormRestoreLog()
        {
            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            loadDataDate();
        }

        private void loadDataDate()
        {
            dateRestore.MaxDate = DateTime.Now;
            timePicker.MaxDate = DateTime.Now;
            timePicker.Value = DateTime.Now;
            dateRestore.Value = DateTime.Now;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime restoreDate = dateRestore.Value.Date +
                timePicker.Value.TimeOfDay;
            string restoreDateTime = restoreDate.ToString("yyyy-MM-dd HH:mm:ss");
            if (BackupDAO.Instance.TransactionLogRestore(restoreDateTime))
            {
                MessageBox.Show("Restore từ transaction log thành công");
            }
            else
            {
                MessageBox.Show("Restore từ transaction log thất bại");
            }
            return;
        }
    }
}