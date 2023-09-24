using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Excel = Microsoft.Office.Interop.Excel;

namespace MobileShop
{
    public partial class frmNhaCungCapAdmin : Form
    {
        public frmNhaCungCapAdmin()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if(lvw_DsNhaCC.FocusedItem !=null && lvw_DsNhaCC.FocusedItem.Index>=0)
            {
                ListViewItem item = lvw_DsNhaCC.FocusedItem;
                txt_MaCC.Text = item.SubItems[0].Text;
                txt_TenNhaCC.Text = item.SubItems[1].Text;
                txtHotline.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txt_MaCC.Text);
            item.SubItems.Add(txt_TenNhaCC.Text);
            item.SubItems.Add(txtHotline.Text);
            item.SubItems.Add(txtEmail.Text);
            lvw_DsNhaCC.Items.Add(item);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lvw_DsNhaCC.FocusedItem != null && lvw_DsNhaCC.FocusedItem.Index >= 0)
            {
                ListViewItem item = lvw_DsNhaCC.FocusedItem;
                item.SubItems[0].Text = txt_MaCC.Text;
                item.SubItems[1].Text = txt_TenNhaCC.Text;
                item.SubItems[2].Text = txtHotline.Text;
                item.SubItems[3].Text = txtEmail.Text;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem i in lvw_DsNhaCC.SelectedItems)
            {
                i.Remove();
            }
        }
        
        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            //Excel.Application app = new Excel.Application();
            //Excel.Workbook wb = app.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];


            //// in tiêu đề 
            //ws.Range["A1:D1"].Font.Size = 12;
            //ws.Range["A1:D1"].Font.Bold = true;
            //ws.Range["A1"].Value = "Mã nhà CC";
            //ws.Range["B1"].Value = "Tên nhà CC";
            //ws.Range["C1"].Value = "Hotline";
            //ws.Range["D1"].Value = "Email";

            //// in danh sách các chi 
            //int dong = 2;
            //foreach (ListViewItem item in lvw_DsNhaCC.Items)
            //{
            //    ws.Range["A" + dong.ToString()].Value = item.SubItems[0].Text;
            //    ws.Range["B" + dong.ToString()].Value = item.SubItems[1].Text;
            //    ws.Range["C" + dong.ToString()].Value = item.SubItems[2].Text;
            //    ws.Range["D" + dong.ToString()].Value = item.SubItems[3].Text;
            //    dong++;
            //}
            //ws.Name = "Nhà cung cấp";
            ////ws.Activate(); // kích hoạt cho file excel hoạt động

            //// lưu file
            //SaveFileDialog save = new SaveFileDialog();
            ////save.Filter = "|*.xlsx"; //liệt kê các tên đuôi được phép lưu 
            //save.RestoreDirectory = true; //cho phép ghi đè
            //if(save.ShowDialog()==DialogResult.OK)
            //{
            //    ws.SaveAs(save.FileName.ToLower());
            //}
            //app.Quit();
                


               
            
         


        }

       
    }
}
