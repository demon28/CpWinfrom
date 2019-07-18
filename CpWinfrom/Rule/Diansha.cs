using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
    public static class Diansha
    {

        public static void 大小enter(string[] list, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {

                if (list.Contains("大大大大"))
                {
                    if (item.N1 > 4 && item.N2 > 4 && item.N3 > 4 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大大大小"))
                {
                    if (item.N1 > 4 && item.N2 > 4 && item.N3 > 4 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大大小大"))
                {
                    if (item.N1 > 4 && item.N2 > 4 && item.N3 < 5 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大大小小"))
                {
                    if (item.N1 > 4 && item.N2 > 4 && item.N3 < 5 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大小大大"))
                {
                    if (item.N1 > 4 && item.N2 < 5 && item.N3 > 4 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大小大小"))
                {
                    if (item.N1 > 4 && item.N2 < 5 && item.N3 > 4 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大小小大"))
                {
                    if (item.N1 > 4 && item.N2 < 5 && item.N3 < 5 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("大小小小"))
                {
                    if (item.N1 > 4 && item.N2 < 5 && item.N3 < 5 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小大大大"))
                {
                    if (item.N1 < 5 && item.N2 > 4 && item.N3 > 4 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小大大小"))
                {
                    if (item.N1 < 5 && item.N2 > 4 && item.N3 > 4 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小大小大"))
                {
                    if (item.N1 < 5 && item.N2 > 4 && item.N3 < 5 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小大小小"))
                {
                    if (item.N1 < 5 && item.N2 > 4 && item.N3 < 5 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小小大大"))
                {
                    if (item.N1 < 5 && item.N2 < 5 && item.N3 > 4 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小小大小"))
                {
                    if (item.N1 < 5 && item.N2 < 5 && item.N3 > 4 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小小小大"))
                {
                    if (item.N1 < 5 && item.N2 < 5 && item.N3 < 5 && item.N4 > 4)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("小小小小"))
                {
                    if (item.N1 < 5 && item.N2 < 5 && item.N3 < 5 && item.N4 < 5)
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }



            }



        }

        public static void 奇偶enter(string[] list, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {

                if (list.Contains("奇奇奇奇"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇奇奇偶"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇奇偶奇"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇奇偶偶"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇偶奇奇"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇偶奇偶"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇偶偶奇"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("奇偶偶偶"))
                {
                    if (Tool.NotOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶奇奇奇"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶奇奇偶"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶奇偶奇"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶奇偶偶"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.NotOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶偶奇奇"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶偶奇偶"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.NotOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶偶偶奇"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.NotOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("偶偶偶偶"))
                {
                    if (Tool.IsOdd(item.N1) && Tool.IsOdd(item.N2) && Tool.IsOdd(item.N3) && Tool.IsOdd(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }



            }



        }


        public static void 质合enter(string[] list, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {

                if (list.Contains("质质质质"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质质质合"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质质合质"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质质合合"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质合质质"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质合质合"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质合合质"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("质合合合"))
                {
                    if (Tool.IsZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合质质质"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合质质合"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合质合质"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合质合合"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.IsZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合合质质"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合合质合"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.IsZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合合合质"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.IsZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }
                if (list.Contains("合合合合"))
                {
                    if (Tool.NotZhiShu(item.N1) && Tool.NotZhiShu(item.N2) && Tool.NotZhiShu(item.N3) && Tool.NotZhiShu(item.N4))
                    {
                        if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                        {
                            numberModels.Add(item);
                        }
                    }
                }



            }



        }


        public static void L012enter(string[] list, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {

                foreach (var rule in list)
                {
                    if (Tool.L0123(item,rule))
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
}
