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
    public partial class 比较 : Form
    {
        public 比较()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            List<string> left = new List<string>();
            List<string> right = new List<string>();
            string[] p;
            string[] l;
            if (this.textBox1.Text.Contains(','))
            {
                 p = textBox1.Text.Split(',');
                this.label1.Text = p.Length.ToString();
                StringBuilder sb = new StringBuilder();
                foreach (var item in p)
                {
                    sb.AppendLine(item);
                
                }
                this.textBox3.Text = sb.ToString();
            }
            else
            {
                 p = textBox1.Text.Split(' ');
                this.label1.Text = p.Length.ToString();
                StringBuilder sb = new StringBuilder();
                foreach (var item in p)
                {
                    sb.AppendLine(item);

                }
                this.textBox3.Text = sb.ToString();
            }

            if (this.textBox2.Text.Contains(','))
            {
                l = textBox2.Text.Split(',');
                this.label2.Text = l.Length.ToString();
                StringBuilder sb = new StringBuilder();
                foreach (var item in l)
                {
                    sb.AppendLine(item);

                }
                this.textBox4.Text = sb.ToString();

            }
            else
            {
               l = textBox2.Text.Split(' ');
                this.label2.Text = l.Length.ToString();
                StringBuilder sb = new StringBuilder();
                foreach (var item in l)
                {
                    sb.AppendLine(item);

                }
                this.textBox4.Text = sb.ToString();
            }
            StringBuilder builderleft = new StringBuilder();
            StringBuilder builderright = new StringBuilder();
            foreach (var item in p)
            {
                if (!l.Contains(item))
                {
                    left.Add(item);
                    builderleft.AppendLine(item);
                }

            }

            foreach (var item in l)
            {
                if (!p.Contains(item))
                {
                    right.Add(item);
                    builderright.AppendLine(item);
                }
            }

            this.textBox5.Text = builderleft.ToString();
            this.textBox6.Text = builderright.ToString();
        }

        private void textBox4_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
