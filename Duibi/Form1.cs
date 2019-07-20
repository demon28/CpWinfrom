using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = this.textBox1.Text.Split(' ');

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in str)
            {
                stringBuilder.AppendLine(item + " ");
            }

            this.textBox2.Text = stringBuilder.ToString();
        }
    }
}
