using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNew.UsCo
{
    public partial class BrInAc : UserControl
    {
        public BrInAc()
        {
            InitializeComponent();
        }

        private void lblInActive_Click(object sender, EventArgs e)
        {
           

        }

        private void BrInAc_Resize(object sender, EventArgs e)
        {
            chInActive.Left = 0;
            lblInActive.Left = chInActive.Width;
            chInActive.Width = this.Width - lblInActive.Width;
        }
    }
}
