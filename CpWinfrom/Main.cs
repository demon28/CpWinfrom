using CpWinfrom.Rule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpWinfrom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }


        private void btn_点杀大小_Click(object sender, EventArgs e)
        {
            点杀大小 f1 = new 点杀大小();



            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_点杀大小.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_点杀大小.Text += item.Text + ",";
                }
                this.tb_点杀大小.Text = this.tb_点杀大小.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void btn_清空点杀大小_Click(object sender, EventArgs e)
        {
            this.tb_点杀大小.Text = string.Empty;
        }

        private void btn_点杀奇偶_Click(object sender, EventArgs e)
        {
            点杀奇偶 f1 = new 点杀奇偶();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_点杀奇偶.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_点杀奇偶.Text += item.Text + ",";
                }
                this.tb_点杀奇偶.Text = this.tb_点杀奇偶.Text.TrimEnd(',');



                f1.Close();

            }
        }
        private void btn_清空点杀奇偶_Click(object sender, EventArgs e)
        {
            this.tb_点杀奇偶.Text = string.Empty;
        }

        private void btn_点杀质合_Click(object sender, EventArgs e)
        {
            this.tb_点杀质合.Text = string.Empty;
        }

        private void btn_点杀质数_Click(object sender, EventArgs e)
        {
            点杀质合 f1 = new 点杀质合();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_点杀质合.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_点杀质合.Text += item.Text + ",";
                }
                this.tb_点杀质合.Text = this.tb_点杀质合.Text.TrimEnd(',');



                f1.Close();

            }
        }

        private void btn_点杀012_Click(object sender, EventArgs e)
        {
            点杀012 f1 = new 点杀012();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_点杀012.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_点杀012.Text += item.Text + ",";
                }
                this.tb_点杀012.Text = this.tb_点杀012.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void btn_清空点杀012_Click(object sender, EventArgs e)
        {
            this.tb_点杀012.Text = string.Empty;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            cb_qian0.Checked = false;
            cb_qian1.Checked = false;
            cb_qian2.Checked = false;
            cb_qian3.Checked = false;
            cb_qian4.Checked = false;
            cb_qian5.Checked = false;
            cb_qian6.Checked = false;
            cb_qian7.Checked = false;
            cb_qian8.Checked = false;
            cb_qian9.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_bai0.Checked = false;
            cb_bai1.Checked = false;
            cb_bai2.Checked = false;
            cb_bai3.Checked = false;
            cb_bai4.Checked = false;
            cb_bai5.Checked = false;
            cb_bai6.Checked = false;
            cb_bai7.Checked = false;
            cb_bai8.Checked = false;
            cb_bai9.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_shi0.Checked = false;
            cb_shi1.Checked = false;
            cb_shi2.Checked = false;
            cb_shi3.Checked = false;
            cb_shi4.Checked = false;
            cb_shi5.Checked = false;
            cb_shi6.Checked = false;
            cb_shi7.Checked = false;
            cb_shi8.Checked = false;
            cb_shi9.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_ge0.Checked = false;
            cb_ge1.Checked = false;
            cb_ge2.Checked = false;
            cb_ge3.Checked = false;
            cb_ge4.Checked = false;
            cb_ge5.Checked = false;
            cb_ge6.Checked = false;
            cb_ge7.Checked = false;
            cb_ge8.Checked = false;
            cb_ge9.Checked = false;
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            四位和值 f1 = new 四位和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_四位和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_四位和值.Text += item.Text + ",";
                }
                this.tb_四位和值.Text = this.tb_四位和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            前三和值 f1 = new 前三和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_前三和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_前三和值.Text += item.Text + ",";
                }
                this.tb_前三和值.Text = this.tb_前三和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            后三和值 f1 = new 后三和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_后三和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_后三和值.Text += item.Text + ",";
                }
                this.tb_后三和值.Text = this.tb_后三和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            后二和值 f1 = new 后二和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_后二和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_后二和值.Text += item.Text + ",";
                }
                this.tb_后二和值.Text = this.tb_后二和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            中二和值 f1 = new 中二和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_中二和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_中二和值.Text += item.Text + ",";
                }
                this.tb_中二和值.Text = this.tb_中二和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            前二和值 f1 = new 前二和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_前二和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_前二和值.Text += item.Text + ",";
                }
                this.tb_前二和值.Text = this.tb_前二和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            千百个和值 f1 = new 千百个和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_千百个和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_千百个和值.Text += item.Text + ",";
                }
                this.tb_千百个和值.Text = this.tb_千百个和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            千十个和值 f1 = new 千十个和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_千十个和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_千十个和值.Text += item.Text + ",";
                }
                this.tb_千十个和值.Text = this.tb_千十个和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void btn_计算_Click(object sender, EventArgs e)
        {
            ResnumberModels = AllNumer.GetAllNumer();

            CheckDelNumer();

            foreach (var item in DelnumberModels)
            {
                var whereRemove = ResnumberModels.FirstOrDefault(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4);
                ResnumberModels.Remove(whereRemove);

            }
            PrintDel();
            PrintRes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tb_结果.Text = string.Empty;
            this.tb_被杀号码.Text = string.Empty;
            this.tb_点杀012.Text = string.Empty;
            this.tb_点杀大小.Text = string.Empty;
            this.tb_点杀奇偶.Text = string.Empty;
            this.tb_点杀质合.Text = string.Empty;
            this.tb_垃圾号.Text = string.Empty;

            foreach (var item in groupBox8.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Text = string.Empty;
                }
            }

            foreach (var item in groupBox7.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }

            }
            foreach (var item in groupBox9.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }

            }
            foreach (var item in groupbox15.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }

            }

            button9_Click(null, null);
            button15_Click(null, null);
            button29_Click(null, null);
            button1_Click(null, null);
            button2_Click(null, null);
            button3_Click(null, null);



        }

        private void btn_导出_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                string value = this.tb_结果.Text;
                string filename = "排列四-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                string path = foldPath + "\\" + filename;


                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(value);
                    sw.Close();
                }


                MessageBox.Show("导出成功:" + path);

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        List<NumberModel> DelnumberModels = new List<NumberModel>();
        List<NumberModel> ResnumberModels = new List<NumberModel>();
        private void button13_Click(object sender, EventArgs e)
        {



            CheckDelNumer();

            PrintDel();
        }

        /// <summary>
        /// 输出被杀号码
        /// </summary>
        private void PrintDel()
        {

            this.tb_被杀号码.Text = string.Empty;
            this.lb_被杀数量.Text = "0";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in DelnumberModels)
            {
                stringBuilder.Append(item.GetString() + " ");
            }
            this.tb_被杀号码.Text = stringBuilder.ToString().TrimEnd(' ');
            this.lb_被杀数量.Text = DelnumberModels.Count.ToString();
        }
        private void PrintRes()
        {

            this.tb_结果.Text = string.Empty;
            this.lb_结果数量.Text = "0";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in ResnumberModels)
            {
                stringBuilder.Append(item.GetString() + " ");
            }
            this.tb_结果.Text = stringBuilder.ToString().TrimEnd(' ');
            this.lb_结果数量.Text = ResnumberModels.Count.ToString();
        }

        private void CheckDelNumer()
        {
            DelnumberModels.Clear();

            #region 特殊杀号
            if (ck_ABCD.Checked)
            {
                Rule.Teshuhao.ABCD(ref DelnumberModels);
            }

            if (ck_AABC.Checked)
            {
                Teshuhao.AABC(ref DelnumberModels);
            }
            if (ck_AABB.Checked)
            {
                Teshuhao.AABB(ref DelnumberModels);
            }

            if (ck_AAAB.Checked)
            {
                Teshuhao.AAAB(ref DelnumberModels);
            }
            if (ck_AAAA.Checked)
            {
                Teshuhao.AAAA(ref DelnumberModels);
            }
            if (ck_不连.Checked)
            {
                Teshuhao.不连(ref DelnumberModels);
            }
            if (ck_2个顺子.Checked)
            {
                Teshuhao.两个顺子(ref DelnumberModels);
            }

            if (ck_兄弟号.Checked)
            {
                Teshuhao.兄弟号(ref DelnumberModels);
            }

            if (ck_非兄弟号.Checked)
            {
                Teshuhao.非兄弟号(ref DelnumberModels);
            }
            if (ck_全大.Checked)
            {
                Teshuhao.全大(ref DelnumberModels);
            }
            if (ck_全小.Checked)
            {
                Teshuhao.全小(ref DelnumberModels);
            }
            if (ck_全奇.Checked)
            {
                Teshuhao.全奇(ref DelnumberModels);
            }
            if (ck_全偶.Checked)
            {
                Teshuhao.全偶(ref DelnumberModels);
            }
            if (ck_对数.Checked)
            {
                Teshuhao.对数(ref DelnumberModels);
            }
            if (ck_杀05.Checked)
            {
                Teshuhao.M05对数(ref DelnumberModels);
            }
            if (ck_杀16.Checked)
            {
                Teshuhao.M16对数(ref DelnumberModels);
            }
            if (ck_杀27.Checked)
            {
                Teshuhao.M27对数(ref DelnumberModels);
            }
            if (ck_杀38.Checked)
            {
                Teshuhao.M38对数(ref DelnumberModels);
            }
            if (ck_杀49.Checked)
            {
                Teshuhao.M49对数(ref DelnumberModels);
            }

            #region 杀指定连号

            if (ck_杀01.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 0, 1);
            }
            if (ck_杀12.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 1, 2);
            }
            if (ck_杀23.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 2, 3);
            }
            if (ck_杀34.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 3, 4);
            }
            if (ck_杀45.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 4, 5);
            }
            if (ck_杀56.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 5, 6);
            }
            if (ck_杀67.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 6, 7);
            }

            if (ck_杀78.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 7, 8);
            }
            if (ck_杀89.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 8, 9);
            }
            if (ck_杀90.Checked)
            {
                Teshuhao.杀两位固定数(ref DelnumberModels, 9, 0);
            }



            if (ck_杀012.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 0, 1, 2);
            }
            if (ck_杀123.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 1, 2, 3);
            }
            if (ck_杀234.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 2, 3, 4);
            }

            if (ck_杀345.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 3, 4, 5);
            }
            if (ck_杀456.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 4, 5, 6);
            }
            if (ck_杀567.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 5, 6, 7);
            }

            if (ck_杀678.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 6, 7, 8);
            }
            if (ck_杀789.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 7, 8, 9);
            }
            if (ck_杀890.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 8, 9, 0);
            }
            if (ck_杀901.Checked)
            {
                Teshuhao.杀三位固定数(ref DelnumberModels, 9, 0, 1);
            }

            #endregion

            if (ck_杀00.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 0);
            }
            if (ck_杀11.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 1);
            }
            if (ck_杀22.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 2);
            }
            if (ck_杀33.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 3);
            }
            if (ck_杀44.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 4);
            }
            if (ck_杀55.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 5);
            }
            if (ck_杀66.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 6);
            }
            if (ck_杀77.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 7);
            }
            if (ck_杀88.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 8);
            }
            if (ck_杀99.Checked)
            {
                Teshuhao.杀两重号(ref DelnumberModels, 9);
            }

            #region 杀指定双重号
            #endregion

            #endregion

            #region 点杀区域


            if (ck_点杀大小.Checked && !string.IsNullOrEmpty(this.tb_点杀大小.Text))
            {

                string[] array = this.tb_点杀大小.Text.Split(',');
                Diansha.大小enter(array, ref DelnumberModels);
            }

            if (ck_点杀奇偶.Checked && !string.IsNullOrEmpty(this.tb_点杀奇偶.Text))
            {
                string[] array = this.tb_点杀奇偶.Text.Split(',');
                Diansha.奇偶enter(array, ref DelnumberModels);
            }

            if (ck_点杀质合.Checked && !string.IsNullOrEmpty(this.tb_点杀质合.Text))
            {
                string[] array = this.tb_点杀质合.Text.Split(',');
                Diansha.质合enter(array, ref DelnumberModels);

            }
            if (ck_点杀012.Checked && !string.IsNullOrEmpty(this.tb_点杀012.Text))
            {
                string[] array = this.tb_点杀012.Text.Split(',');
                Diansha.L012enter(array, ref DelnumberModels);

            }
            if (ck_垃圾号.Checked && !string.IsNullOrEmpty(this.tb_垃圾号.Text))
            {
                string[] array = this.tb_垃圾号.Text.Split(' ');

                List<NumberModel> list = new List<NumberModel>();

                foreach (var n in array)
                {
                    if (!string.IsNullOrEmpty(n.Trim(' ').Trim('\r').Trim('\n')))
                    {
                        NumberModel number = NumberModel.ToParse(n);
                        list.Add(number);
                    }


                }
                lajihao.Enter(list, ref DelnumberModels);

            }


            #endregion

            #region 和值区域

            if (ck_四位和值.Checked && !string.IsNullOrEmpty(tb_四位和值.Text))
            {
                string[] array = this.tb_四位和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.四位和值(iNums, ref DelnumberModels);
            }


            if (ck_前三和值.Checked && !string.IsNullOrEmpty(tb_前三和值.Text))
            {
                string[] array = this.tb_前三和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.前三和值(iNums, ref DelnumberModels);
            }
            if (ck_后三和值.Checked && !string.IsNullOrEmpty(tb_后三和值.Text))
            {
                string[] array = this.tb_后三和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.后三和值(iNums, ref DelnumberModels);
            }

            if (ck_前二和值.Checked && !string.IsNullOrEmpty(tb_前二和值.Text))
            {
                string[] array = this.tb_前二和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.前二和值(iNums, ref DelnumberModels);
            }
            if (ck_中二和值.Checked && !string.IsNullOrEmpty(tb_中二和值.Text))
            {
                string[] array = this.tb_中二和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.中二和值(iNums, ref DelnumberModels);
            }
            if (ck_后二和值.Checked && !string.IsNullOrEmpty(tb_后二和值.Text))
            {
                string[] array = this.tb_后二和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.后二和值(iNums, ref DelnumberModels);
            }
            if (ck_千百个和值.Checked && !string.IsNullOrEmpty(tb_千百个和值.Text))
            {
                string[] array = this.tb_千百个和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.千百个和值(iNums, ref DelnumberModels);
            }
            if (ck_千十个和值.Checked && !string.IsNullOrEmpty(tb_千十个和值.Text))
            {
                string[] array = this.tb_千十个和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.千十个和值(iNums, ref DelnumberModels);
            }


            if (ck_奇数和值.Checked && !string.IsNullOrEmpty(tb_奇数和值.Text))
            {
                string[] array = this.tb_奇数和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.奇数和值(iNums, ref DelnumberModels);
            }
            if (ck_偶数和值.Checked && !string.IsNullOrEmpty(tb_偶数和值.Text))
            {
                string[] array = this.tb_偶数和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.偶数和值(iNums, ref DelnumberModels);
            }

            if (ck_千个和值.Checked && !string.IsNullOrEmpty(tb_千个和值.Text))
            {
                string[] array = this.tb_千个和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.千个和值(iNums, ref DelnumberModels);
            }
            if (ck_千十和值.Checked && !string.IsNullOrEmpty(tb_千十和值.Text))
            {
                string[] array = this.tb_千十和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.千十和值(iNums, ref DelnumberModels);
            }
            if (ck_百个和值.Checked && !string.IsNullOrEmpty(tb_百个和值.Text))
            {
                string[] array = this.tb_百个和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);

                hezhishahao.百个和值(iNums, ref DelnumberModels);
            }

            #endregion

            #region 杀定位区域

            if (ck_杀定位.Checked)
            {
                List<int> qian = new List<int>();
                List<int> bai = new List<int>();
                List<int> shi = new List<int>();
                List<int> ge = new List<int>();

                foreach (var item in panel_qian.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked)
                        {
                            qian.Add(int.Parse(cb.Text));
                        }
                    }

                }
                foreach (var item in panel_bai.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked)
                        {
                            bai.Add(int.Parse(cb.Text));
                        }
                    }

                }
                foreach (var item in panel_shi.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked)
                        {
                            shi.Add(int.Parse(cb.Text));
                        }
                    }

                }
                foreach (var item in panel_ge.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked)
                        {
                            ge.Add(int.Parse(cb.Text));
                        }
                    }

                }
                shadingwei.Enter(qian, bai, shi, ge, ref DelnumberModels);
            }



            #endregion



            #region 杀连号

            if (ck_无序2连.Checked)
            {
                shalianhao.无序2连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }
            if (ck_无序3连.Checked)
            {
                shalianhao.无序3连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }
            if (ck_无序4连.Checked)
            {
                shalianhao.无序4连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }



            if (ck_正向2连.Checked)
            {
                shalianhao.正向2连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }
            if (ck_正向3连.Checked)
            {
                shalianhao.正向3连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }
            if (ck_正向4连.Checked)
            {
                shalianhao.正向4连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }


            if (ck_反向2连.Checked)
            {
                shalianhao.反向2连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }
            if (ck_反向3连.Checked)
            {
                shalianhao.反向3连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }
            if (ck_反向4连.Checked)
            {
                shalianhao.反向4连(this.ck_首尾相连.Checked, this.ck_09相连.Checked, ref DelnumberModels);
            }

            #endregion


            #region 两数和值

            if (ck_两数和值.Checked && !string.IsNullOrEmpty(tb_两数和值.Text))
            {
                string[] array = this.tb_两数和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);
                List<int> list = iNums.ToList();
                dingliangshuhezhi.两数和值(list, ref DelnumberModels);
            }

            if (ck_三数和值.Checked && !string.IsNullOrEmpty(tb_三数和值.Text))
            {
                string[] array = this.tb_三数和值.Text.Split(',');
                int[] iNums = Array.ConvertAll(array, int.Parse);
                List<int> list = iNums.ToList();
                dingliangshuhezhi.三数和值(list, ref DelnumberModels);
            }

            #endregion


            #region 杀胆码 杀跨度  杀胆必须是最后一项

            if (ck_杀跨度.Checked)
            {
                List<int> kuada = new List<int>();
                foreach (var item in groupBox11.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked && cb.Name != "ck_杀跨度")
                        {
                            kuada.Add(int.Parse(cb.Text));
                        }
                    }

                }
                shakuadu.Enter(kuada, ref DelnumberModels);
            }

            if (ck_杀胆码.Checked)
            {
                List<int> danma = new List<int>();
                foreach (var item in groupBox10.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked && cb.Name != "ck_杀胆码")
                        {
                            danma.Add(int.Parse(cb.Text));
                        }
                    }

                }
                shadanma.ShaWuYiMa(danma, ref DelnumberModels);
            }



            #endregion
            // 杀胆码必须是最后一项

        }

        private void button14_Click(object sender, EventArgs e)
        {
            DelnumberModels = Tool.ListSort(DelnumberModels);

            PrintDel();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ResnumberModels = Tool.ListSort(ResnumberModels);
            PrintRes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control groupBox in Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control cl in groupBox7.Controls)
                    {
                        if (cl is CheckBox)
                        {
                            CheckBox box = (CheckBox)cl;
                            box.Checked = false;
                        }

                    }
                }
            }
        }

        private void ck_兄弟号_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ck_非兄弟号_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox11.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if (cb.Checked && cb.Name != "ck_杀跨度")
                    {
                        cb.Checked = false;
                    }
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox10.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if (cb.Checked && cb.Name != "ck_杀胆码")
                    {
                        cb.Checked = false;
                    }
                }

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            统计 f = new 统计();
            f.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tb_结果.Text);
            MessageBox.Show("复制成功！");
        }

        private void tb_检索del_TextChanged(object sender, EventArgs e)
        {
            string del = this.tb_被杀号码.Text;
            string val = this.tb_检索del.Text.Trim();

            if (val.Length != 4)
            {
                this.lb_cunzaidel.Text = "";
                return;

            }


            if (del.IndexOf(val) >= 0)
            {
                tb_被杀号码.Focus();

                tb_被杀号码.SelectionStart = del.IndexOf(val);  //设置起始位置 

                tb_被杀号码.SelectionLength = 4;  //设置长度

                tb_被杀号码.ScrollToCaret();

                this.lb_cunzaidel.Text = "存在";
                return;
            }
            this.lb_cunzaidel.Text = "不存在";
        }

        private void tb_检索res_TextChanged(object sender, EventArgs e)
        {
            string del = this.tb_结果.Text;
            string val = this.tb_检索res.Text.Trim();

            if (val.Length != 4)
            {
                this.lb_cunzaires.Text = "";
                return;

            }


            if (del.IndexOf(val) >= 0)
            {
                tb_结果.Focus();

                tb_结果.SelectionStart = del.IndexOf(val);  //设置起始位置 

                tb_结果.SelectionLength = 4;  //设置长度

                tb_结果.ScrollToCaret();

                this.lb_cunzaires.Text = "存在";
                return;
            }
            this.lb_cunzaires.Text = "不存在";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            奇数和值 f1 = new 奇数和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_奇数和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_奇数和值.Text += item.Text + ",";
                }
                this.tb_奇数和值.Text = this.tb_奇数和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            偶数和值 f1 = new 偶数和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_偶数和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_偶数和值.Text += item.Text + ",";
                }
                this.tb_偶数和值.Text = this.tb_偶数和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            千个和值 f1 = new 千个和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_千个和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_千个和值.Text += item.Text + ",";
                }
                this.tb_千个和值.Text = this.tb_千个和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            千十和值 f1 = new 千十和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_千十和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_千十和值.Text += item.Text + ",";
                }
                this.tb_千十和值.Text = this.tb_千十和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            百个和值 f1 = new 百个和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_百个和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_百个和值.Text += item.Text + ",";
                }
                this.tb_百个和值.Text = this.tb_百个和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            比较 f = new 比较();
            f.Show();
        }


        private float X;

        private float Y;

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                if (Screen.PrimaryScreen.Bounds.Width < 1400)
                {
                    con.Font = new Font(con.Font.Name, 9, con.Font.Style, con.Font.Unit);
                }
                else
                {
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                if (con is Button)
                {
                    con.Height = con.Height + 3;
                }

                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            int SX = Screen.PrimaryScreen.Bounds.Width - 200;
            int SY = Screen.PrimaryScreen.Bounds.Height - 200;



            float newx = SX / X;
            float newy = SY / Y;


            setControls(newx, newy, this);





        }

        private void Main_Load(object sender, EventArgs e)
        {

            this.Resize += new EventHandler(Main_Resize);
            X = this.Width;
            Y = this.Height;


            setTag(this);
            Main_Resize(new object(), new EventArgs());//x,y可在实例化时赋值,最后这句是新加的，在MDI时有用
        }


        private void button25_Click_1(object sender, EventArgs e)
        {
            两数和值 f1 = new 两数和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_两数和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_两数和值.Text += item.Text + ",";
                }
                this.tb_两数和值.Text = this.tb_两数和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void tb_被杀号码_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            三数和值 f1 = new 三数和值();


            if (f1.ShowDialog() == DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_三数和值.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_三数和值.Text += item.Text + ",";
                }
                this.tb_三数和值.Text = this.tb_三数和值.Text.TrimEnd(',');



                f1.Close();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            格式化成一行 s = new 格式化成一行();
            s.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            开奖记录 s = new 开奖记录();
            s.Show();
        }
    }
}
