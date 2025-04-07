using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    class BackupHistory
    {
        private string backupBatDau;
        private string backupXong;
        private string loai;

        public BackupHistory(string backupBatDau, string backupXong, string loai)
        {
            this.backupBatDau = backupBatDau;
            this.backupXong = backupXong;
            this.loai = loai;
        }

        public string BackupBatDau { get => backupBatDau; set => backupBatDau = value; }
        public string BackupXong { get => backupXong; set => backupXong = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
