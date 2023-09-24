namespace MobileShop
{
    partial class frmNhaCungCapNV
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
            "NCC01",
            "TuanBinh",
            "0111111111",
            "a@gmail.com"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.LightSteelBlue, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "NCC02",
            "AnhDung",
            "0999999",
            "B@gmail.com"}, -1);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvw_DsNhaCC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHotline = new System.Windows.Forms.TextBox();
            this.txt_TenNhaCC = new System.Windows.Forms.TextBox();
            this.txt_MaCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvw_DsNhaCC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(914, 456);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // lvw_DsNhaCC
            // 
            this.lvw_DsNhaCC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvw_DsNhaCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvw_DsNhaCC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvw_DsNhaCC.FullRowSelect = true;
            this.lvw_DsNhaCC.GridLines = true;
            this.lvw_DsNhaCC.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvw_DsNhaCC.Location = new System.Drawing.Point(7, 34);
            this.lvw_DsNhaCC.Name = "lvw_DsNhaCC";
            this.lvw_DsNhaCC.Size = new System.Drawing.Size(901, 291);
            this.lvw_DsNhaCC.TabIndex = 0;
            this.lvw_DsNhaCC.UseCompatibleStateImageBehavior = false;
            this.lvw_DsNhaCC.View = System.Windows.Forms.View.Details;
            this.lvw_DsNhaCC.Click += new System.EventHandler(this.lvw_DsNhaCC_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhà CC";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên nhà CC";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 206;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hotline";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 248;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Controls.Add(this.btn_Xuat);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtHotline);
            this.groupBox1.Controls.Add(this.txt_TenNhaCC);
            this.groupBox1.Controls.Add(this.txt_MaCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý nhà cung cấp";
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(56, 162);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(613, 24);
            this.txt_timKiem.TabIndex = 13;
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Xuat.ForeColor = System.Drawing.Color.White;
            this.btn_Xuat.Location = new System.Drawing.Point(789, 62);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(105, 38);
            this.btn_Xuat.TabIndex = 12;
            this.btn_Xuat.Text = "Xuất";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(789, 21);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(105, 38);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(539, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 24);
            this.txtEmail.TabIndex = 7;
            // 
            // txtHotline
            // 
            this.txtHotline.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtHotline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotline.Location = new System.Drawing.Point(378, 82);
            this.txtHotline.Name = "txtHotline";
            this.txtHotline.Size = new System.Drawing.Size(123, 24);
            this.txtHotline.TabIndex = 6;
            // 
            // txt_TenNhaCC
            // 
            this.txt_TenNhaCC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_TenNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNhaCC.Location = new System.Drawing.Point(217, 82);
            this.txt_TenNhaCC.Name = "txt_TenNhaCC";
            this.txt_TenNhaCC.Size = new System.Drawing.Size(123, 24);
            this.txt_TenNhaCC.TabIndex = 5;
            // 
            // txt_MaCC
            // 
            this.txt_MaCC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_MaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaCC.Location = new System.Drawing.Point(56, 82);
            this.txt_MaCC.Name = "txt_MaCC";
            this.txt_MaCC.Size = new System.Drawing.Size(123, 24);
            this.txt_MaCC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(536, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(375, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(214, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà CC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà CC";
            // 
            // frmNhaCungCapNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhaCungCapNV";
            this.Text = "frmNhaCungCapNV";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvw_DsNhaCC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHotline;
        private System.Windows.Forms.TextBox txt_TenNhaCC;
        private System.Windows.Forms.TextBox txt_MaCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}