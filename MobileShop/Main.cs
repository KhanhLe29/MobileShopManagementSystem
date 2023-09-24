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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        public Form currentFormChild;

        public void openChildForm (Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Body_Panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
            
        }

        

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTaoDonHang());
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhoHang_Admin());
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhaCungCapAdmin());
        }

       
    }
}
