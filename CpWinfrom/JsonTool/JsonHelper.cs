using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CpWinfrom.History;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace CpWinfrom.JsonTool
{
   public static class JsonHelper
    {
      public static  string path = AppDomain.CurrentDomain.BaseDirectory + "\\OpenCode.json";
        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="key">JSON文件中的key值</param>
        /// <returns>JSON文件中的value值</returns>
        public static string Readjson()
        {
          

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }

            using (System.IO.StreamReader file = System.IO.File.OpenText(path))
            {
               return file.ReadToEnd();
            }
        }

        
        public static List<OpenCode> ReadJson() {

            string jsonText = Readjson();
            List<OpenCode>  list=JsonConvert.DeserializeObject<List<OpenCode>>(jsonText);

            return list;
        }

        public static bool Insert(List<OpenCode> list) {


            try
            {

          
            string jsonText = Readjson();


            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartArray();//   [ 

            foreach (var item in list)
            {
                writer.WriteStartObject();


                writer.WritePropertyName("issueNo");
                writer.WriteValue(item.issueNo);
                writer.WritePropertyName("Date");
                writer.WriteValue(item.Date);
                writer.WritePropertyName("Code");
                writer.WriteValue(item.Code);
                writer.WriteEndObject();
                writer.Flush();
            }
            writer.WriteEndArray();//    ]   
            string Text = sw.GetStringBuilder().ToString();

            StreamWriter wtyeu = new StreamWriter(path);
            wtyeu.Write(sw);
            wtyeu.Flush();
            wtyeu.Close();
            return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static bool Insert(OpenCode item)
        {

            string jsonText = Readjson();


            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartArray();//   [ 
            writer.WriteStartObject();
                writer.WritePropertyName("issueNo");
                writer.WriteValue(item.issueNo);
                writer.WritePropertyName("Date");
                writer.WriteValue(item.Date);
                writer.WritePropertyName("Code");
                writer.WriteValue(item.Code);
                writer.WriteEndObject();
            writer.WriteEndArray();//    ]   


            writer.Flush();
          
            string Text = sw.GetStringBuilder().ToString();

            StreamWriter wtyeu = new StreamWriter(path);
            wtyeu.Write(sw);
            wtyeu.Flush();
            wtyeu.Close();
            return true;
        }

    }
}
