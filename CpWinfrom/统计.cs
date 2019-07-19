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
    public partial class 统计 : Form
    {
        public 统计()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (this.textBox1.Text.Contains(','))
            {
                string[] p = textBox1.Text.Split(',');
                this.label1.Text = p.Length.ToString();

            }
            else
            {
                string[] p = textBox1.Text.Split(' ');
                this.label1.Text = p.Length.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
