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



            Console.Write("1:采集");
            Console.Write("2:回测");
            Console.Write("3:规则");
            Console.WriteLine("");
            Console.WriteLine("请选择：");
            string i= Console.ReadLine();

            if (i == "1")
            {
                caiji();
            }
            else if (i=="2")
            {
                huice2();
            }else {
                GudingRule();
            }
            string si = Console.ReadLine();
        }

        static  List<NumberModel> resNumber = new List<NumberModel>();
        static List<NumberModel> delNumber = new List<NumberModel>();


        public static void huice2() {

            Console.WriteLine("开始回测：");

       
            decimal leijiamount = 0;  //盈利
            decimal kuisun = 0; //亏损
            decimal cost = 0;   //花费
            decimal sing = 95000; //奖金

            int zhongjian次数 = 0;
            int buzhong次数 = 0;


            string sql = "select * from tb_hiscode";
            DataTable dt = SQLiteHelper.ExecuteDataset(sql).Tables[0];

            


            foreach (DataRow dr in dt.Rows)
            {
                int nextno = int.Parse(dr["issno"].ToString()) + 1;

                if (nextno==19338)
                {
                    break;
                }
                string sql2 = "select * from tb_hiscode where issno=" + nextno;
                DataRow row = SQLiteHelper.ExecuteDataRow(sql2);

                //本期开奖号码
                NumberModel5 benqimodel5= new NumberModel5() { N1 = Convert.ToInt32(dr["N1"]), N2 = Convert.ToInt32(dr["N2"]), N3 = Convert.ToInt32(dr["N3"]), N4 = Convert.ToInt32(dr["N4"]), N5 = Convert.ToInt32(dr["N5"]) };
                //根据本期号码推测出来的下棋号码
                List<NumberModel5> yucemodel5list = DongtaiRule(benqimodel5);
                //开奖结果
                NumberModel5 kaijiangmodel5 = new NumberModel5() { N1=Convert.ToInt32( row["N1"]), N2 = Convert.ToInt32(row["N2"]), N3 = Convert.ToInt32(row["N3"]), N4 = Convert.ToInt32(row["N4"]), N5= Convert.ToInt32(row["N5"])};

                bool flag = false;
                foreach (var item in yucemodel5list)
                {

                    if (NumberModel5.Same(item, kaijiangmodel5))
                    {
                        flag = true;
                        break;
                    }
                    else {
                        continue;
                    }


                }
                if (flag)
                {
                    decimal yingli = sing - yucemodel5list.Count;
                    leijiamount = leijiamount + yingli;
                    zhongjian次数 = zhongjian次数 + 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(row["issno"] + " 期【" + dr["code"] + "】：中奖了！,成本：" + yucemodel5list.Count + "元，奖金：" + sing + " 元， 盈利：" + yingli + " 元，累计盈利：" + leijiamount);

                }
                else
                {

                    buzhong次数 = buzhong次数 + 1;
                    leijiamount = leijiamount - yucemodel5list.Count;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(row["issno"] + "期【" + dr["code"] + "】：没中奖！, 成本：" + yucemodel5list.Count + "元，奖金：0 元， 亏损：" + yucemodel5list.Count + " 元，累计盈利：" + leijiamount);
                }



            }

           


      

         


        }

        public static List<NumberModel5> DongtaiRule(NumberModel5 last ) {

            List<NumberModel5> allnumber = NumberModel5.GetAllNumer();
            List<NumberModel5> resnumber = new List<NumberModel5>();

            List<int> list = new List<int>();
            list.Add(last.N1);
            list.Add(last.N2);
            list.Add(last.N3);
            list.Add(last.N4);
            list.Add(last.N5);

            foreach (var item in allnumber)
            {
                if (list.Contains(item.N1)|| list.Contains(item.N2) || list.Contains(item.N3) || list.Contains(item.N4) || list.Contains(item.N5))
                {
                    resnumber.Add(item);
                }

            }
         

            return resnumber;
        }


        public static List<NumberModel> GudingRule() {

            resNumber = AllNumer.GetAllNumer();

            Teshuhao.AAAA(ref delNumber);
            Console.WriteLine("去掉四豹子，累计："+ delNumber.Count+" 个");

            
            Teshuhao.AAAB(ref delNumber);
            Console.WriteLine("去掉三豹子，累计：" + delNumber.Count + " 个");


            Teshuhao.AABB(ref delNumber);
            Console.WriteLine("去掉两对子，累计：" + delNumber.Count + " 个");


            shalianhao.无序4连(true, true, ref delNumber);
            Console.WriteLine("无序4连，累计：" + delNumber.Count + " 个");
            shalianhao.正向4连(true, true, ref delNumber);
            Console.WriteLine("正向4连，累计：" + delNumber.Count + " 个");
            shalianhao.反向4连(true, true, ref delNumber);
            Console.WriteLine("反向4连，累计：" + delNumber.Count + " 个");


            //shalianhao.无序3连(true, true, ref delNumber);
            //Console.WriteLine("无序3连，累计：" + delNumber.Count + " 个");

            //shalianhao.正向4连(true, true, ref delNumber);
            //Console.WriteLine("正向3连，累计：" + delNumber.Count + " 个");

            //shalianhao.正向3连(true, true, ref delNumber);
            //Console.WriteLine("正向3连，累计：" + delNumber.Count + " 个");


            //shalianhao.反向4连(true, true, ref delNumber);
            //Console.WriteLine("反向3连，累计：" + delNumber.Count + " 个");

            //shalianhao.反向3连(true, true, ref delNumber);
            //Console.WriteLine("反向3连，累计：" + delNumber.Count + " 个");


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

            Console.WriteLine("是否开始回测：");
            List<NumberModel> r = GudingRule(); 

            decimal chengben = r.Count;
            decimal  leijiamount = 0;  //盈利
            decimal kuisun = 0; //亏损
            decimal cost = 0;   //花费
            decimal sing = 9500; //奖金

            int zhongjian次数 = 0;
            int buzhong次数 = 0;


            string sql = "select * from tb_hiscode";

            DataTable dt  =SQLiteHelper.ExecuteDataset(sql).Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                bool flag = false; //是否中奖

                foreach (var item in r)
                {


                    NumberModel numberModel = new NumberModel();

                    numberModel.N1 =Convert.ToInt32( dr["n1"]);
                    numberModel.N2 = Convert.ToInt32(dr["n2"]);
                    numberModel.N3 = Convert.ToInt32(dr["n3"]);
                    numberModel.N4 = Convert.ToInt32(dr["n4"]);

                    if (NumberModel.Same(item, numberModel))
                    {
                     
                        flag = true;
                        break;
                    }
                    else {
                     

                        continue;
                    }


                    //统计中奖次数
                }

                if (flag)
                {
                    decimal yingli = sing - chengben;
                    leijiamount = leijiamount + yingli;
                    zhongjian次数 = zhongjian次数 + 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(dr["issno"] + " 期【"+dr["code"]+"】：中奖了！,成本："+chengben+"元，奖金："+sing+ " 元， 盈利："+yingli +" 元，累计盈利："+ leijiamount );
              
                }
                else {

                    buzhong次数 = buzhong次数 + 1 ;
                    leijiamount = leijiamount - chengben;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(dr["issno"] + "期【" + dr["code"] + "】：没中奖！, 成本：" + chengben+"元，奖金：0 元， 亏损："+ chengben + " 元，累计盈利："+ leijiamount);
                }
               

            }

            Console.WriteLine("累计中奖次数："+ zhongjian次数+"次，累计不中次数："+buzhong次数+" 次，剩余金额:"+leijiamount);


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



    public class Stock {

        string isno { get; set; }
        List<NumberModel5> models;
    }
}
