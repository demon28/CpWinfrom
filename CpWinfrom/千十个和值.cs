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
    public partial class 千十个和值 : Form
    {
        public 千十个和值()
        {
            InitializeComponent();
        }


        public List<CheckBox> cks = new List<CheckBox>();
        private void btn_全选_Click(object sender, EventArgs e)
        {
            foreach (Control groupBox in Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control cl in groupBox.Controls)
                    {
                        if (cl is CheckBox)
                        {
                            CheckBox box = (CheckBox)cl;
                            box.Checked = true;
                        }

                    }
                }
            }
        }

        private void btn_清空_Click(object sender, EventArgs e)
        {
            foreach (Control groupBox in Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control cl in groupBox.Controls)
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

        private void btn_确定_Click(object sender, EventArgs e)
        {
            foreach (Control groupBox in Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control cl in groupBox.Controls)
                    {
                        if (cl is CheckBox)
                        {
                            CheckBox box = (CheckBox)cl;
                            if (box.Checked)
                            {
                                cks.Add(box);
                            }
                        }

                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btn_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
