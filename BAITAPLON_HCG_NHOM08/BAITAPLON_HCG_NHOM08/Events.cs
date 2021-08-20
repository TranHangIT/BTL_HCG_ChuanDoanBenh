using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BAITAPLON_HCG_NHOM08
{
    class Events
    {
        XmlDocument doc = new XmlDocument();
        string path = @"../../Events.xml";
        public DataTable GetDataForDgv_SuKien()
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            if (dts.Tables.Count != 0)
            {
                dt = dts.Tables[0];
                dt1 = dt.DefaultView.ToTable(false, "mask", "tensukien");
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (dt1.Rows[i][0].ToString().Contains("b"))
                    {
                        dt1.Rows[i].Delete();
                        i--;//Sau khi xóa , row trong datatable sẽ bị dồn lại vào phần tử bị xóa nên phải lùi lại 1 ô để xét lại
                    }
                }
            }
            return dt1;
        }
        // sử dụng hàm này để viết hàm phần đưa ra kết quả chẩn đoán bệnh nhân
        public string GetTenSuKienByMaSuKien(string MaSuKien)
        {
            string t = "";
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            DataTable dt = new DataTable();
            if (dts.Tables.Count > 0)
            {
                dt = dts.Tables[0];
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["mask"].ToString() == MaSuKien)
                {
                    t = dt.Rows[i]["tensukien"].ToString();
                    break;
                }
            }
            return t;
        }

        public string GetSourceByMaSuKien(string MaSuKien)
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/quanlysukien/sukien[@mask='" + MaSuKien + "']");
            XmlNode source = node.SelectSingleNode("source");
            return source.InnerText.ToString();
        }

        public DataTable GetFullDataForDgv_SuKien()
        {
            DataTable dt = new DataTable();
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            dt = dts.Tables[0];
            return dt;
        }
    }
}
