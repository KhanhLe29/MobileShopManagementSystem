using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class frmHoaDon : Form
    {
        public string MaDH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaNVXacThuc { get; set; }
        public DateTime ThoiGian { get; set; }
        public List<string[]> DSSP{ get; set; }
        public string TongTien { get; set; }
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void HienThiThongTin_Load(object sender, EventArgs e)
        {
            lbl_HT_MaDH.Text = MaDH;
            lbl_HT_MaNV.Text = MaNVXacThuc;
            lbl_HT_TenKH.Text = TenKH;
            lbl_HT_SDT.Text = SDT;
            lbl_HT_DiaChi.Text = DiaChi;
            lbl_HT_ThoiGian.Text = ThoiGian.ToString();
            // Kiểm tra và đảm bảo lvwDSSP đã được khởi tạo (không phải null)
            if (DSSP != null)
            {
                // Thêm các mục từ DSSanPham vào lvw_HT_DonHang
                foreach (string[] duLieu in DSSP)
                {
                    lvw_HT_DonHang.Items.Add(new ListViewItem(duLieu));
                }
            }

            //lbl_HT_TongTien.Text = TongTien.ToString();
        }
        private void frmHienThiThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult = MessageBox.Show("Bạn muốn đóng chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
