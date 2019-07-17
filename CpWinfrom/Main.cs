using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

           

            if (f1.ShowDialog()==DialogResult.OK)
            {
                List<CheckBox> checkBoxes = f1.cks;

                this.tb_点杀大小.Text = string.Empty;
                foreach (var item in checkBoxes)
                {
                    this.tb_点杀大小.Text += item.Text+",";
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
    }
}
