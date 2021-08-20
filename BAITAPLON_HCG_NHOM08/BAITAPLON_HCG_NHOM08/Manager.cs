using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPLON_HCG_NHOM08
{
    class Manager
    {
        string Path = Directory.GetCurrentDirectory();
        public string GetPath()
        {
            string t = Path;
            t = t.Substring(0, t.LastIndexOf(@"\"));
            t = t.Substring(0, t.LastIndexOf(@"\"));
            t += @"\note.txt";
            return t;
        }
        public void WriteFileNewLine(string text)
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(text);

            sw.Close();
            fs.Close();
        }

        public void WriteFile(string text)
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(text);

            sw.Close();
            fs.Close();
        }

        public void CreateEmptyFile()
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.Close();
            fs.Close();
        }

        public void WriteAllRule(ArrayList R)
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < R.Count; i++)
            {
                sw.Write(R[i].ToString().PadLeft(0));
                sw.Write("\n");

            }
            sw.WriteLine();
            sw.Close();
            fs.Close();
        }


        public void WriteGT(ArrayList GT)
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string t = "Tập giả thiết: GT={";
            for (int i = 0; i < GT.Count; i++)
            {
                t += GT[i].ToString();
                if (i != GT.Count - 1)
                {
                    t += ",";
                }
            }
            t += "}";
            sw.WriteLine(t);

            sw.Close();
            fs.Close();
        }

        public void WriteTG(ArrayList TG)
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string t = "TG={";
            for (int i = 0; i < TG.Count; i++)
            {
                t += TG[i].ToString();
                if (i != TG.Count - 1)
                {
                    t += ",";
                }

            }
            t += "}";
            sw.Write(t);

            sw.Close();
            fs.Close();
        }

        public void WriteSAT(ArrayList SAT)
        {
            FileStream fs = new FileStream(GetPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string t = "SAT={";
            for (int i = 0; i < SAT.Count; i++)
            {
                t += SAT[i].ToString();
                if (i != SAT.Count - 1)
                {
                    t += ",";
                }
            }
            t += "}";
            sw.Write(t);

            sw.Close();
            fs.Close();
        }
    }
}
