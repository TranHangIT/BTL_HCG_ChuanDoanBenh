using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace BAITAPLON_HCG_NHOM08
{
    class Rules
    {
        XmlDocument doc = new XmlDocument();
        string path = @"../../Rules.xml";

        public ArrayList GetAllRule()
        {
            ArrayList rule = new ArrayList();
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            dts.ReadXml(path);
            if (dts.Tables.Count > 0)
            {
                dt = dts.Tables[0];
            }

            foreach (DataRow dr in dt.Rows)
            {
                string maluat = dr["maluat"].ToString();
                string vetrai = dr["vetrai"].ToString();
                string vephai = dr["vephai"].ToString();
                string luat = maluat + ":" + vetrai + "->" + vephai;
                rule.Add(luat);
            }
            return rule;
        }
        public string GetVePhaiByMaLuat(string maluat, ArrayList R)
        {
            //Lấy luật dựa theo mã luật 
            int index = 0;
            for (index = 0; index < R.Count; index++)
            {
                if (R[index].ToString().Contains(maluat) == true)
                {
                    break;
                }
            }
            string luat = R[index].ToString();
            string vephai = luat.Substring(luat.IndexOf("->") + 2).Trim();
            return vephai;
        }
        public ArrayList PushVeTraiToArrayList(string vetrai)
        {
            
            ArrayList list = new ArrayList();
            int count = vetrai.Length - vetrai.Replace("^", "").Length + 1; //Số sự kiện bên vế trái
            vetrai = vetrai.Substring(vetrai.IndexOf(":") + 1); //Cắt mã luật
            for (int i = 1; i <= count; i++)
            {
                if (vetrai.IndexOf("^") != -1)
                {
                    string t = "";
                    t = vetrai.Substring(0, vetrai.IndexOf("^"));
                    vetrai = vetrai.Substring(vetrai.IndexOf("^") + 1);
                    list.Add(t);
                }
                else
                {
                    string t = "";
                    t = vetrai.Substring(0, vetrai.IndexOf("->"));
                    list.Add(t);
                }
            }
            return list;
        }

        public string GetMaLuat(string luat)
        {
            string t = luat.Substring(0, luat.IndexOf(":"));
            return t;
        }

        public string GetFullLuatByMaLuat(ArrayList R, string MaLuat)
        {
            string t = "";
            for (int i = 0; i < R.Count; i++)
            {
                string luat = R[i].ToString();
                if (GetMaLuat(luat) == MaLuat)
                {
                    t = R[i].ToString();
                }
            }
            return t;
        }

        public string FindVP(string vt)
        {
            doc.Load(path);
            string kq = "";
            XmlNodeList nodes = doc.SelectNodes("/quanlyluat/luat");
            foreach (XmlNode node in nodes)
            {
                XmlNode maluat = node.SelectSingleNode("@maluat");
                XmlNode vetrai = node.SelectSingleNode("vetrai");
                XmlNode vephai = node.SelectSingleNode("vephai");

                if (vetrai.InnerText.ToString() == vt.Trim())// tách vế trái 
                {
                    kq = vephai.InnerText.ToString();
                    break;
                }
            }
            return kq;
        }
    }
}
