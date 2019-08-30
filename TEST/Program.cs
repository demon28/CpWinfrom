using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string jsonText = @"{""input"" : ""value"", ""output"" : ""result""}";
            //    JsonReader reader = new JsonTextReader(new StringReader(jsonText));

            //    while (reader.Read())
            //    {
            //        Console.WriteLine(reader.TokenType + "\t\t" + reader.ValueType + "\t\t" + reader.Value);

            //    }




            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);

            writer.WriteStartObject();
            writer.WritePropertyName("input");
            writer.WriteValue("value");
            writer.WritePropertyName("output");
            writer.WriteValue("result");
            writer.WriteEndObject();


            writer.Flush();

            string jsonText = sw.GetStringBuilder().ToString();
            Console.WriteLine(jsonText);

            Console.Read();





        }
    }
}
