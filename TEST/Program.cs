using CpWinfrom;
using CpWinfrom.History;
using CpWinfrom.Rule;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,去掉全大  625
            //2,去掉全小  625
            //3,去掉全奇  626
            //4,去掉全偶  625
          
            
            //8,去掉上10期 10 
            //9,去掉上10期每位加1和每位减1  20
           
            //14,去掉上期一样的大小格式 625
            //15,去掉上期一样的奇偶格式 625
            //16，去掉千百十和值与上期一样 750
            //17,去掉千百个和值与上期一样 750
            //18，去掉百十个和值与上期一起 750
            //19,去掉千十个 和值与上期一样 750



            Console.WriteLine("1:采集");
            Console.WriteLine("2:回测");
            Console.WriteLine("3:规则");
            string i= Console.ReadLine();

            if (i == "1")
            {
                caiji();
            }
            else if (i=="2")
            {

            }else {
                Rule();
            }
            string si = Console.ReadLine();
        }

        static  List<NumberModel> resNumber = new List<NumberModel>();
        static List<NumberModel> delNumber = new List<NumberModel>();



        public static List<NumberModel> Rule() {

            resNumber = AllNumer.GetAllNumer();

            Teshuhao.AAAA(ref delNumber);
            Console.WriteLine("去掉四豹子，累计："+ delNumber.Count+" 个");

            
            Teshuhao.AAAB(ref delNumber);
            Console.WriteLine("去掉三豹子，累计：" + delNumber.Count + " 个");


            Teshuhao.AABB(ref delNumber);
            Console.WriteLine("去掉两对子，累计：" + delNumber.Count + " 个");


            shalianhao.无序4连(true, true, ref delNumber);
            Console.WriteLine("无序4连，累计：" + delNumber.Count + " 个");


            shalianhao.无序3连(true, true, ref delNumber);
            Console.WriteLine("无序3连，累计：" + delNumber.Count + " 个");

            shalianhao.正向4连(true, true, ref delNumber);
            Console.WriteLine("正向3连，累计：" + delNumber.Count + " 个");

            shalianhao.正向3连(true, true, ref delNumber);
            Console.WriteLine("正向3连，累计：" + delNumber.Count + " 个");


            shalianhao.反向4连(true, true, ref delNumber);
            Console.WriteLine("反向3连，累计：" + delNumber.Count + " 个");

            shalianhao.反向3连(true, true, ref delNumber);
            Console.WriteLine("反向3连，累计：" + delNumber.Count + " 个");


            int j= resNumber.Count - delNumber.Count;
            Console.WriteLine("");
            Console.WriteLine("======总共还剩：" +j + " 个=======");


            foreach (var item in delNumber)
            {
                var whereRemove = resNumber.FirstOrDefault(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4);
                resNumber.Remove(whereRemove);

            }

            return resNumber;
        }


        public static void  caiji() {

            Console.WriteLine("开始采集2019年数据");

            string url = "https://kaijiang.aicai.com/open/historyIssue.do";
            string arg1 = "gameIndex=203";
            string arg2key = "issueNo";
            string arg2value = "19001";

            int i = 0;


            while (true)
            {
          
                Console.WriteLine("采集中：" + i);
                try
                {
                    string sql1 = "select max(issno) issno from tb_hiscode";

                    DataRow r1 = SQLiteHelper.ExecuteDataRow(sql1);
                    int num = r1[0].Equals(DBNull.Value) ? 0 : Convert.ToInt32(r1[0]);
                    if (num!=0)
                    {
                        arg2value = (Convert.ToInt32(r1["issno"]) + 1).ToString();
                    }
                    else
                    {
                        string y = DateTime.Now.ToString("yy");
                        arg2value = y + "001";
                    }
                    string arg = arg1 + "&" + arg2key + "=" + arg2value;
                    string json = Post(arg, url);

                    HisModel model = JsonConvert.DeserializeObject<CpWinfrom.History.HisModel>(json);

                    string rescode = model.openResult.Replace("<i>", "").Replace("</i>", ",");
                    string n1 = rescode.Split(',')[0];
                    string n2 = rescode.Split(',')[1];
                    string n3 = rescode.Split(',')[2];
                    string n4 = rescode.Split(',')[3];
                    string n5 = rescode.Split(',')[4];

                    string sql2 = @"INSERT INTO [tb_hiscode]
           ([id]
           ,[Date]
           ,[Code]
           ,[IssNo]
           ,[N1]
           ,[N2]
           ,[N3]
           ,[N4]
           ,[N5])
     VALUES
           (null,'"+model.openTime+"','"+ rescode + "','"+ arg2value + "' ,'"+n1+"' ,'"+n2+"' ,'"+n3+"','"+n4+"','"+n5+"')";
           
                    SQLiteHelper.ExecuteNonQuery(sql2);
                    i = i + 1;
                }
                catch (Exception e)
                {

                    break;
                }

            }

            Console.WriteLine("采集结束,累计："+i);

            Main(null);
        }


        public static void huice() {

            List<NumberModel> r = Rule();
            Console.WriteLine("剩余："+r.Count+"   是否输出结果：y/n");
             string s=Console.ReadLine();
            if (s=="y")
            {
                foreach (var item in r)
                {
                    Console.WriteLine(item.GetString());
                }
            }
            Console.WriteLine("是否开始回测：y/n");

            string u = Console.ReadLine();
            if (u != "y")
            {
                return;
            }

            string sql = "select * from tb_hiscode";

            DataTable dt  =SQLiteHelper.ExecuteDataset(sql).Tables[0];


            foreach (var item in r)
            {
              
            }




            Main(null);
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
