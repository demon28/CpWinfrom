using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom
{
    public class AllNumer
    {



        /// <summary>
        /// 生成所有号码
        /// </summary>
        /// <returns></returns>
        public static List<NumberModel>  GetAllNumer()
        {


            List<NumberModel> allnumber = new List<NumberModel>();



            string h1 = string.Empty;
            string h2 = string.Empty;
            string h3 = string.Empty;
            string h4 = string.Empty;



            for (int i = 0; i < 10; i++)
            {



                for (int j = 0; j < 10; j++)
                {



                    for (int k = 0; k < 10; k++)
                    {



                        for (int l = 0; l < 10; l++)
                        {
                            NumberModel number = new NumberModel();
                            number.N1 = i;
                            number.N2 = j;
                            number.N3 = k;
                            number.N4 = l;
                            allnumber.Add(number);


                        }
                    }
                }

            }
            return allnumber;








        }
     

    }

}
