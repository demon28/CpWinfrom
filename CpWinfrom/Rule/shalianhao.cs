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

        /// <summary>
        ///   处理完毕
        /// </summary>
        /// <param name="shouwei"></param>
        /// <param name="is09"></param>
        /// <param name="numberModels"></param>
        public static void 无序4连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                NumberModel number = Sort(item);

                string ruleN = "0123456789";
                string ruleS = "0123456789012";
                if (ruleN.IndexOf(number.GetString()) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {
                    if (number.N1 == number.N4 - 1 && number.N2 == item.N1 - 1 && number.N3 == item.N2 - 1)
                    {
                        Add(item, ref numberModels);
                    }
                }


                if (is09)
                {
                    if (ruleS.IndexOf(number.GetString()) >= 0 || ruleS.IndexOf(item.GetString()) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }
            }
        }
        /// <summary>
        /// c处理完毕
        /// </summary>
        /// <param name="shouwei"></param>
        /// <param name="is09"></param>
        /// <param name="numberModels"></param>
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
        /// <summary>
        /// 处理完毕
        /// </summary>
        /// <param name="shouwei"></param>
        /// <param name="is09"></param>
        /// <param name="numberModels"></param>
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


        /// <summary>
        /// 处理完毕
        /// </summary>
        /// <param name="shouwei"></param>
        /// <param name="is09"></param>
        /// <param name="numberModels"></param>
        public static void 无序3连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                NumberModel number = Sort(item);

                string ruleN = "0123456789";
                string ruleS = "0123456789012";

                string san123 = number.N1.ToString() + number.N2.ToString() + number.N3.ToString();
                string san234 = number.N2.ToString() + number.N3.ToString() + number.N4.ToString();

                string san412 = number.N4.ToString() + number.N1.ToString() + number.N2.ToString();

                if (ruleN.IndexOf(san123) >= 0 || ruleN.IndexOf(san234) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {

                    if (ruleN.IndexOf(san412) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (ruleS.IndexOf(san123) >= 0 || ruleS.IndexOf(san234) >= 0)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (ruleS.IndexOf(san412) >= 0)
                        {
                            Add(item, ref numberModels);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 处理完毕
        /// </summary>
        /// <param name="shouwei"></param>
        /// <param name="is09"></param>
        /// <param name="numberModels"></param>
        public static void 反向3连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                string ruleN = "9876543210";
                string ruleS = "9876543210987";

                string san123 = item.N1.ToString() + item.N2.ToString() + item.N3.ToString();
                string san234 = item.N2.ToString() + item.N3.ToString() + item.N4.ToString();

                string san412 = item.N4.ToString() + item.N1.ToString() + item.N2.ToString();

                if (ruleN.IndexOf(san123) >= 0 || ruleN.IndexOf(san234) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {

                    if (ruleN.IndexOf(san412) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (ruleS.IndexOf(san123) >= 0 || ruleS.IndexOf(san234) >= 0)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (ruleS.IndexOf(san412) >= 0)
                        {
                            Add(item, ref numberModels);
                        }
                    }
                }

            }

        }

        /// <summary>
        /// 处理完毕
        /// </summary>
        /// <param name="shouwei"></param>
        /// <param name="is09"></param>
        /// <param name="numberModels"></param>
        public static void 正向3连(bool shouwei, bool is09, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                string ruleN = "0123456789";
                string ruleS = "0123456789012";

                string san123 = item.N1.ToString() + item.N2.ToString()+item.N3.ToString();
                string san234 = item.N2.ToString() + item.N3.ToString() + item.N4.ToString();

                string san412 = item.N4.ToString() + item.N1.ToString() + item.N2.ToString();

                if (ruleN.IndexOf(san123) >= 0 || ruleN.IndexOf(san234) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {
                  
                    if (ruleN.IndexOf(san412) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (ruleS.IndexOf(san123) >= 0 || ruleS.IndexOf(san234) >= 0)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (ruleS.IndexOf(san412) >= 0)
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
                string ruleN = "0123456789";
                string ruleS = "0123456789012";

                string san12 = item.N1.ToString() + item.N2.ToString();
                string san23= item.N2.ToString() + item.N3.ToString();
                string san34 = item.N3.ToString() + item.N4.ToString();

                string san41 = item.N4.ToString() + item.N1.ToString() ;

                if (ruleN.IndexOf(san12) >= 0 || ruleN.IndexOf(san23) >= 0 || ruleN.IndexOf(san34) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {

                    if (ruleN.IndexOf(san41) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (ruleS.IndexOf(san12) >= 0 || ruleS.IndexOf(san23) >= 0 || ruleS.IndexOf(san34) >= 0)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (ruleS.IndexOf(san41) >= 0)
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
                string ruleN = "9876543210";
                string ruleS = "9876543210987";

                string san12 = item.N1.ToString() + item.N2.ToString();
                string san23 = item.N2.ToString() + item.N3.ToString();
                string san34 = item.N3.ToString() + item.N4.ToString();

                string san41 = item.N4.ToString() + item.N1.ToString();

                if (ruleN.IndexOf(san12) >= 0 || ruleN.IndexOf(san23) >= 0 || ruleN.IndexOf(san34) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {

                    if (ruleN.IndexOf(san41) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (ruleS.IndexOf(san12) >= 0 || ruleS.IndexOf(san23) >= 0 || ruleS.IndexOf(san34) >= 0)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (ruleS.IndexOf(san41) >= 0)
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
                NumberModel number = Sort(item);
                string ruleN = "0123456789";
                string ruleS = "0123456789012";

                string san12 = number.N1.ToString() + number.N2.ToString();
                string san23 = number.N2.ToString() + number.N3.ToString();
                string san34 = number.N3.ToString() + number.N4.ToString();

                string san41 = item.N4.ToString() + item.N1.ToString();

                if (ruleN.IndexOf(san12) >= 0 || ruleN.IndexOf(san23) >= 0 || ruleN.IndexOf(san34) >= 0)
                {
                    Add(item, ref numberModels);
                }

                if (shouwei)
                {

                    if (ruleN.IndexOf(san41) >= 0)
                    {
                        Add(item, ref numberModels);
                    }
                }

                if (is09)
                {
                    if (ruleS.IndexOf(san12) >= 0 || ruleS.IndexOf(san23) >= 0 || ruleS.IndexOf(san34) >= 0)
                    {
                        Add(item, ref numberModels);
                    }

                    if (shouwei)
                    {
                        if (ruleS.IndexOf(san41) >= 0)
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
