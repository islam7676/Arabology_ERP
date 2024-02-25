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
    public partial class BrNameA : UserControl
    {
        public BrNameA()
        {
            InitializeComponent();
        }

        private void Branches2_Resize(object sender, EventArgs e)
        {
            txtBrNameA.Left = 0;
            txtBrNameA.Width = this.Width - lblBrNameA.Width;
            lblBrNameA.Left = txtBrNameA.Width;
        }

        private void lblBranchNameA_Click(object sender, EventArgs e)
        {
          
        }
    }
}
