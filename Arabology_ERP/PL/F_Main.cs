﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arabology_ERP.PL;

namespace Arabology_ERP.PL
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
            Inventory.F_Items frm = new Inventory.F_Items();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
