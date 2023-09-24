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
    public partial class frmSanPham : Form
    {

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThemSanPham Add = new frmThemSanPham();
            Add.Show();
        }
    }
}
