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
        Boolean addNewFlag = false;
        string gt;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            sql = "select * from tblNhanVien order by MaNhanVien";
            da = new SqlDataAdapter(sql, conn);
            dtnv.Clear();
            da.Fill(dtnv);
            grddatanv.DataSource = dtnv;
            NapCT();

            grddatanv.CurrentCell = grddatanv[0, grddatanv.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, khi kết thúc bấm Cập Nhật!");
            txtMANV.Focus();
            addNewFlag = true;
            btnCapnhat.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
           
            if (addNewFlag == false)
            {
                //cap nhat sua chua
                for (i = 0; i < grddatanv.Rows.Count - 1; i++)
                {
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
                    if (ckbNam.Checked == true)
                        gt = "Nam";
                    if (ckbNu.Checked == true)
                        gt = "Nữ";
                    sql = "update tblNhanVien set TenNhanVien=N'"
                        + txtTenNV.Text + "',GioiTinh=N'" + gt
                        + "',DiaChi='" + txtDiaChi.Text
                        + "',DienThoai=N'" + txtDienThoai.Text
                        + "',NgaySinh=N'" + txtNgaySinh.Text
                        + "' Where MaNhanVien='" + txtMANV.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                //nhan gia tri chi so cua ban ghi hien thoi
                MessageBox.Show("Da cap nhat thanh cong", "Thong bao");

            }
            else
            {
                if (ckbNam.Checked == true)
                    gt = "Nam";
                if (ckbNu.Checked == true)
                    gt = "Nữ";
                // cap nhap them moi
                addNewFlag = false;
                sql = "INSERT INTO tblNhanVien(MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh) VALUES (N'" + txtMANV.Text + "',N'" + txtTenNV.Text + "',N'" + gt + "',N'" + txtDiaChi.Text 
                    + "','" + txtDienThoai.Text + "','" + txtNgaySinh.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                
                grddatanv.Rows[i].Cells["MaNhanVien"].Value = txtMANV.Text;
                grddatanv.Rows[i].Cells["TenNhanVien"].Value = txtTenNV.Text;
                grddatanv.Rows[i].Cells["GioiTinh"].Value = ckbNam.Text;
                grddatanv.Rows[i].Cells["GioiTinh"].Value = ckbNu.Text;
                grddatanv.Rows[i].Cells["DiaChi"].Value = txtDiaChi.Text;
                grddatanv.Rows[i].Cells["DienThoai"].Value = txtDienThoai.Text;
                grddatanv.Rows[i].Cells["NgaySinh"].Value = txtNgaySinh.Text;
                grddatanv.Refresh();
            }
            btnCapnhat.Enabled = false;
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
