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
    public partial class Form1 : Form
    {
        public List<NumberModel> allnumber = new List<NumberModel>();
        public List<NumberModel> resnumber = new List<NumberModel>();
        public List<NumberModel> delnumber = new List<NumberModel>();

        public Form1()
        {
            InitializeComponent();
            allnumber = AllNumer.GetAllNumer();
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
            allnumber = AllNumer.GetAllNumer();
            this.tb_con.Text = string.Empty;
            this.tb_res.Text = string.Empty;
            delnumber.Clear();
            Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Print()
        {
            StringBuilder conres = new StringBuilder();
            foreach (var item in delnumber)
            {
                conres.AppendLine(item.GetString());

                var whereRemove = allnumber.FirstOrDefault(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4);
                allnumber.Remove(whereRemove);
            }

            StringBuilder sbres = new StringBuilder();
            foreach (var item in allnumber)
            {
                sbres.AppendLine(item.GetString());
            }

            this.tb_res.Text = sbres.ToString();
            this.tb_con.Text = conres.ToString();
            this.lb_count.Text = allnumber.Count.ToString();


        }
        public void Del(NumberModel model)
        {

            if (delnumber.Where(S => S.N1 == model.N1 && S.N2 == model.N2 && S.N3 == model.N3 && S.N4 == model.N4).ToList().Count > 0)
            {
                return;
            }
            delnumber.Add(model);
        }
        private void Export(string filePath, string value)
        {

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(value);
                sw.Close();
            }

        }



        private void btn_shabaozi_Click(object sender, EventArgs e)
        {

            foreach (var item in allnumber)
            {
                if (item.N1 == item.N2 && item.N2 == item.N3 && item.N3 == item.N4)
                {
                    Del(item);
                }
            }


            Print();

        }

        private void btn_sanbaozi_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N2 && item.N2 == item.N3)
                {
                    Del(item);
                }
            }


            foreach (var item in allnumber)
            {
                if (item.N2 == item.N3 && item.N3 == item.N4)
                {
                    Del(item);
                }
            }


            Print();
        }

        /// <summary>
        /// 杀三连号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N2 && item.N2 == item.N4)
                {
                    Del(item);
                }
            }


            foreach (var item in allnumber)
            {
                if (item.N1 == item.N3 && item.N3 == item.N4)
                {
                    Del(item);
                }
            }


            Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N2 && item.N3 == item.N4)
                {
                    Del(item);
                }
            }

            Print();
        }
        /// <summary>
        /// 杀全偶数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (Tool.CheckOdd(item))
                {
                    Del(item);
                }
            }


            Print();
        }
        /// <summary>
        /// 杀全奇数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (Tool.ChecNotkOdd(item))
                {
                    Del(item);
                }
            }

            Print();
        }
        /// <summary>
        /// 杀全小数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {

            foreach (var item in allnumber)
            {
                if (Tool.CheckSmall(item))
                {
                    Del(item);
                }
            }
            Print();
        }

        /// <summary>
        /// 杀全大数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (Tool.CheckBig(item))
                {
                    Del(item);
                }
            }

            Print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 + 1 == item.N2 && item.N2 + 1 == item.N3 && item.N3 + 1 == item.N4)
                {
                    Del(item);
                }
                if (item.N2 + 1 == item.N3 && item.N3 + 1 == item.N4 && item.N4 + 1 == item.N1)
                {
                    Del(item);
                }
                if (item.N3 + 1 == item.N4 && item.N4 + 1 == item.N1 && item.N1 + 1 == item.N2)
                {
                    Del(item);
                }
                if (item.N4 + 1 == item.N1 && item.N1 + 1 == item.N2 && item.N2 + 1 == item.N3)
                {
                    Del(item);
                }
            }

            Print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N4 && item.N3 == item.N2)
                {
                    Del(item);
                }
            }

            Print();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N2 == item.N1 + 1 && item.N3 == item.N2 + 1 && item.N4 == item.N3 + 1)
                {
                    Del(item);
                }
                if (cb_is09.Checked)
                {
                    if (item.N1 == 7 && item.N2 == 8 && item.N3 == 9 && item.N4 == 0)
                    {
                        Del(item);
                    }
                    if (item.N1 == 8 && item.N2 == 9 && item.N3 == 0 && item.N4 == 1)
                    {
                        Del(item);
                    }
                    if (item.N1 == 9 && item.N2 == 0 && item.N3 == 1 && item.N4 == 2)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N3 == item.N2 + 1 && item.N4 == item.N3 + 1 && item.N1 == item.N4 + 1)
                {
                    Del(item);
                }
                if (cb_is09.Checked)
                {
                    if (item.N1 == 0 && item.N2 == 7 && item.N3 == 8 && item.N4 == 9)
                    {
                        Del(item);
                    }
                    if (item.N1 == 1 && item.N2 == 8 && item.N3 == 9 && item.N4 == 0)
                    {
                        Del(item);
                    }
                    if (item.N1 == 2 && item.N2 == 9 && item.N3 == 0 && item.N4 == 1)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N4 == item.N3 + 1 && item.N1 == item.N4 + 1 && item.N2 == item.N1 + 1)
                {
                    Del(item);
                }
                if (cb_is09.Checked)
                {
                    if (item.N1 == 9 && item.N2 == 0 && item.N3 == 7 && item.N4 == 8)
                    {
                        Del(item);
                    }
                    if (item.N1 == 0 && item.N2 == 1 && item.N3 == 8 && item.N4 == 9)
                    {
                        Del(item);
                    }
                    if (item.N1 == 1 && item.N2 == 2 && item.N3 == 9 && item.N4 == 0)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N4 + 1 && item.N2 == item.N1 + 1 && item.N3 == item.N2 + 1)
                {
                    Del(item);
                }


                if (cb_is09.Checked)
                {

                    if (item.N1 == 8 && item.N2 == 9 && item.N3 == 0 && item.N4 == 7)
                    {
                        Del(item);
                    }
                    if (item.N1 == 9 && item.N2 == 0 && item.N3 == 1 && item.N4 == 8)
                    {
                        Del(item);
                    }
                    if (item.N1 == 0 && item.N2 == 1 && item.N3 == 2 && item.N4 == 9)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        /// <summary>
        /// 和值大于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.tb_hezhidayu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_hezhidayu.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 + item.N2 + item.N3 + item.N4 > sum)
                {
                    Del(item);
                }

            }

            Print();
        }
        /// <summary>
        ///  和值等于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_hezhidengyu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_hezhidengyu.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 + item.N2 + item.N3 + item.N4 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }
        /// <summary>
        /// 和值小于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_hezhixiaoyu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_hezhixiaoyu.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 + item.N2 + item.N3 + item.N4 < sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_geweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_geweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N4 != sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_shiweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_shiweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N3 != sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_baiweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_baiweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N2 != sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_qianweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_qianweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 != sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_geweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_geweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N4 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_shiweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_shiweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N3 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_baiweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_baiweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N2 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_qianweidingwei.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_qianweidingwei.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }
        /// <summary>
        /// 个位多值定位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            List<int> list_ge = new List<int>();
            if (cb_ge0.Checked)
            {
                list_ge.Add(0);
            }
            if (cb_ge1.Checked)
            {
                list_ge.Add(1);
            }
            if (cb_ge2.Checked)
            {
                list_ge.Add(2);
            }
            if (cb_ge3.Checked)
            {
                list_ge.Add(3);
            }
            if (cb_ge4.Checked)
            {
                list_ge.Add(4);
            }
            if (cb_ge5.Checked)
            {
                list_ge.Add(5);
            }
            if (cb_ge6.Checked)
            {
                list_ge.Add(6);
            }
            if (cb_ge7.Checked)
            {
                list_ge.Add(7);
            }
            if (cb_ge8.Checked)
            {
                list_ge.Add(8);
            }
            if (cb_ge9.Checked)
            {
                list_ge.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (!list_ge.Contains(item.N4))
                {
                    Del(item);
                }

            }

            Print();



        }

        private void button24_Click(object sender, EventArgs e)
        {
            List<int> list_ge = new List<int>();
            if (cb_ge0.Checked)
            {
                list_ge.Add(0);
            }
            if (cb_ge1.Checked)
            {
                list_ge.Add(1);
            }
            if (cb_ge2.Checked)
            {
                list_ge.Add(2);
            }
            if (cb_ge3.Checked)
            {
                list_ge.Add(3);
            }
            if (cb_ge4.Checked)
            {
                list_ge.Add(4);
            }
            if (cb_ge5.Checked)
            {
                list_ge.Add(5);
            }
            if (cb_ge6.Checked)
            {
                list_ge.Add(6);
            }
            if (cb_ge7.Checked)
            {
                list_ge.Add(7);
            }
            if (cb_ge8.Checked)
            {
                list_ge.Add(8);
            }
            if (cb_ge9.Checked)
            {
                list_ge.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (list_ge.Contains(item.N4))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            List<int> list_shi = new List<int>();
            if (cb_shi0.Checked)
            {
                list_shi.Add(0);
            }
            if (cb_shi1.Checked)
            {
                list_shi.Add(1);
            }
            if (cb_shi2.Checked)
            {
                list_shi.Add(2);
            }
            if (cb_shi3.Checked)
            {
                list_shi.Add(3);
            }
            if (cb_shi4.Checked)
            {
                list_shi.Add(4);
            }
            if (cb_shi5.Checked)
            {
                list_shi.Add(5);
            }
            if (cb_shi6.Checked)
            {
                list_shi.Add(6);
            }
            if (cb_shi7.Checked)
            {
                list_shi.Add(7);
            }
            if (cb_shi8.Checked)
            {
                list_shi.Add(8);
            }
            if (cb_shi9.Checked)
            {
                list_shi.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (!list_shi.Contains(item.N3))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            List<int> list_shi = new List<int>();
            if (cb_shi0.Checked)
            {
                list_shi.Add(0);
            }
            if (cb_shi1.Checked)
            {
                list_shi.Add(1);
            }
            if (cb_shi2.Checked)
            {
                list_shi.Add(2);
            }
            if (cb_shi3.Checked)
            {
                list_shi.Add(3);
            }
            if (cb_shi4.Checked)
            {
                list_shi.Add(4);
            }
            if (cb_shi5.Checked)
            {
                list_shi.Add(5);
            }
            if (cb_shi6.Checked)
            {
                list_shi.Add(6);
            }
            if (cb_shi7.Checked)
            {
                list_shi.Add(7);
            }
            if (cb_shi8.Checked)
            {
                list_shi.Add(8);
            }
            if (cb_shi9.Checked)
            {
                list_shi.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (list_shi.Contains(item.N3))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            List<int> list_bai = new List<int>();
            if (cb_bai0.Checked)
            {
                list_bai.Add(0);
            }
            if (cb_bai1.Checked)
            {
                list_bai.Add(1);
            }
            if (cb_bai2.Checked)
            {
                list_bai.Add(2);
            }
            if (cb_bai3.Checked)
            {
                list_bai.Add(3);
            }
            if (cb_bai4.Checked)
            {
                list_bai.Add(4);
            }
            if (cb_bai5.Checked)
            {
                list_bai.Add(5);
            }
            if (cb_bai6.Checked)
            {
                list_bai.Add(6);
            }
            if (cb_bai7.Checked)
            {
                list_bai.Add(7);
            }
            if (cb_bai8.Checked)
            {
                list_bai.Add(8);
            }
            if (cb_bai9.Checked)
            {
                list_bai.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (!list_bai.Contains(item.N2))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            List<int> list_bai = new List<int>();
            if (cb_bai0.Checked)
            {
                list_bai.Add(0);
            }
            if (cb_bai1.Checked)
            {
                list_bai.Add(1);
            }
            if (cb_bai2.Checked)
            {
                list_bai.Add(2);
            }
            if (cb_bai3.Checked)
            {
                list_bai.Add(3);
            }
            if (cb_bai4.Checked)
            {
                list_bai.Add(4);
            }
            if (cb_bai5.Checked)
            {
                list_bai.Add(5);
            }
            if (cb_bai6.Checked)
            {
                list_bai.Add(6);
            }
            if (cb_bai7.Checked)
            {
                list_bai.Add(7);
            }
            if (cb_bai8.Checked)
            {
                list_bai.Add(8);
            }
            if (cb_bai9.Checked)
            {
                list_bai.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (list_bai.Contains(item.N2))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            List<int> list_qian = new List<int>();
            if (cb_qian0.Checked)
            {
                list_qian.Add(0);
            }
            if (cb_qian1.Checked)
            {
                list_qian.Add(1);
            }
            if (cb_qian2.Checked)
            {
                list_qian.Add(2);
            }
            if (cb_qian3.Checked)
            {
                list_qian.Add(3);
            }
            if (cb_qian4.Checked)
            {
                list_qian.Add(4);
            }
            if (cb_qian5.Checked)
            {
                list_qian.Add(5);
            }
            if (cb_qian6.Checked)
            {
                list_qian.Add(6);
            }
            if (cb_qian7.Checked)
            {
                list_qian.Add(7);
            }
            if (cb_qian8.Checked)
            {
                list_qian.Add(8);
            }
            if (cb_qian9.Checked)
            {
                list_qian.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (!list_qian.Contains(item.N1))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            List<int> list_qian = new List<int>();
            if (cb_qian0.Checked)
            {
                list_qian.Add(0);
            }
            if (cb_qian1.Checked)
            {
                list_qian.Add(1);
            }
            if (cb_qian2.Checked)
            {
                list_qian.Add(2);
            }
            if (cb_qian3.Checked)
            {
                list_qian.Add(3);
            }
            if (cb_qian4.Checked)
            {
                list_qian.Add(4);
            }
            if (cb_qian5.Checked)
            {
                list_qian.Add(5);
            }
            if (cb_qian6.Checked)
            {
                list_qian.Add(6);
            }
            if (cb_qian7.Checked)
            {
                list_qian.Add(7);
            }
            if (cb_qian8.Checked)
            {
                list_qian.Add(8);
            }
            if (cb_qian9.Checked)
            {
                list_qian.Add(9);
            }

            foreach (var item in allnumber)
            {
                if (list_qian.Contains(item.N1))
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button33_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.tb_qiansanhezhidayu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_qiansanhezhidayu.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 + item.N2 + item.N3 > sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_qiansanhezhidengyu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_qiansanhezhidengyu.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 + item.N2 + item.N3 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_qiansanhezhixiaoyu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_qiansanhezhixiaoyu.Text);

            foreach (var item in allnumber)
            {
                if (item.N1 + item.N2 + item.N3 < sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_housanhezhidayu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_housanhezhidayu.Text);

            foreach (var item in allnumber)
            {
                if (item.N2 + item.N3 + item.N4 > sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_housanhezhidengyu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_housanhezhidengyu.Text);

            foreach (var item in allnumber)
            {
                if (item.N2 + item.N3 + item.N4 == sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_housanhezhixiaoyu.Text))
            {
                MessageBox.Show("请输入数值！");
                return;
            }

            int sum = int.Parse(this.tb_housanhezhixiaoyu.Text);

            foreach (var item in allnumber)
            {
                if (item.N2 + item.N3 + item.N4 < sum)
                {
                    Del(item);
                }

            }

            Print();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string[] strarray = this.tb_lajihao.Text.Split(',');

            if (strarray.Length <= 0)
            {
                MessageBox.Show("请填写删除的垃圾号，以逗号分割");
                return;
            }

            for (int i = 0; i < strarray.Length; i++)
            {

                NumberModel n = NumberModel.ToParse(strarray[i]);
                Del(n);
            }

            Print();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                string value = this.tb_res.Text;
                string filename = "四星杀号-" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                string path = foldPath + "\\" + filename;
                Export(path, value);

                MessageBox.Show("导出成功:" + path);

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N3 && item.N2 == item.N4)
                {
                    Del(item);
                }
            }

            Print();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N2 == item.N1 -1 && item.N3 == item.N2 - 1 && item.N4 == item.N3 - 1)
                {
                    Del(item);
                }
                if (cb_is09.Checked)
                {
                    if (item.N1 == 0 && item.N2 == 9 && item.N3 == 8 && item.N4 == 7)
                    {
                        Del(item);
                    }
                    if (item.N1 == 1 && item.N2 == 0 && item.N3 == 9 && item.N4 == 8)
                    {
                        Del(item);
                    }
                    if (item.N1 == 2 && item.N2 == 1 && item.N3 == 0 && item.N4 == 9)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N3 == item.N2- 1 && item.N4 == item.N3 - 1 && item.N1 == item.N4 - 1)
                {
                    Del(item);
                }
                if (cb_is09.Checked)
                {
                    if (item.N1 == 7 && item.N2 ==0 && item.N3 ==9 && item.N4 == 8)
                    {
                        Del(item);
                    }
                    if (item.N1 == 8 && item.N2 == 7 && item.N3 == 0 && item.N4 == 9)
                    {
                        Del(item);
                    }
                    if (item.N1 == 9 && item.N2 == 8&& item.N3 == 7&& item.N4 == 0)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N4 == item.N3 - 1 && item.N1 == item.N4 - 1 && item.N2 == item.N1 - 1)
                {
                    Del(item);
                }
                if (cb_is09.Checked)
                {
                    if (item.N1 == 8 && item.N2 == 7 && item.N3 == 0 && item.N4 ==9)
                    {
                        Del(item);
                    }
                    if (item.N1 == 9 && item.N2 ==8 && item.N3 == 7 && item.N4 == 0)
                    {
                        Del(item);
                    }
                    if (item.N1 ==0 && item.N2 == 9 && item.N3 == 8 && item.N4 == 7)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            foreach (var item in allnumber)
            {
                if (item.N1 == item.N4 - 1 && item.N2 == item.N1 -1 && item.N3 == item.N2 - 1)
                {
                    Del(item);
                }


                if (cb_is09.Checked)
                {

                    if (item.N1 == 9 && item.N2 == 8 && item.N3 == 7 && item.N4 == 0)
                    {
                        Del(item);
                    }
                    if (item.N1 == 0 && item.N2 == 9 && item.N3 == 8 && item.N4 == 7)
                    {
                        Del(item);
                    }
                    if (item.N1 == 7 && item.N2 == 0 && item.N3 == 9 && item.N4 == 8)
                    {
                        Del(item);
                    }
                }
            }

            Print();
        }
    }
}
