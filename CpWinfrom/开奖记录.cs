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
    public partial class 开奖记录 : Form
    {
        public 开奖记录()
        {
            InitializeComponent();
        }

        string url = "https://kaijiang.aicai.com/open/historyIssue.do";
        string arg = "gameIndex=203&issueNo=";  //19213

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public DataTable his() {

            DataTable dt = new DataTable();




            return dt;


        }

    }
}
