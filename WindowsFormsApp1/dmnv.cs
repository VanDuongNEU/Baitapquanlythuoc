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
    public partial class dmnv : Form
    {
        public dmnv()
        {
            InitializeComponent();
        }

        private void dmnv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHTDataSet1.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.qLNHTDataSet1.tblNhanVien);
            // TODO: This line of code loads data into the 'qLNHTDataSet.tblQLNT' table. You can move, or remove it, as needed.
            this.tblQLNTTableAdapter.Fill(this.qLNHTDataSet.tblQLNT);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
