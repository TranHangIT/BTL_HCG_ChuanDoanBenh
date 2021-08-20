using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BAITAPLON_HCG_NHOM08
{
    public partial class Form_Rules : Form
    {
        Rules Luat = new Rules();
        XmlDocument doc = new XmlDocument();
        string path = @"../../Rules.xml";
        public Form_Rules()
        {
            InitializeComponent();
        }

        private void Form_Rules_Load(object sender, EventArgs e)
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            DataTable dt = new DataTable();
            if (dts.Tables.Count != 0)
            {
                dt = dts.Tables[0];
            }
            dgv_Luat.DataSource = dt;
            txt_MaLuat.Text = "";
            txt_VePhai.Text = "";
            txt_VeTrai.Text = "";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            XmlNode node = doc.SelectSingleNode("/quanlyluat/luat[@maluat='" + txt_MaLuat.Text.Trim() + "']");
            if (node == null)
            {
                doc.Load(path);
                XmlElement luat = doc.CreateElement("luat");
                XmlAttribute maluat = doc.CreateAttribute("maluat");
                XmlElement vephai = doc.CreateElement("vephai");
                XmlElement vetrai = doc.CreateElement("vetrai");

                maluat.InnerText = txt_MaLuat.Text.Trim();
                vephai.InnerText = txt_VePhai.Text.Trim();
                vetrai.InnerText = txt_VeTrai.Text.Trim();
                luat.SetAttributeNode(maluat);
                luat.AppendChild(vephai);
                luat.AppendChild(vetrai);
                doc.DocumentElement.AppendChild(luat);

                doc.Save(path);
                Rules_Load(sender, e);
                MessageBox.Show("Thêm luật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã luật đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            doc.Load(path);

            XmlNode node = doc.SelectSingleNode("/quanlyluat/luat[@maluat='" + txt_MaLuat.Text.Trim() + "']");
            if (node != null)
            {
                node.SelectSingleNode("vetrai").InnerText = txt_VeTrai.Text.Trim();
                node.SelectSingleNode("vephai").InnerText = txt_VePhai.Text.Trim();
                doc.Save(path);
                Rules_Load(sender, e);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã luật này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rules_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            doc.Load(path);

            XmlNode node = doc.SelectSingleNode("/quanlyluat/luat[@maluat='" + txt_MaLuat.Text.Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                Rules_Load(sender, e);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã luật này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        int row;
        private void dgv_Luat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txt_MaLuat.Text = dgv_Luat.Rows[row].Cells["MaLuat"].Value.ToString();
                txt_VeTrai.Text = dgv_Luat.Rows[row].Cells["VeTrai"].Value.ToString();
                txt_VePhai.Text = dgv_Luat.Rows[row].Cells["VePhai"].Value.ToString();
            }
        }
    }
}
