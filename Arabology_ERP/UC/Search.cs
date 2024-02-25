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
    public partial class Search : UserControl
    {
        public event EventHandler SearchTextChanged;
        public string searchText 
        {
            get
            {
                return txtSeach.Text;
            }
            set
            {
                txtSeach.Text = value;
            }
        }
        public string state 
        { 
            get
            {
                if (rbStratWith.Checked)
                {
                    return "Startwith";
                }
                else if (rbContains.Checked)
                {
                    return "Contains";
                }
                else
                {
                    return "Equal";
                }
            }
            
        }
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Search_Resize(object sender, EventArgs e)
        {
            txtSeach.Left = 0;
            txtSeach.Width = this.Width;
            groBoxseach.Left = 0;
            groBoxseach.Width = this.Width;
           
            
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextChanged != null)
            {
                SearchTextChanged.Invoke(this, e);
            }
        }

        private void rbStratWith_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStratWith.Checked)
            {
                txtSeach_TextChanged(sender, e);
            }
        }

        private void rbContains_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContains.Checked)
            {
                txtSeach_TextChanged(sender, e);
            }
        }

        private void rbEqual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEqual.Checked)
            {
                txtSeach_TextChanged(sender, e);
            }
        }
    }
}
