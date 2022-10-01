namespace WindowsFormsApp1
{
    partial class frmmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuVàPhụcHồiDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.saoLưuVàPhụcHồiDữLiệuToolStripMenuItem,
            this.kếtThúcChươngTrìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống ";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            // 
            // saoLưuVàPhụcHồiDữLiệuToolStripMenuItem
            // 
            this.saoLưuVàPhụcHồiDữLiệuToolStripMenuItem.Name = "saoLưuVàPhụcHồiDữLiệuToolStripMenuItem";
            this.saoLưuVàPhụcHồiDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.saoLưuVàPhụcHồiDữLiệuToolStripMenuItem.Text = "Sao lưu và phục hồi dữ liệu";
            // 
            // kếtThúcChươngTrìnhToolStripMenuItem
            // 
            this.kếtThúcChươngTrìnhToolStripMenuItem.Name = "kếtThúcChươngTrìnhToolStripMenuItem";
            this.kếtThúcChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.kếtThúcChươngTrìnhToolStripMenuItem.Text = "Kết thúc chương trình";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Phần mềm quản lý thuốc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuVàPhụcHồiDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcChươngTrìnhToolStripMenuItem;
    }
}

