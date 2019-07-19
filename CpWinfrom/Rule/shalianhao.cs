using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
     public static class shalianhao
    {
        /*
         0,1,2,3,4,5,6,7,8,9,0,1
         9后面是0    
         0后面是1
             */


        public static void 无序4连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {

        }

        public static void 反向4连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                string ruleN = "9876543210";
                string ruleS = "9876543210987";
                if (ruleN.IndexOf(item.GetString()) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {
                    if (item.N1 == item.N4 - 1 && item.N2 == item.N1 -1 && item.N3 == item.N2 -1)
                    {
                        Add(item, ref numberModels);
                    }
                }


                if (is09)
                {
                    if (ruleS.IndexOf(item.GetString()) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }
            }

        }

        public static void 正向4连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                string ruleN = "0123456789";
                string ruleS = "0123456789012";
                if (ruleN.IndexOf(item.GetString())>=0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {
                    if (item.N1==item.N4+1 && item.N2 == item.N1+ 1 && item.N3 == item.N2 + 1  )
                    {
                        Add(item, ref numberModels);
                    }
                }


                if (is09)
                {
                    if (ruleS.IndexOf(item.GetString()) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }
            }
        }





        public static void 无序3连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {

        }

        public static void 反向3连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N1 == item.N2 - 1 && item.N2 == item.N3 -1)
                {
                    Add(item, ref numberModels);
                }
                if (item.N2 == item.N3 - 1 && item.N3 == item.N4 -1)
                {
                    Add(item, ref numberModels);
                }


                if (shouwei)
                {
                    if (item.N4 == item.N1 - 1 && item.N1 == item.N2 - 1)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (item.N4 == 0 && item.N3 == 9 && item.N2 == 1)
                    {
                        Add(item, ref numberModels);
                    }
                    if (item.N3== 0 && item.N2 == 9 && item.N1 == 1)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (item.N2 == 8 && item.N1 == 9 && item.N4 == 0)
                        {
                            Add(item, ref numberModels);
                        }
                        if (item.N1 == 0 && item.N4 == 9 && item.N3 == 1)
                        {
                            Add(item, ref numberModels);
                        }
                    }

                }

            }

        }

        public static void 正向3连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N1 == item.N2 + 1 && item.N2==item.N3+1)
                {
                    Add(item, ref numberModels);
                }
                if (item.N2 == item.N3 + 1 && item.N3 == item.N4 + 1)
                {
                    Add(item, ref numberModels);
                }
                

                if (shouwei)
                {
                    if (item.N4 == item.N1 + 1 && item.N1 == item.N2+ 1)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (item.N1 == 0 && item.N2 == 9 && item.N3==1)
                    {
                        Add(item, ref numberModels);
                    }
                    if (item.N2 == 0 && item.N3 == 9 && item.N4==1)
                    {
                        Add(item, ref numberModels);
                    }
                    
                    if (shouwei)
                    {
                        if (item.N3 == 8 && item.N4 == 9 && item.N1 == 0)
                        {
                            Add(item, ref numberModels);
                        }
                        if (item.N4 == 0 && item.N1 == 9 && item.N2==1)
                        {
                            Add(item, ref numberModels);
                        }
                    }

                }

            }

        }



      
        public static void 正向2连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N2 == item.N1 + 1)
                {
                    Add(item, ref numberModels);
                }
                if (item.N3 == item.N2 + 1)
                {
                    Add(item, ref numberModels);
                }
                if (item.N4 == item.N3 + 1)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {
                    if (item.N1 == item.N4 + 1)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (item.N1 == 9 && item.N2 == 0)
                    {
                        Add(item, ref numberModels);
                    }
                    if (item.N2 == 9 && item.N3 == 0)
                    {
                        Add(item, ref numberModels);
                    }
                    if (item.N3 == 9 && item.N4 == 0)
                    {
                        Add(item, ref numberModels);
                    }
                    if (shouwei)
                    {
                        if (item.N4 == 9 && item.N1 == 9)
                        {
                            Add(item, ref numberModels);
                        }
                    }

                }

            }

        }
       
        public static void 反向2连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N4== item.N3+1)
                {
                    Add(item, ref numberModels);
                }
                if (item.N3 == item.N2 + 1)
                {
                    Add(item, ref numberModels);
                }
                if (item.N2 == item.N1+ 1)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {
                    if (item.N1 == item.N4 + 1)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (item.N1 == 0 && item.N2 == 9)
                    {
                        Add(item, ref numberModels);
                    }
                    if (item.N2 == 0 && item.N3 == 9)
                    {
                        Add(item, ref numberModels);
                    }
                    if (item.N3 == 0 && item.N4 == 9)
                    {
                        Add(item, ref numberModels);
                    }
                    if (shouwei)
                    {
                        if (item.N4 == 0 && item.N1 == 9)
                        {
                            Add(item, ref numberModels);
                        }
                    }

                }

            }

        }

        public static void 无序2连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {

                List<int> array = new List<int>();
                array.Add(item.N1);
                array.Add(item.N2);
                array.Add(item.N3);
                array.Add(item.N4);


                foreach (var arr in array)
                {
                    foreach (var narr in array)
                    {
                        if (arr==narr+1 || arr==narr-1)
                        {
                            Add(item, ref numberModels);
                        }

                    }
                }


            }
        }
     





        private static NumberModel Sort(NumberModel item) {

            List<int> array = new List<int>();

            array.Add(item.N1);
            array.Add(item.N2);
            array.Add(item.N3);
            array.Add(item.N4);
            array.Sort();

            NumberModel number = new NumberModel() ;
            number.N1 = array[0];
            number.N2 = array[1];
            number.N3 = array[2];
            number.N4 = array[3];

            return number;
        }
        private static void Add(NumberModel item, ref List<NumberModel> numberModels)
        {
            if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
            {
                numberModels.Add(item);
            }
        }


    }

   

}
