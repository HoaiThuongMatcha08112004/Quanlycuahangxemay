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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void MoFormCon(Form formCon)
        {
            if (!panelContainer.Controls.Contains(formCon))
            {
                formCon.TopLevel = false;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(formCon);
                formCon.Show();
            }
        }
        private void btnQLXeMay_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormQLXeMay());
        }
    }
}
