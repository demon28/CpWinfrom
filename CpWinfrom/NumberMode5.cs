using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom
{
    public class NumberModel5
    {


        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public int N4 { get; set; }
        public int N5 { get; set; }

        public string GetString()
        {
            return N1.ToString() + "" + N2.ToString() + "" + N3.ToString() + "" + N4.ToString() + "" + N5.ToString();
        }
        public int GetInt()
        {
            return int.Parse(N1.ToString() + "" + N2.ToString() + "" + N3.ToString() + "" + N4.ToString() + "" + N5.ToString());
        }
        public int GetMax()
        {
            List<int> list = new List<int>();
            list.Add(N1);
            list.Add(N2);
            list.Add(N3);
            list.Add(N4);
            list.Add(N5);
            return list.Max();
        }

        public int GetMin()
        {
            List<int> list = new List<int>();
            list.Add(N1);
            list.Add(N2);
            list.Add(N3);
            list.Add(N4);
            list.Add(N5);
            return list.Min();
        }

        public static bool Same(NumberModel5 n1, NumberModel5 n2)
        {

            if (n1.N1 == n2.N1 && n1.N2 == n2.N2 && n1.N3 == n2.N3 && n1.N4 == n2.N4 && n1.N5 == n2.N5)
            {
                return true;
            }
            return false;
        }

        public static NumberModel5 ToParse(string val)
        {

            val = val.Trim(' ').Trim('\r').Trim('\n');
            char[] chart = val.ToCharArray();


            NumberModel5 number = new NumberModel5();
            number.N1 = int.Parse(chart[0].ToString());
            number.N2 = int.Parse(chart[1].ToString());
            number.N3 = int.Parse(chart[2].ToString());
            number.N4 = int.Parse(chart[3].ToString());
            number.N5 = int.Parse(chart[4].ToString());
            return number;
        }


        public static List<NumberModel5> GetAllNumer()
        {


            List<NumberModel5> allnumber = new List<NumberModel5>();



            string h1 = string.Empty;
            string h2 = string.Empty;
            string h3 = string.Empty;
            string h4 = string.Empty;
            string h5 = string.Empty;


            for (int i = 0; i < 10; i++)
            {



                for (int j = 0; j < 10; j++)
                {



                    for (int k = 0; k < 10; k++)
                    {



                        for (int l = 0; l < 10; l++)
                        {
                            for (int z = 0; z < 10; z++)
                            {
                                NumberModel5 number = new NumberModel5();
                                number.N1 = i;
                                number.N2 = j;
                                number.N3 = k;
                                number.N4 = l;
                                number.N5= z;
                                allnumber.Add(number);

                            }
                        }
                    }
                }

            }
            return allnumber;








        }
    }
}
