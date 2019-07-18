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
        }

        private void btn_导出_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                string value = this.tb_结果.Text;
                string filename = "四星杀号-" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
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
                stringBuilder.AppendLine(item.GetString() + ",");
            }
            this.tb_被杀号码.Text = stringBuilder.ToString().TrimEnd(',');
            this.lb_被杀数量.Text = DelnumberModels.Count.ToString();
        }
        private void PrintRes()
        {

            this.tb_结果.Text = string.Empty;
            this.lb_结果数量.Text = "0";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in ResnumberModels)
            {
                stringBuilder.AppendLine(item.GetString() + ",");
            }
            this.tb_结果.Text = stringBuilder.ToString().TrimEnd(',');
            this.lb_结果数量.Text = ResnumberModels.Count.ToString();
        }

        private void CheckDelNumer()
        {
            DelnumberModels.Clear();

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
    }
}
