using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileShop
{
    public partial class frmKhoHang_Admin : Form
    {
        public frmKhoHang_Admin()
        {
            InitializeComponent();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            //string filePath = "C:\\Users\\thien\\OneDrive\\Máy tính\\Folder\\2001210518_PhamThienTan\\PhamThienTan\\PhamThienTan\\hangnhap.txt";

            //List<HangTonKho> danhSachSanPham = new List<HangTonKho>();

            //HangTonKho.ThemSanPhamTuFile(filePath, danhSachSanPham);

            //foreach (var sanPham in danhSachSanPham)
            //{
            //    ListViewItem item = new ListViewItem(sanPham.Ma_SP);
            //    item.SubItems.Add(sanPham.Ten_SP);
            //    item.SubItems.Add(sanPham.SL_Ton.ToString());
            //    item.SubItems.Add(sanPham.NgayNhap.ToString());
            //    lsv_Main.Items.Add(item);
            //}

        }


        private void btn_XoaHang_Click(object sender, EventArgs e)
        {
            if (lsv_Main.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            foreach (ListViewItem item in lsv_Main.SelectedItems)
            {
                lsv_Main.Items.Remove(item);
            }
        }

    }
}
