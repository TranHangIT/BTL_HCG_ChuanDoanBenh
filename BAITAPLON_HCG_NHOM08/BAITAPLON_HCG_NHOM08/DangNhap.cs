using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPLON_HCG_NHOM08
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = "Nhom08";
            string pass = "Nhom08";
            if (user.Equals(txtTaiKhoan.Text) && pass.Equals(txtmatkhau.Text))
            {
                Form_Main main = new Form_Main();
                main.ShowDialog();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
