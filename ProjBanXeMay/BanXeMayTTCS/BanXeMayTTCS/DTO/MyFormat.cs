using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BanXeMayTTCS.DTO
{
    public class MyFormat
    {
        public static string PATH_RESOURCE = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Image\\";
        public static string PATH_BACKUP = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Backup\\";

        public static string GetFilePath(string tenFile)
        {
            return PATH_RESOURCE + tenFile;
        }
        public static string FormatMoney(decimal money)
        {
            return String.Format("{0:n0}", money);
        }
        public static bool IsEmail(string text)
        {
            try
            {
                MailAddress m = new MailAddress(text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
