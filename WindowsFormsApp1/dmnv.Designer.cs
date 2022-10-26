
namespace WindowsFormsApp1
{
    partial class dmnv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMANV = new System.Windows.Forms.Label();
            this.labelTENNV = new System.Windows.Forms.Label();
            this.labelGIOITINH = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelDienThoai = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.ckbNam = new System.Windows.Forms.CheckBox();
            this.ckbNu = new System.Windows.Forms.CheckBox();
            this.txtDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.grddatanv = new System.Windows.Forms.DataGridView();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHTDataSet1 = new WindowsFormsApp1.QLNHTDataSet1();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.qLNHTDataSet = new WindowsFormsApp1.QLNHTDataSet();
            this.qLNHTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQLNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQLNTTableAdapter = new WindowsFormsApp1.QLNHTDataSetTableAdapters.tblQLNTTableAdapter();
            this.tblQLNTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanVienTableAdapter = new WindowsFormsApp1.QLNHTDataSet1TableAdapters.tblNhanVienTableAdapter();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grddatanv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQLNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQLNTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMANV
            // 
            this.labelMANV.AutoSize = true;
            this.labelMANV.Location = new System.Drawing.Point(8, 15);
            this.labelMANV.Name = "labelMANV";
            this.labelMANV.Size = new System.Drawing.Size(72, 13);
            this.labelMANV.TabIndex = 0;
            this.labelMANV.Text = "Mã nhân viên";
            // 
            // labelTENNV
            // 
            this.labelTENNV.AutoSize = true;
            this.labelTENNV.Location = new System.Drawing.Point(8, 46);
            this.labelTENNV.Name = "labelTENNV";
            this.labelTENNV.Size = new System.Drawing.Size(76, 13);
            this.labelTENNV.TabIndex = 1;
            this.labelTENNV.Text = "Tên nhân viên";
            // 
            // labelGIOITINH
            // 
            this.labelGIOITINH.AutoSize = true;
            this.labelGIOITINH.Location = new System.Drawing.Point(12, 75);
            this.labelGIOITINH.Name = "labelGIOITINH";
            this.labelGIOITINH.Size = new System.Drawing.Size(47, 13);
            this.labelGIOITINH.TabIndex = 2;
            this.labelGIOITINH.Text = "Giới tính";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(223, 15);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(40, 13);
            this.labelDiaChi.TabIndex = 3;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // labelDienThoai
            // 
            this.labelDienThoai.AutoSize = true;
            this.labelDienThoai.Location = new System.Drawing.Point(222, 46);
            this.labelDienThoai.Name = "labelDienThoai";
            this.labelDienThoai.Size = new System.Drawing.Size(55, 13);
            this.labelDienThoai.TabIndex = 4;
            this.labelDienThoai.Text = "Điện thoại";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(222, 82);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.labelNgaySinh.TabIndex = 5;
            this.labelNgaySinh.Text = "Ngày sinh";
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(90, 8);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(103, 20);
            this.txtMANV.TabIndex = 6;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(90, 39);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(282, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // ckbNam
            // 
            this.ckbNam.AutoSize = true;
            this.ckbNam.Location = new System.Drawing.Point(77, 71);
            this.ckbNam.Name = "ckbNam";
            this.ckbNam.Size = new System.Drawing.Size(48, 17);
            this.ckbNam.TabIndex = 9;
            this.ckbNam.Text = "Nam";
            this.ckbNam.UseVisualStyleBackColor = true;
            // 
            // ckbNu
            // 
            this.ckbNu.AutoSize = true;
            this.ckbNu.Location = new System.Drawing.Point(77, 94);
            this.ckbNu.Name = "ckbNu";
            this.ckbNu.Size = new System.Drawing.Size(40, 17);
            this.ckbNu.TabIndex = 10;
            this.ckbNu.Text = "Nữ";
            this.ckbNu.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(282, 39);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienThoai.TabIndex = 11;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(286, 75);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(96, 20);
            this.txtNgaySinh.TabIndex = 12;
            // 
            // grddatanv
            // 
            this.grddatanv.AutoGenerateColumns = false;
            this.grddatanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddatanv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.GioiTinh,
            this.DiaChi,
            this.DienThoai,
            this.NgaySinh});
            this.grddatanv.DataSource = this.tblNhanVienBindingSource;
            this.grddatanv.Location = new System.Drawing.Point(15, 149);
            this.grddatanv.Name = "grddatanv";
            this.grddatanv.Size = new System.Drawing.Size(662, 243);
            this.grddatanv.TabIndex = 13;
            this.grddatanv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddatanv_CellContentClick);
            this.grddatanv.Click += new System.EventHandler(this.grddatanv_Click);
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.qLNHTDataSet1;
            // 
            // qLNHTDataSet1
            // 
            this.qLNHTDataSet1.DataSetName = "QLNHTDataSet1";
            this.qLNHTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(115, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(225, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(602, 415);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 17;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // qLNHTDataSet
            // 
            this.qLNHTDataSet.DataSetName = "QLNHTDataSet";
            this.qLNHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNHTDataSetBindingSource
            // 
            this.qLNHTDataSetBindingSource.DataSource = this.qLNHTDataSet;
            this.qLNHTDataSetBindingSource.Position = 0;
            // 
            // tblQLNTBindingSource
            // 
            this.tblQLNTBindingSource.DataMember = "tblQLNT";
            this.tblQLNTBindingSource.DataSource = this.qLNHTDataSetBindingSource;
            // 
            // tblQLNTTableAdapter
            // 
            this.tblQLNTTableAdapter.ClearBeforeFill = true;
            // 
            // tblQLNTBindingSource1
            // 
            this.tblQLNTBindingSource1.DataMember = "tblQLNT";
            this.tblQLNTBindingSource1.DataSource = this.qLNHTDataSetBindingSource;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // dmnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grddatanv);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.ckbNu);
            this.Controls.Add(this.ckbNam);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelDienThoai);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelGIOITINH);
            this.Controls.Add(this.labelTENNV);
            this.Controls.Add(this.labelMANV);
            this.Name = "dmnv";
            this.Text = "dmnv";
            this.Load += new System.EventHandler(this.dmnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddatanv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQLNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQLNTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMANV;
        private System.Windows.Forms.Label labelTENNV;
        private System.Windows.Forms.Label labelGIOITINH;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelDienThoai;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox ckbNam;
        private System.Windows.Forms.CheckBox ckbNu;
        private System.Windows.Forms.MaskedTextBox txtDienThoai;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.DataGridView grddatanv;
        private System.Windows.Forms.BindingSource qLNHTDataSetBindingSource;
        private QLNHTDataSet qLNHTDataSet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.BindingSource tblQLNTBindingSource;
        private QLNHTDataSetTableAdapters.tblQLNTTableAdapter tblQLNTTableAdapter;
        private System.Windows.Forms.BindingSource tblQLNTBindingSource1;
        private QLNHTDataSet1 qLNHTDataSet1;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QLNHTDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}