using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
    public static class hezhishahao
    {
        public static void 四位和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N1 + item.N2 + item.N3 + item.N4;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }

        public static void  前三和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N1 + item.N2 + item.N3 ;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }
        public static void 后三和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N2 + item.N3 + item.N4;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }


        public static void 前二和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N1 + item.N2 ;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }



        public static void 中二和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N2 + item.N3;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }
        public static void 后二和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N3 + item.N4;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }
        public static void 千百个和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N1 + item.N2+item.N4;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }
        public static void 千十个和值(int[] list, ref List<NumberModel> numberModels)
        {


            foreach (var item in AllNumer.GetAllNumer())
            {
                int sum = item.N1 + item.N3+ item.N4;

                if (list.Contains(sum))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

            }

        }

    }
}
