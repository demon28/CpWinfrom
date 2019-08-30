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
        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="key">JSON文件中的key值</param>
        /// <returns>JSON文件中的value值</returns>
        public static string Readjson()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\OpenCode.json";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }

            using (System.IO.StreamReader file = System.IO.File.OpenText(path))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                   
                    return o.ToString();
                }
            }
        }

        
        public static List<OpenCode> ReadJson() {

            string jsonText = Readjson();
            List<OpenCode>  list=JsonConvert.DeserializeObject<List<OpenCode>>(jsonText);

            return list;
        }

        public static bool Insert(List<OpenCode> list) {

            string jsonText = Readjson();


            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            foreach (var item in list)
            {
                writer.WriteStartObject();

                writer.WritePropertyName("Date");
                writer.WriteValue(item.Date);
                writer.WritePropertyName("Code");
                writer.WriteValue(item.Code);

                writer.WriteEndObject();
                writer.Flush();
            }
            string Text = sw.GetStringBuilder().ToString();

            return true;
        }

    }
}
