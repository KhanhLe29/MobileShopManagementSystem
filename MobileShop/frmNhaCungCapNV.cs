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
    public partial class frmNhaCungCapNV : Form
    {
        public frmNhaCungCapNV()
        {
            InitializeComponent();
        }

        private void lvw_DsNhaCC_Click(object sender, EventArgs e)
        {
            if (lvw_DsNhaCC.FocusedItem != null && lvw_DsNhaCC.FocusedItem.Index >= 0)
            {
                ListViewItem item = lvw_DsNhaCC.FocusedItem;
                txt_MaCC.Text = item.SubItems[0].Text;
                txt_TenNhaCC.Text = item.SubItems[1].Text;
                txtHotline.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }

       
    }
}
