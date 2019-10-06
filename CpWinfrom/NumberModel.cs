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
            return  int.Parse( N1.ToString() + "" + N2.ToString() + "" + N3.ToString() + "" + N4.ToString());
        }
        public int GetMax() {
            List<int> list = new List<int>();
            list.Add(N1);
            list.Add(N2);
            list.Add(N3);
            list.Add(N4);

            return list.Max();
        }

        public int GetMin()
        {
            List<int> list = new List<int>();
            list.Add(N1);
            list.Add(N2);
            list.Add(N3);
            list.Add(N4);

            return list.Min();
        }

        public static bool Same(NumberModel n1, NumberModel n2) {

            if (n1.N1==n2.N1  && n1.N2 == n2.N2 && n1.N3 == n2.N3 && n1.N4 == n2.N4)
            {
                return true;
            }
            return false;
        }

        public static NumberModel ToParse(string val)
        {

            val = val.Trim(' ').Trim('\r').Trim('\n');
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
