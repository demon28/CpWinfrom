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
    public partial class 回测 : Form
    {
        public 回测()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1,去掉全大  625
            //2,去掉全小  625
            //3,去掉全奇  626
            //4,去掉全偶  625
            //5,去掉全豹子 10
            //6，去掉三豹子 370
            //7,去掉2对   270
            //8,去掉上10期 10 
            //9,去掉上10期每位加1和每位减1  20
            //10,去掉正向4连号 7
            //11,去掉反向4连号 7
            //12,去掉正向3连号 153
            //13,去掉反向3连号 153
            //14,去掉上期一样的大小格式 625
            //15,去掉上期一样的奇偶格式 625
            //16，去掉千百十和值与上期一样 750
            //17,去掉千百个和值与上期一样 750
            //18，去掉百十个和值与上期一起 750
            //19,去掉千十个 和值与上期一样 750


        }
    }
}
