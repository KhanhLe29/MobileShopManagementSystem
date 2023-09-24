namespace MobileShop
{
    partial class frmKhoHang_Admin
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "SP01",
            "Tai Nghe",
            "700",
            "24/7/2003"}, -1);
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.btn_XoaHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsv_Main = new System.Windows.Forms.ListView();
            this.masp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaynhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Location = new System.Drawing.Point(168, 687);
            this.btn_NhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(130, 69);
            this.btn_NhapHang.TabIndex = 2;
            this.btn_NhapHang.Text = "Nhập Hàng";
            this.btn_NhapHang.UseVisualStyleBackColor = true;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // btn_XoaHang
            // 
            this.btn_XoaHang.Location = new System.Drawing.Point(567, 687);
            this.btn_XoaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XoaHang.Name = "btn_XoaHang";
            this.btn_XoaHang.Size = new System.Drawing.Size(159, 69);
            this.btn_XoaHang.TabIndex = 4;
            this.btn_XoaHang.Text = "Xóa SP Trong Kho";
            this.btn_XoaHang.UseVisualStyleBackColor = true;
            this.btn_XoaHang.Click += new System.EventHandler(this.btn_XoaHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsv_Main);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(943, 478);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm có trong kho";
            // 
            // lsv_Main
            // 
            this.lsv_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masp,
            this.tensp,
            this.slton,
            this.ngaynhap});
            this.lsv_Main.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_Main.FullRowSelect = true;
            this.lsv_Main.GridLines = true;
            this.lsv_Main.HideSelection = false;
            this.lsv_Main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsv_Main.Location = new System.Drawing.Point(5, 19);
            this.lsv_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsv_Main.Name = "lsv_Main";
            this.lsv_Main.Size = new System.Drawing.Size(933, 455);
            this.lsv_Main.TabIndex = 1;
            this.lsv_Main.UseCompatibleStateImageBehavior = false;
            this.lsv_Main.View = System.Windows.Forms.View.Details;
            // 
            // masp
            // 
            this.masp.Text = "Mã SP";
            this.masp.Width = 119;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên SP";
            this.tensp.Width = 187;
            // 
            // slton
            // 
            this.slton.Text = "Số Lượng Tồn";
            this.slton.Width = 157;
            // 
            // ngaynhap
            // 
            this.ngaynhap.Text = "Ngày Nhập";
            this.ngaynhap.Width = 188;
            // 
            // frmKhoHang_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_XoaHang);
            this.Controls.Add(this.btn_NhapHang);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhoHang_Admin";
            this.Text = "Kho Hàng Admin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Button btn_XoaHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsv_Main;
        private System.Windows.Forms.ColumnHeader masp;
        private System.Windows.Forms.ColumnHeader tensp;
        private System.Windows.Forms.ColumnHeader slton;
        private System.Windows.Forms.ColumnHeader ngaynhap;
    }
}

