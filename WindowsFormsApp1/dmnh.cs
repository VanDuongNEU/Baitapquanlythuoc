using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dmnh : Form
    {
        public dmnh()
        {
            InitializeComponent();
        }

        private void dmnh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHTDataSet.tblQLNT' table. You can move, or remove it, as needed.
            this.tblQLNTTableAdapter.Fill(this.qLNHTDataSet.tblQLNT);

        }
    }
}
