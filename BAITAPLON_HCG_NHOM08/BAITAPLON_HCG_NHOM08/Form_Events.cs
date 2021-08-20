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
    public partial class Form_Events : Form
    {
        Events SuKien = new Events();
        XmlDocument doc = new XmlDocument();
        string path = @"../../Events.xml";
        public Form_Events()
        {
            InitializeComponent();
        }

        private void Form_Events_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            if (dts.Tables.Count != 0)
            {
                dt = dts.Tables[0];
            }
            dgv_SuKien.DataSource = dt;
            txt_MaSuKien.Text = "";
            txt_TenSuKien.Text = "";
        }
        int row;

        private void btn_Them_Click(object sender, EventArgs e)
        {
            XmlNode node = doc.SelectSingleNode("/quanlysukien/sukien[@mask='" + txt_MaSuKien.Text.Trim() + "']");
            if (node == null)
            {
                doc.Load(path);
                XmlAttribute mask = doc.CreateAttribute("mask");
                XmlElement tensukien = doc.CreateElement("tensukien");
                XmlElement source = doc.CreateElement("source");
                XmlElement sukien = doc.CreateElement("sukien");

                mask.InnerText = txt_MaSuKien.Text;
                tensukien.InnerText = txt_TenSuKien.Text;

                sukien.SetAttributeNode(mask);
                sukien.AppendChild(tensukien);
                sukien.AppendChild(source);
                doc.DocumentElement.AppendChild(sukien);

                doc.Save(path);
                Events_Load(sender, e);
                MessageBox.Show("Thêm sự kiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã sự kiện đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/quanlysukien/sukien[@mask='" + txt_MaSuKien.Text.Trim() + "']");
            if (node != null)
            {
                node.SelectSingleNode("tensukien").InnerText = txt_TenSuKien.Text;

                doc.Save(path);
                Events_Load(sender, e);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã sự kiện không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/quanlysukien/sukien[@mask='" + txt_MaSuKien.Text.Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                Events_Load(sender, e);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã sự kiện này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txt_MaSuKien.Text = dgv_SuKien.Rows[row].Cells["masukien"].Value.ToString();
                txt_TenSuKien.Text = dgv_SuKien.Rows[row].Cells["tensukien"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_SuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
