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
    public partial class FRM_Model : Form
    {
        public FRM_Model()
        {
            InitializeComponent();
        }

        private void branches1_Load(object sender, EventArgs e)
        {

        }

        private void brNameA1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Drawing.Rectangle workingrectangle = Screen.PrimaryScreen.WorkingArea;
            //this.Size = new System.Drawing.Size(Convert.ToInt32(0.65 * workingrectangle.Width),
            //    Convert.ToInt32(0.75 * workingrectangle.Height));
            //this.Location = new System.Drawing.Point(10, 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search1_Load(object sender, EventArgs e)
        {

        }

        private void search2_SearchTextChanged(object sender, EventArgs e)
        {
            textBox1.Text = search2.state;
        }
    }
}
