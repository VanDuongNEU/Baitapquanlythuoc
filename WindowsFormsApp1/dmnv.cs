using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class dmnv : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dtnv = new DataTable();
        string sql, constr;
        int i;
        public dmnv()
        {
            InitializeComponent();
        }

        private void dmnv_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-ABOQEK5\\BTLQLNT;" +
                "Initial Catalog = QLNHT; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from tblNhanVien";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dtnv);
            grddatanv.DataSource = dtnv;
            NapCT();
        }

      

       
        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grddatanv_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMANV.Focus();
                return;
            }
            if (dtnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NapCT();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void grddatanv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        private void NapCT()
        {
            i = grddatanv.CurrentRow.Index;
            //nhan gia tri chi so cua ban ghi hien thoi
            txtMANV.Text = grddatanv.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTenNV.Text = grddatanv.CurrentRow.Cells["TenNhanVien"].Value.ToString();

            if (grddatanv.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                ckbNam.Checked = true;
                ckbNu.Checked = false;

            }
            if (grddatanv.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nữ")
            {
                ckbNu.Checked = true;
                ckbNam.Checked = false;
            }
            txtDiaChi.Text = grddatanv.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = grddatanv.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtNgaySinh.Text = grddatanv.CurrentRow.Cells["NgaySinh"].Value.ToString();
        }

    }
}
