
namespace WindowsFormsApp1
{
    partial class dmnh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãMedisoftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênThuốcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnVịTínhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giáVNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hãngSảnXuấtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nướcSảnXuấtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQLNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHTDataSet = new WindowsFormsApp1.QLNHTDataSet();
            this.tblQLNTTableAdapter = new WindowsFormsApp1.QLNHTDataSetTableAdapters.tblQLNTTableAdapter();
            this.bntClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQLNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mãMedisoftDataGridViewTextBoxColumn,
            this.tênThuốcDataGridViewTextBoxColumn,
            this.đơnVịTínhDataGridViewTextBoxColumn,
            this.giáVNDDataGridViewTextBoxColumn,
            this.hãngSảnXuấtDataGridViewTextBoxColumn,
            this.nướcSảnXuấtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblQLNTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mãMedisoftDataGridViewTextBoxColumn
            // 
            this.mãMedisoftDataGridViewTextBoxColumn.DataPropertyName = "Mã Medisoft";
            this.mãMedisoftDataGridViewTextBoxColumn.HeaderText = "Mã Medisoft";
            this.mãMedisoftDataGridViewTextBoxColumn.Name = "mãMedisoftDataGridViewTextBoxColumn";
            // 
            // tênThuốcDataGridViewTextBoxColumn
            // 
            this.tênThuốcDataGridViewTextBoxColumn.DataPropertyName = "Tên thuốc";
            this.tênThuốcDataGridViewTextBoxColumn.HeaderText = "Tên thuốc";
            this.tênThuốcDataGridViewTextBoxColumn.Name = "tênThuốcDataGridViewTextBoxColumn";
            // 
            // đơnVịTínhDataGridViewTextBoxColumn
            // 
            this.đơnVịTínhDataGridViewTextBoxColumn.DataPropertyName = "Đơn vị tính";
            this.đơnVịTínhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.đơnVịTínhDataGridViewTextBoxColumn.Name = "đơnVịTínhDataGridViewTextBoxColumn";
            // 
            // giáVNDDataGridViewTextBoxColumn
            // 
            this.giáVNDDataGridViewTextBoxColumn.DataPropertyName = "Giá (VND)";
            this.giáVNDDataGridViewTextBoxColumn.HeaderText = "Giá (VND)";
            this.giáVNDDataGridViewTextBoxColumn.Name = "giáVNDDataGridViewTextBoxColumn";
            // 
            // hãngSảnXuấtDataGridViewTextBoxColumn
            // 
            this.hãngSảnXuấtDataGridViewTextBoxColumn.DataPropertyName = "Hãng sản xuất";
            this.hãngSảnXuấtDataGridViewTextBoxColumn.HeaderText = "Hãng sản xuất";
            this.hãngSảnXuấtDataGridViewTextBoxColumn.Name = "hãngSảnXuấtDataGridViewTextBoxColumn";
            // 
            // nướcSảnXuấtDataGridViewTextBoxColumn
            // 
            this.nướcSảnXuấtDataGridViewTextBoxColumn.DataPropertyName = "Nước sản xuất";
            this.nướcSảnXuấtDataGridViewTextBoxColumn.HeaderText = "Nước sản xuất";
            this.nướcSảnXuấtDataGridViewTextBoxColumn.Name = "nướcSảnXuấtDataGridViewTextBoxColumn";
            // 
            // tblQLNTBindingSource
            // 
            this.tblQLNTBindingSource.DataMember = "tblQLNT";
            this.tblQLNTBindingSource.DataSource = this.qLNHTDataSet;
            // 
            // qLNHTDataSet
            // 
            this.qLNHTDataSet.DataSetName = "QLNHTDataSet";
            this.qLNHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQLNTTableAdapter
            // 
            this.tblQLNTTableAdapter.ClearBeforeFill = true;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(690, 415);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 21;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dmnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dmnh";
            this.Text = "dmnh";
            this.Load += new System.EventHandler(this.dmnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQLNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHTDataSet qLNHTDataSet;
        private System.Windows.Forms.BindingSource tblQLNTBindingSource;
        private QLNHTDataSetTableAdapters.tblQLNTTableAdapter tblQLNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãMedisoftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênThuốcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnVịTínhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giáVNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hãngSảnXuấtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nướcSảnXuấtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}