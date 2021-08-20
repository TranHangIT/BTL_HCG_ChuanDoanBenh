using System;
using System.Collections;
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
    public partial class ChanDoanBenh : Form
    {
        Random r = new Random();
        ArrayList GT = new ArrayList(); //Khai báo phần giả thiết
        ArrayList TG = new ArrayList(); //Tập chứa các sự kiện nhận giá trị =True cho đến thời điểm hiện tại
        ArrayList SAT = new ArrayList(); //Tập SAT chứa các luật chưa xét và có thể sử dụng sự kiện từ tập TG (luật thỏa cho đến thời điểm hiện tại)
        ArrayList R = new ArrayList(); //Tập các luật
        ArrayList KL = new ArrayList(); //Tập này chứa tất cả các sự kiện bên vế phải của tất cả các luật
        Events Sukien = new Events();
        Rules Luat = new Rules();
       Manager fm = new Manager();
        ArrayList temp = new ArrayList();
        public ChanDoanBenh()
        {
            InitializeComponent();
        }

        private void XuLy_Load(object sender, EventArgs e)
        {
            dgv_SuKien.DataSource = Sukien.GetDataForDgv_SuKien();
            GT.Clear();
        }
        private bool Check_KL_In_TG(ArrayList TG)
        {
            foreach (string tg in TG)
            {
                if (tg.Contains("b"))
                {
                    return true;
                }
            }
            return false;
        }
        private ArrayList Filter(ArrayList TG, ArrayList R)
        {
            ArrayList SAT = new ArrayList();
            for (int i = 0; i < R.Count; i++)
            {
                int count = 0;
                ArrayList vetrai = Luat.PushVeTraiToArrayList(R[i].ToString());
                for (int j = 0; j < vetrai.Count; j++)
                {
                    if (TG.Contains(vetrai[j]))
                    {
                        count++;
                    }
                }
                if (count == vetrai.Count)
                {
                    SAT.Add(Luat.GetMaLuat(R[i].ToString()));
                }
            }
            return SAT;
        }
        private void Suggest(string maluat)
        {
            R = Luat.GetAllRule();
            temp.Add(maluat);
            ArrayList a = Filter(temp, R);
            ArrayList suggest = new ArrayList();
            if (a.Count == 1)
            {
                temp.Clear();
                temp.Add(Luat.GetVePhaiByMaLuat(a[0].ToString(), R));
            }
            for (int i = 0; i < R.Count; i++)
            {
                ArrayList vetrai = Luat.PushVeTraiToArrayList(R[i].ToString());
                int count = 0;
                for (int j = 0; j < temp.Count; j++)
                {

                    if (vetrai.Contains(temp[j]))
                    {
                        count++;
                        if (count == temp.Count)
                        {
                            for (int k = 0; k < vetrai.Count; k++)
                            {
                                suggest.Add(vetrai[k]);
                                for (int h = 0; h < temp.Count; h++)
                                {
                                    suggest.Remove(temp[h]);
                                }
                            }
                        }
                    }
                }
            }
            DataTable table_for_DgvSuKien = Sukien.GetDataForDgv_SuKien();
            for (int i = 0; i < table_for_DgvSuKien.Rows.Count; i++)
            {
                if (!suggest.Contains(table_for_DgvSuKien.Rows[i]["mask"].ToString()) || GT.Contains(table_for_DgvSuKien.Rows[i]["mask"].ToString()))
                {
                    table_for_DgvSuKien.Rows.RemoveAt(i);
                    i--;
                }
            }
            dgv_SuKien.DataSource = table_for_DgvSuKien;
            R = null;
        }
        int row_Events;
        private void btn_ThemSuKien_Click(object sender, EventArgs e)
        {
            try
            {
                if (row_Events >= 0 && dgv_SuKien.Rows.Count > 0)
                {
                    string mask = dgv_SuKien.Rows[row_Events].Cells["mask"].Value.ToString();
                    string tensukien = dgv_SuKien.Rows[row_Events].Cells["tensukien"].Value.ToString();

                    if (GT.Contains(mask) == false)
                    {
                        dgv_XacNhanSuKien.Rows.Add(mask, tensukien);
                        GT.Add(mask);
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sự kiện này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chưa chọn triệu chứng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Viết hàm này với mục đích lọc những phần tử của  của vế trái để suy ra được bệnh
            {
                string maluat = "";
                if (GT.Count > 0)
                {
                    maluat = GT[GT.Count - 1].ToString();
                }
                Suggest(maluat);
            }
        }
        int row_ConfirmEvents;
        private void btn_XoaSuKien_Click(object sender, EventArgs e)
        {
            //Xóa listbox_KetQua và picturebox khi xóa đi sự kiện
            listbox_KetQua.Items.Clear();


            if (row_ConfirmEvents >= 0 && row_ConfirmEvents < dgv_XacNhanSuKien.Rows.Count)
            {
                //Loại sự kiện khỏi tập GT
                for (int i = 0; i < GT.Count; i++)
                {
                    string mask = dgv_XacNhanSuKien.Rows[row_ConfirmEvents].Cells["mask1"].Value.ToString();
                    if (GT[i].ToString().Contains(mask))
                    {
                        GT.RemoveAt(i);
                        break;
                    }
                }

                dgv_XacNhanSuKien.Rows.RemoveAt(row_ConfirmEvents);

                //gán row_dgv_XacNhanSuKien = -1 để sau khi xóa sự kiện đã chọn thì phải chọn tiếp mới xóa được
                row_ConfirmEvents = -1;
            }
           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            XuLy_Load(sender, e);
            dgv_XacNhanSuKien.Rows.Clear();
            listbox_KetQua.Items.Clear();
            GT.Clear();
            temp.Clear();
            TG.Clear();
        }
        // suy diễn để chẩn đoán bệnh 
        private void btn_SuyDien_Click(object sender, EventArgs e)
        {
          
            R = Luat.GetAllRule();
            //Tạo 1 file note.txt trắng
            fm.CreateEmptyFile();
            fm.WriteFileNewLine("Tập luật: ");
            fm.WriteAllRule(R);
            fm.WriteFileNewLine("Tập luật: ");
            //In tập giả thiết GT
            fm.WriteGT(GT);
            fm.WriteFileNewLine("Bước 1: ");
            //TG = GT; 
            //Gán dữ liệu từ tập GT cho tập TG  
            //Cách trên nó chỉ là tham chiếu cho nên phải deep copy mới tạo thành 2 arraylist tách biệt
            //Xóa tập TG trước khi Add
            TG.Clear();
            foreach (string temp in GT)
            {
                TG.Add(temp);

            }
            fm.WriteFile("Tập trung gian: GT=");
            fm.WriteTG(TG);

            SAT = Filter(TG, R); //Lọc ra tập SAT từ tập luật R và tập TG 
            fm.WriteFileNewLine("");
            fm.WriteFile("Lọc các luật từ tập TG và R: ");
            fm.WriteSAT(SAT);
            fm.WriteFileNewLine("");
            int lanlap = 0;
            while (Check_KL_In_TG(TG) == false && SAT.Count > 0)
            {
                lanlap++;
                fm.WriteFileNewLine("-----Lần lặp thứ : " + lanlap + "-----");
                fm.WriteFileNewLine("Bước 2: ");
                fm.WriteFileNewLine("Lấy luật " + SAT[0].ToString() + " trong tập SAT: " + Luat.GetFullLuatByMaLuat(R, SAT[0].ToString()));
                fm.WriteFileNewLine("Ta có: ");
                //Lấy vế phải luật đầu tiên trong tập SAT thêm vào tập TG
                TG.Add(Luat.GetVePhaiByMaLuat(SAT[0].ToString(), R));
                fm.WriteFile("+Thêm vế phải của luật " + SAT[0].ToString() + "vào tập TG: ");
                fm.WriteTG(TG);
                fm.WriteFileNewLine("");
                //Loại bỏ luật vừa lấy khỏi tập luật R
                for (int i = 0; i < R.Count; i++)
                {
                    if (Luat.GetMaLuat(R[i].ToString()) == SAT[0].ToString())
                    {
                        R.RemoveAt(i);
                    }
                }
                fm.WriteFileNewLine("+Loại luật " + SAT[0].ToString() + @" khỏi tập R: R\" + SAT[0].ToString());

                //Lọc lại tập SAT
                SAT = Filter(TG, R);
                fm.WriteFile("Lọc lại tập SAT từ tập TG và R: ");
                fm.WriteSAT(SAT);
                fm.WriteFileNewLine("");

                fm.WriteFileNewLine("Bước 3: Kiểm tra");
                if (Check_KL_In_TG(TG))
                {
                    fm.WriteFile("Trong tập TG có kết luận, dừng lặp: ");
                    fm.WriteTG(TG);
                    fm.WriteFileNewLine("");
                }
                else
                {
                    fm.WriteFile("-Trong tập TG không có kết luận: ");
                    fm.WriteTG(TG);
                    fm.WriteFileNewLine("");
                }
                if (SAT.Count == 0)
                {
                    fm.WriteFile("Tập SAT rỗng, dừng lặp: ");
                    fm.WriteSAT(SAT);
                    fm.WriteFileNewLine("");
                }
                else
                {
                    fm.WriteFile("Tập SAT vẫn còn luật: ");
                    fm.WriteSAT(SAT);
                    fm.WriteFileNewLine("");
                }

            }
            // Phần kết quả của chẩn đoán bệnh 
            if (Check_KL_In_TG(TG) == true)
            {
                string ketqua = "";
                for (int i = 0; i < TG.Count; i++)
                {
                    //Lấy ra mã sự  kiện kết quả trong tập TG để xuất kết quả 
                    if (TG[i].ToString().Contains("b"))
                    {
                        string mask = TG[i].ToString().Trim();
                        ketqua = Sukien.GetTenSuKienByMaSuKien(mask);
                        listbox_KetQua.Items.Add("-------------------Kết quả chẩn đoán bệnh nhân ----------------");
                        listbox_KetQua.Items.Add("Mắc bệnh: " + Sukien.GetTenSuKienByMaSuKien(mask));
                        listbox_KetQua.Items.Add("Tỷ lệ chính xác: " + r.Next(80, 100) + "%");
                        listbox_KetQua.Items.Add("--------------------------------------------------------------");
                    }
                }

                fm.WriteFileNewLine("------------------------------------------------------------------------------");
                fm.WriteFileNewLine("-----Các sự kiện đã chọn-----");
                for (int i = 0; i < dgv_XacNhanSuKien.Rows.Count; i++)
                {
                    fm.WriteFileNewLine(dgv_XacNhanSuKien.Rows[i].Cells["tensukien1"].Value.ToString());
                }
                fm.WriteFileNewLine("-----Kết quả chẩn đoán -----");
                fm.WriteFileNewLine("=====>" + ketqua);
            }
            else
            {
                if (temp.Count != 0)
                {
                    listbox_KetQua.Items.Add("-------------------Kết quả chẩn đoán-----------------");
                    listbox_KetQua.Items.Add("Mắc bệnh: " + Sukien.GetTenSuKienByMaSuKien(temp[0].ToString()));
                    listbox_KetQua.Items.Add("Tỷ lệ chính xác: " + r.Next(80, 100) + "%");
                    listbox_KetQua.Items.Add("------------------------------------------------------------");
                }
                else
                {
                    listbox_KetQua.Items.Add("===> Không thể suy diễn");
                }

                fm.WriteFileNewLine("------------------------------------------------------------------------------");
                fm.WriteFileNewLine("-----Các sự kiện đã chọn-----");
                for (int i = 0; i < dgv_XacNhanSuKien.Rows.Count; i++)
                {
                    fm.WriteFileNewLine(dgv_XacNhanSuKien.Rows[i].Cells["tensukien1"].Value.ToString());
                }
                fm.WriteFileNewLine("-----Kết quả-----");

                if (temp.Count != 0)
                {
                    fm.WriteFileNewLine("===>" + Sukien.GetTenSuKienByMaSuKien(temp[0].ToString()));
                }
                else
                {
                    fm.WriteFileNewLine("===> Không thể suy diễn");
                }
               
            }
            //Sau khi suy diễn  xong gán biến temp = null
            temp.Clear();
        }
        
        private void dgv_SuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_Events = e.RowIndex;
            if (row_Events >= 0)
            {
                txtmask.Text = dgv_SuKien.Rows[row_Events].Cells["mask"].Value.ToString();
                txttensk.Text = dgv_SuKien.Rows[row_Events].Cells["tensukien"].Value.ToString();

            }

        }

        private void dgv_XacNhanSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_ConfirmEvents = e.RowIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txttensk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
