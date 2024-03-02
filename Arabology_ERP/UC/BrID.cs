using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNew
{
    public partial class BrID : UserControl
    {
        public BrID()
        {
            InitializeComponent();
        }


        private void Branches_Resize(object sender, EventArgs e)
        {
            txtBrId.Left = 0;
            lblBrId.Left = txtBrId.Width;
            lblBrId.Width = this.Width - txtBrId.Width;
            txtBrId.Enabled = false;
        }

        private void lblBrId_Click(object sender, EventArgs e)
        {

        }
    }
}
