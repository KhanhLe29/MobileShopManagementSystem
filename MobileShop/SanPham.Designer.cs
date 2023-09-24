
namespace MobileShop
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanPham,
            this.colTenSanPham,
            this.colNhaCungCap,
            this.colHangSanXuat,
            this.colXuatXu,
            this.colLoai,
            this.colGia});
            this.dgvDSSP.Location = new System.Drawing.Point(0, 106);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 62;
            this.dgvDSSP.RowTemplate.Height = 28;
            this.dgvDSSP.Size = new System.Drawing.Size(978, 589);
            this.dgvDSSP.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Controls.Add(this.btnSuaSP);
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 100);
            this.panel1.TabIndex = 70;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaSP.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.Location = new System.Drawing.Point(699, 12);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(115, 48);
            this.btnXoaSP.TabIndex = 75;
            this.btnXoaSP.Text = "Xoá";
            this.btnXoaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaSP.UseVisualStyleBackColor = false;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnSuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaSP.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSP.Image")));
            this.btnSuaSP.Location = new System.Drawing.Point(501, 12);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(115, 48);
            this.btnSuaSP.TabIndex = 74;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaSP.UseVisualStyleBackColor = false;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemSP.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.Location = new System.Drawing.Point(158, 12);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(254, 48);
            this.btnThemSP.TabIndex = 73;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.colMaSanPham.MinimumWidth = 8;
            this.colMaSanPham.Name = "colMaSanPham";
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.MinimumWidth = 8;
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.colNhaCungCap.MinimumWidth = 8;
            this.colNhaCungCap.Name = "colNhaCungCap";
            // 
            // colHangSanXuat
            // 
            this.colHangSanXuat.HeaderText = "Hãng Sản Xuất";
            this.colHangSanXuat.MinimumWidth = 8;
            this.colHangSanXuat.Name = "colHangSanXuat";
            // 
            // colXuatXu
            // 
            this.colXuatXu.HeaderText = "Xuất Xứ";
            this.colXuatXu.MinimumWidth = 8;
            this.colXuatXu.Name = "colXuatXu";
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Loại";
            this.colLoai.MinimumWidth = 8;
            this.colLoai.Name = "colLoai";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá Bán";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSSP);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
    }
}