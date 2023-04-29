using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace AI_CNPM
{
    public partial class Form1 : Form
    {
        public int[] gt = new int[10];
        public string[] KhoaChinh = null;
        public string[] KhoaPhu = null;
        public string[] CauHoi = null;
        public string[] GoiY = null;
        public Dictionary<int, string[]> LiGoiY = new Dictionary<int, string[]>();
        public Dictionary<int, List<string>> mapChinh = new Dictionary<int, List<string>>();
        public Dictionary<int, List<string>> mapPhu = new Dictionary<int, List<string>>();
        public Dictionary<string, List<string>> OpenChinh = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> OpenPhu = new Dictionary<string, List<string>>();
        public Dictionary<string, List<int>>  Chinh = new Dictionary<string, List<int>>();
        public Dictionary<string, List<int>> Phu = new Dictionary<string, List<int>>();
        public Dictionary<string, List<string>> ChaChinh = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> ChaPhu = new Dictionary<string, List<string>>();
        public Dictionary<string, int> Diem = new Dictionary<string,int>();
        public Dictionary<string, List<string>> Con = new Dictionary<string, List<string>>();
        public List<string> Gan = new List<string>();
        int kk = -1;
        public Form1()
        {
            InitializeComponent();
        }
        void loadCon()
        {
            string[] ss = File.ReadAllLines("Con.txt");
            for(int i = 0; i < ss.Length; i++)
            {
                string[] s = ss[i].Trim().Split('.');
                Con.Add(s[0],new List<string>());
                for (int j = 1; j < s.Length; ++j)
                    Con[s[0]].Add(s[j]);
            }
        }
        void loadDiem()
        {
            for(int i = 0; i < KhoaChinh.Length; ++i)
            {
                if (!Diem.ContainsKey(KhoaChinh[i]))
                    Diem.Add(KhoaChinh[i], 1);
            }
            for (int i = 0; i < KhoaPhu.Length; ++i)
            {
                if (!Diem.ContainsKey(KhoaPhu[i]))
                    Diem.Add(KhoaPhu[i], 1);
            }
        }
        void loadCha(Dictionary<string, List<string>> Open, Dictionary<string, List<string>> Cha)
        {
            foreach(string str in Open.Keys)
            {
                foreach(string s in Open[str])
                {
                    if (s != "")
                    {
                        if(!Cha.ContainsKey(s))
                            Cha.Add(s, new List<string>());
                        Cha[s].Add(str);
                    }
                }
            }    
        }
        void WriteCha(string tenFile, Dictionary<string, List<string>> Cha)
        {
            string ss = "";
            foreach(string s in Cha.Keys)
            {
                ss += s + ": ";
                foreach (string u in Cha[s])
                {
                    ss +=  u + '.';
                }
                ss = ss.TrimEnd('.');
                ss += '\n';
            }
            File.WriteAllText(tenFile, ss);
        }
        bool checkOpen(string ss, string str, Dictionary<string, List<string>> Open)
        {
            if (ss.Contains(str))
                return true;
            foreach (string s in Open[str])
            {
                if (s != "" && ss.Contains(s))
                    return true;
            }
            return false;
        }
        void loadCP(Dictionary<string, List<int>> Tam, string[] Khoa, Dictionary<string, List<string>> Open)
        {
            for(int i = 0; i<Khoa.Length; ++i)
            {
                Tam.Add(Khoa[i], new List<int>());
                for(int j = 0; j < CauHoi.Length; ++j)
                {
                    if (checkOpen( CauHoi[j], Khoa[i],Open))
                    {
                        Tam[Khoa[i]].Add(j);
                    }    
                }    
            }    
        }
        void WriteCP(Dictionary<string, List<int>> Tam, string[] Khoa, string tenFile)
        {
            string s = "";
            for(int i = 0; i < Khoa.Length; ++i)
            {
                s += Khoa[i] + ": ";
                foreach(int j in Tam[Khoa[i]])
                {
                    s += j.ToString() + '.';
                }
                s = s.TrimEnd('.');
                s += '\n';
            }
            File.WriteAllText(tenFile, s);
        }
        void loadOpen(string[] Open, string[] Khoa, Dictionary<string, List<string>> Open2)
        {
            for (int i = 0; i < Khoa.Length; i++)
            {
                Open2.Add(Khoa[i], new List<string>());
                string[] s = Open[i].Trim().Split('.');
                foreach (string str in s)
                {
                    Open2[Khoa[i]].Add(str);
                }
            }
        }
        void WriteFileOpen(string[] Khoa, Dictionary<string, List<string>> Open2, string tenFile)
        {
            string ss = "";
            for (int i = 0; i < Khoa.Length; i++)
            {
                ss += i.ToString() + ": ";
                foreach (string str in Open2[Khoa[i]])
                {
                    ss += str + '.';
                }
                ss = ss.TrimEnd('.');
                ss += '\n';
            }
            File.WriteAllText(tenFile, ss);
        }
        void loadGoiY()
        {
            for(int i = 0; i<CauHoi.Length;++i)
            {
                string ten = "gy" + i.ToString() + ".txt";
                string[] s = File.ReadAllLines(ten);
                LiGoiY.Add(i, s);
            }    
        }
        void loadFile()
        {
            CauHoi = File.ReadAllLines("CauHoi.txt");
          //  GoiY = File.ReadAllLines("CauHoi.txt");
            KhoaChinh = File.ReadAllLines("KhoaChinh.txt");
            KhoaPhu = File.ReadAllLines("KhoaPhu.txt");
            string[] OpenC = File.ReadAllLines("OpenChinh.txt");
            string[] OpenP = File.ReadAllLines("OpenPhu.txt");
            loadOpen(OpenC, KhoaChinh,OpenChinh);
            loadOpen(OpenP, KhoaPhu,OpenPhu);
            loadGoiY();
            WriteFileOpen(KhoaChinh,OpenChinh, "CheckOpenChinh.txt");
            WriteFileOpen( KhoaPhu,OpenPhu, "CheckOpenPhu.txt");
            WriteFile("mapChinh.txt", mapChinh, OpenChinh, KhoaChinh);
            WriteFile("mapPhu.txt", mapPhu, OpenPhu, KhoaPhu);
        }
        
        void WriteFile(string tenFile,Dictionary<int,List<string>> map, Dictionary<string, List<string>> Open, string[] Khoa)
        {
            for(int i = 0; i<CauHoi.Length; i++)
            {
                map.Add(i,new List<string>());
                foreach(string str in Khoa)
                {
                    if (checkOpen(CauHoi[i],str,Open))
                   //if(CauHoi[i].Contains(str))
                    {
                        map[i].Add(str);
                    }    
                }    
            }
            string ss = "";
            for (int i = 0; i < CauHoi.Length; i++)
            {

                foreach(string str in map[i])
                {
                    //if (checkOpen(CauHoi[i], str, Open))
                     ss += str + '.';
                }
                ss = ss.TrimEnd('.');
                ss += '\n';
            }
            File.WriteAllText(tenFile,ss);
        }
        void writegoiy()
        {
            string s = "gy";
            for(int i = 0; i<CauHoi.Length; ++i)
            {
                File.WriteAllText(s + i.ToString() + ".txt", CauHoi[i]);
            }    

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadFile();
            loadCP(Chinh, KhoaChinh, OpenChinh);
            loadCP(Phu, KhoaPhu, OpenPhu);
            WriteCP(Chinh, KhoaChinh, "Chinh.txt");
            WriteCP(Phu, KhoaPhu, "Phu.txt");
            loadCha(OpenChinh, ChaChinh);
            loadCha(OpenPhu, ChaPhu);
            WriteCha("ChaChinh.txt", ChaChinh);
            WriteCha("ChaPhu.txt", ChaPhu);
            loadDiem();
            loadCon();
           // writegoiy();
        }
        bool checkCon(string str)
        {
            if(Con.ContainsKey(str))
            {
                return true;
            }
            if(ChaChinh.ContainsKey(str))
            {
                foreach(string s in ChaChinh[str])
                {
                    if (Con.ContainsKey(s))
                        return true;
                }    
            }
            return false;
        }
        void tangDiem(string str)
        {
            if(checkCon(str))
            {
                foreach(string s in ChaChinh[str])
                {
                    if (Con.ContainsKey(s))
                    {
                        foreach (string ss in Con[s])
                        {
                            Diem[ss]++;
                            Gan.Add(ss);
                        }
                    }
                }    
            }    
        }
        void checkdd(int[] dd, string key, Dictionary<string, List<int>> map, Dictionary<string,List<string>> cha  )
        {
            if (cha.ContainsKey(key))
            {
                foreach (string str in cha[key])
                {
                    foreach (int i in map[str])
                    {
                         dd[i] += Diem[str];
                    }
                }
            }
        }
        void timKiem()
        {
            btn_dong_y.Enabled = true;
            foreach (string kk in Gan)
            {
                Diem[kk] = 1;
            }
            string truyvan = txt_Nhap.Text.Trim().ToLower();
            string[] s = truyvan.Split(' ');
            int[] dc = new int[1000];
            int[] dp = new int[1000];
            string[] ss = new string[100];
            int sll = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                string str = s[i];
                if (ChaChinh.ContainsKey(str) || ChaPhu.ContainsKey(str))
                {
                    ss[sll++] = str;
                }

                for (int j = 1; i + j < s.Length && j - i < 7; ++j)
                {
                    str += " " + s[i + j];
                    if (ChaChinh.ContainsKey(str) || ChaPhu.ContainsKey(str))
                    {
                        ss[sll++] = str;
                    }
                }
            }
            for (int i = 0; i < sll; ++i)
            {
                string str = ss[i];
                tangDiem(str);
            }
            for (int i = 0; i < sll; ++i)
            {
                string str = ss[i];
                checkdd(dc, str, Chinh, ChaChinh);
                checkdd(dp, str, Phu, ChaPhu);
            }

            int Max = 0, sl = 0;
            int[] luu = new int[1000];
            for (int i = 0; i < CauHoi.Length; ++i)
            {
                if (dc[i] > dc[Max])
                {
                    Max = i;
                    sl = 0;
                }
                if (dc[i] == dc[Max])
                {
                    luu[sl++] = i;
                }
            }
            Max = luu[0];
            for (int i = 1; i < sl; ++i)
            {
                if (dp[Max] < dp[luu[i]])
                {
                    Max = luu[i];
                }
            }
            string file = Max.ToString() + ".txt";

            string kkk = File.ReadAllText(file);
            rtb_Xuat.Text = CauHoi[Max] + "\n\n";
            rtb_Xuat.Text += kkk;
            kk = Max;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        void TimGoiY(string ss)
        {
            string[] s = ss.Split(' ');
            int[] luu = new int[10];
            
            int[] dd = new int[100];
            for (int i = 0; i < 4; ++i)
                gt[i] = 0;
            Goi_Y.Items.Clear();
            for(int i = 0; i < CauHoi.Length; ++i)
            {
                int Max = 0;
                for (int ji = 0; ji < LiGoiY[i].Length; ++ji)
                {
                    int[,] a = new int[100, 100];
                    string[] cc = LiGoiY[i][ji].Trim().Split(' ');
                    for (int j = 0; j < cc.Length; ++j)
                    {
                        for (int k = 0; k < s.Length; ++k)
                        {
                            if (cc[j] == s[k])
                                a[j + 1, k + 1] = a[j, k] + 1;
                            else
                            {
                                if (a[j, k + 1] > a[j + 1, k])
                                    a[j + 1, k + 1] = a[j, k + 1];
                                else
                                    a[j + 1, k + 1] = a[j + 1, k];
                            }
                        }
                    }
                    if (Max < a[cc.Length, s.Length])
                        Max = a[cc.Length, s.Length];
                }
                int jj = 3;
                while (jj > 0 && Max > luu[jj - 1] && Max > 0)
                {
                    luu[jj] = luu[jj - 1];
                    gt[jj] = gt[jj - 1];
                    --jj;
                }
                luu[jj] = Max;
                gt[jj] = i + 1;

            }
            for(int i = 0; i < 3;++i)
            {
                if (gt[i] != 0)
                {
                    Goi_Y.Items.Add(CauHoi[gt[i]-1]);
                }
            }    
        }
        private void txt_Nhap_TextChanged(object sender, EventArgs e)
        {
                TimGoiY(txt_Nhap.Text.ToLower());
        }

       
        private void Goi_Y_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn đây là câu hỏi bạn muốn hỏi?","Thông báo",  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                rtb_Xuat.Text = "";
                int i = Goi_Y.SelectedIndex;
                int k = gt[i] - 1;
                string ten = "gy" + k.ToString() + ".txt";
                File.AppendAllText(ten, '\n' + txt_Nhap.Text);
                string[] s = File.ReadAllLines(ten);
                LiGoiY[k] = s;
                string file = k.ToString() + ".txt";
                string kkk = File.ReadAllText(file);
                rtb_Xuat.Text = CauHoi[k] + "\n\n";
                rtb_Xuat.Text += kkk;
                Goi_Y.Items.Clear();
                btn_dong_y.Enabled = false;
            }
        }


        private void btn_dong_y_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Bạn có hài lòng với câu trả lời này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                int k = kk;
                if (kk != -1)
                {
                    string ten = "gy" + k.ToString() + ".txt";
                    File.AppendAllText(ten, '\n' + txt_Nhap.Text);
                    string[] s = File.ReadAllLines(ten);
                    LiGoiY[k] = s;
                    string file = k.ToString() + ".txt";
                    string kkk = File.ReadAllText(file);
                    rtb_Xuat.Text = CauHoi[k] + "\n\n";
                    rtb_Xuat.Text += kkk;
                }
                kk = -1;
                btn_dong_y.Enabled = false;
            }
        }

        private void txt_Nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13)          
            {
                timKiem();
            }    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
