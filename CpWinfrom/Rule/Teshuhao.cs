using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
    public static class Teshuhao
    {

    
        public  static void ABCD(ref List<NumberModel> numberModels) {

         
            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N1!=item.N2 && item.N1!=item.N3 && item.N1!=item.N4  && item.N2!=item.N3 && item.N2!=item.N4 && item.N3 !=item.N4)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                  
                }
            }

        }



        public static void AABC(ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if ((item.N1==item.N2 && item.N3!=item.N4 && item.N1!=item.N4 && item.N1!=item.N3) || (item.N1==item.N3 && item.N2!=item.N4 && item.N1 != item.N2 && item.N1 != item.N4)  || (item.N1==item.N4 && item.N2 !=item.N3 && item.N1 != item.N2 && item.N1 != item.N3)  || (item.N2==item.N3 && item.N1!=item.N4 && item.N2 != item.N4 && item.N2 != item.N1) || (item.N2==item.N4 && item.N1!=item.N3 && item.N2 != item.N1 && item.N2 != item.N3)  || (item.N3==item.N4 && item.N1!=item.N2 && item.N3 != item.N2 && item.N3 != item.N1))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }

        public static void AABB(ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if ((item.N1 == item.N2 && item.N3 == item.N4  && item.N1!=item.N3) || (item.N1 == item.N4 && item.N2 == item.N3 && item.N1!=item.N2) || (item.N1 == item.N3 && item.N2 == item.N4 && item.N1 != item.N2))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }

        public static void AAAB(ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                //1112
                //1121
                //2111
                //1211
                if ((item.N1 == item.N2 && item.N2 == item.N3) || (item.N1 == item.N2 && item.N1 == item.N4) || (item.N2 == item.N3 && item.N3 == item.N4) || (item.N3 == item.N4 && item.N4 == item.N1))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }

        public static void AAAA(ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                
                if (item.N1 == item.N2 && item.N2 == item.N3 && item.N3==item.N4)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }


        public static void 不连(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (Tool.CheckOdd(item))
                {
                    numberModels.Add(item);
                }

                if (Tool.ChecNotkOdd(item))
                {
                    numberModels.Add(item);
                }

            }

        }

        public static void 两个顺子(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N2 == item.N1+1 &&  item.N4== item.N3+1  )
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }

                if (item.N3 == item.N2 + 1 && item.N1 == item.N4 + 1)
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }


            }

        }

        public static void 兄弟号(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N1 == item.N2+1 || item.N1 == item.N3+ 1 ||  item.N1 == item.N4 + 1)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }

                if (item.N2 == item.N3 + 1 || item.N2 == item.N4 + 1 || item.N2 == item.N1 + 1)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
                if (item.N3 == item.N4 + 1 || item.N3 == item.N1 + 1 || item.N2 == item.N2 + 1)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
                if (item.N4 == item.N3 + 1 || item.N4 == item.N1 + 1 || item.N4 == item.N2 + 1)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }

            }

        }
        public static void 非兄弟号(ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
               

            }


        }


    }
}
