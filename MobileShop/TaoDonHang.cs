using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileShop
{
    public partial class frmTaoDonHang : Form
    {
        public frmTaoDonHang()
        {
            InitializeComponent();
        }
        private bool kiemTraTrung(string s)
        {
            foreach (ListViewItem item in lvwDSSP.Items)
            {
                if (item.SubItems[0].Text == s)
                {
                    return true;
                }
            }
            return false;
        }        
        private void btn_TaoDonHang_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text.Length > 0 && txtTenKH.Text.Length > 0 && txtDiaChi.Text.Length > 0
                && txtSDT.Text.Length > 0 && txtMaNVXacThuc.Text.Length > 0)
            {
                if (kiemTraTrung(txtMaDH.Text))
                {
                    MessageBox.Show("Mã đơn hàng đã bị trùng. Vui lòng xem lại!!!");
                }
                else
                {
                    MessageBox.Show("Tạo đơn hàng thành công", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
        }
        private void TaoDonHang_Load(object sender, EventArgs e)
        {
            string filePath = "#";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        cboChonSP.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc tệp: " + ex.Message);
            }            
        }
        private void cboChonSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonSP = cboChonSP.SelectedItem.ToString();

            // Phân tách chuỗi sản phẩm để lấy ra thông tin cần thiết
            string[] thongTinSP= chonSP.Split('|');
            if (thongTinSP.Length == 3)
            {
                string maSP = thongTinSP[0].Trim();
                string tenSP = thongTinSP[1].Trim();
                decimal donGia = decimal.Parse(thongTinSP[2].Trim());
            }
        }
        private void frmTaoDonHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult = MessageBox.Show("Bạn muốn đóng chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
        public List<string[]> layDuLieuDSSP()
        {
            List<string[]> duLieu = new List<string[]>();

            foreach (ListViewItem item in lvwDSSP.Items)
            {
                string[] sp = new string[5];  // Số cột là 5 (MaSP, TenSP, SoLuong, DonGia, ThanhTien)

                for (int i = 0; i < 5; i++)
                {
                    sp[i] = item.SubItems[i].Text;
                }
                duLieu.Add(sp);
            }
            return duLieu;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hienThi = new frmHoaDon();

            // Thiết lập dữ liệu trên HienThiThongTin dựa vào thông tin từ TaoDonHang
            hienThi.MaDH = txtMaDH.Text;
            hienThi.TenKH = txtTenKH.Text;
            hienThi.SDT = txtSDT.Text;
            hienThi.DiaChi = txtDiaChi.Text;
            hienThi.MaNVXacThuc = txtMaNVXacThuc.Text;
            hienThi.ThoiGian = dateTimePicker1.Value;
            hienThi.DSSP = layDuLieuDSSP();
            hienThi.TongTien=txtTongTien.Text;

            // Hiển thị HienThiThongTin
            hienThi.ShowDialog();

            txtMaDH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtMaNVXacThuc.Clear();
            cboChonSP.SelectedIndex = -1;
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cboChonSP.SelectedIndex >= 0 && txtSoLuongMua.Text.Length>0)
            {
                string chonSP = cboChonSP.SelectedItem.ToString();
                string[] thongTinSP = chonSP.Split('|');
                string maSP = thongTinSP[0].Trim();
                string tenSP = thongTinSP[1].Trim();
                decimal donGia = decimal.Parse(thongTinSP[2].Trim());

                // Lấy số lượng mua từ TextBox
                int soLuongMua = int.Parse(txtSoLuongMua.Text);

                // Tính thành tiền
                decimal thanhTien = donGia * soLuongMua;

                // Thêm thông tin sản phẩm vào ListView
                ListViewItem item = new ListViewItem(maSP);
                item.SubItems.Add(tenSP);
                item.SubItems.Add(soLuongMua.ToString());
                item.SubItems.Add(donGia.ToString("N0"));
                item.SubItems.Add(thanhTien.ToString("N0"));
                lvwDSSP.Items.Add(item);

                // Xóa số lượng mua sau khi thêm sản phẩm
                txtSoLuongMua.Text = "";
                tinhTongTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn trong comboBox hoặc chưa nhập số lượng mua", "Lỗi");
            }
        }
        private void tinhTongTien()
        {
            double tongTien = 0;

            foreach (ListViewItem item in lvwDSSP.Items)
            {
                double giaTri = 0;
                if (double.TryParse(item.SubItems[4].Text, out giaTri))
                {
                    tongTien += giaTri;
                }
            }
            txtTongTien.Text  = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (lvwDSSP.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvwDSSP.SelectedItems)
                {
                    lvwDSSP.Items.Remove(item);
                }
            }
            tinhTongTien();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            frmHoaDon hoaDon = new frmHoaDon();
            hoaDon.Show();
        }
    }
}
