using CpWinfrom.History;
using CpWinfrom.JsonTool;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        string arg1 = "gameIndex=203";
        string arg2key = "issueNo";
        string arg2value = "19001";

        private void button1_Click(object sender, EventArgs e)
        {
         

            List<OpenCode> list2 = new List<OpenCode>();

            while (true)
            {

                try
                {
                    List<OpenCode> list = JsonHelper.ReadJson();

                    if (list.Count != 0)
                    {
                        arg2value = (int.Parse(list.Max(S => S.issueNo)) + 1).ToString();
                    }
                    else
                    {
                        string y = DateTime.Now.ToString("yy");
                        arg2value = y + "001";
                    }
                    string arg = arg1 + "&" + arg2key + "=" + arg2value;
                    string json = Post(arg, url);

                    HisModel model = JsonConvert.DeserializeObject<History.HisModel>(json);

                    OpenCode code = new OpenCode();
                    code.issueNo = arg2value;
                    code.Date = model.openTime;
                    code.Code = model.openResult.Replace("<i>", "").Replace("</i>", ",");
       


                    list2.Add(code);


                 

                }
                catch (Exception)
                {

                    break;
                }
                JsonHelper.Insert(list2);
            }


      




            his();
        }

        public void his()
        {
           List<OpenCode> list= JsonHelper.ReadJson().OrderByDescending(S=>S.issueNo).ToList();
            this.dataGridView1.DataSource = list;
           

        }


    #region 发送post请求
    public static string Post(string str, string url)
        {

            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            byte[] data = Encoding.UTF8.GetBytes(str);//把字符串转换为字节

            req.ContentLength = data.Length; //请求长度

            using (Stream reqStream = req.GetRequestStream()) //获取
            {
                reqStream.Write(data, 0, data.Length);//向当前流中写入字节
                reqStream.Close(); //关闭当前流
            }

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse(); //响应结果
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        #endregion

    }
}
