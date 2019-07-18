using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom
{
    public class NumberModel
    {


        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public int N4 { get; set; }


        public string GetString()
        {
            return N1.ToString() + "" + N2.ToString() + "" + N3.ToString() + "" + N4.ToString();
        }
        public int GetInt()
        {
            return N1+ N2 + N3+ N4;
        }

        public static NumberModel ToParse(string val)
        {
            char[] chart = val.ToCharArray();


            NumberModel number = new NumberModel();
            number.N1 = int.Parse(chart[0].ToString());
            number.N2 = int.Parse(chart[1].ToString());
            number.N3 = int.Parse(chart[2].ToString());
            number.N4 = int.Parse(chart[3].ToString());

            return number;
        }
    }
}
