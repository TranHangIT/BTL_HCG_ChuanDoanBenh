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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ChanDoanBenh Xl = new ChanDoanBenh();
            AddForm(Xl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTapLuat_Click(object sender, EventArgs e)
        {
            Form_Rules fr = new Form_Rules();
            fr.ShowDialog();
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void AddForm(ChanDoanBenh a)
        {
            panel3.Controls.Clear();
            a.TopLevel = false;
            a.AutoScroll = true;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            panel3.Controls.Add(a);
            a.Show();
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            Form_Events fe = new Form_Events();
            fe.ShowDialog();
            Form1_Load(sender, e);
        }

        private void btnSuyDien_Click(object sender, EventArgs e)
        {
            ChanDoanBenh sd = new ChanDoanBenh();
            sd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SuyDien suydien = new SuyDien();
        //    suydien.ShowDialog();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            SuyDien suydien = new SuyDien();
            suydien.ShowDialog();
        }
    }
}
