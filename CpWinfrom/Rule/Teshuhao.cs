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
                if (Math.Abs(item.N1 - item.N2) != 1 && Math.Abs(item.N1 - item.N3) != 1 && Math.Abs(item.N1 - item.N4) != 1 && Math.Abs(item.N2 - item.N3) != 1 && Math.Abs(item.N2 - item.N4) != 1 && Math.Abs(item.N3 - item.N4) != 1 && Math.Abs(item.N4 - item.N1) != 1 )
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
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

        public static void  全大(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N1 >4 && item.N2 > 4 && item.N3 > 4 && item.N4 > 4)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }

        public static void 全小(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.N1 <5  && item.N2 < 5 && item.N3 < 5 && item.N4 < 5)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }
        public static void 全奇(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (Tool.ChecNotkOdd(item))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }
        public static void 全偶(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (Tool.CheckOdd(item))
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
            List<NumberModel> numbers = new List<NumberModel>();
            List<NumberModel> allnumbers = AllNumer.GetAllNumer();
            兄弟号(ref numbers);

            foreach (var item in numbers)
            {
                var whereRemove = allnumbers.FirstOrDefault(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4);
                allnumbers.Remove(whereRemove);
            }
            foreach (var item in allnumbers)
            {
                if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                {
                    numberModels.Add(item);
                }
            }
        }

        public static void 对数(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.GetString().ToCharArray().Contains('0') && item.GetString().ToCharArray().Contains('5'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
                if (item.GetString().ToCharArray().Contains('1') && item.GetString().ToCharArray().Contains('6'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
                if (item.GetString().ToCharArray().Contains('2') && item.GetString().ToCharArray().Contains('7'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
                if (item.GetString().ToCharArray().Contains('3') && item.GetString().ToCharArray().Contains('8'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
                if (item.GetString().ToCharArray().Contains('4') && item.GetString().ToCharArray().Contains('9'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }



        public static void M05对数(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
                if (item.GetString().ToCharArray().Contains('0') && item.GetString().ToCharArray().Contains('5'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
              
            }

        }
        public static void M16对数(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
               
                if (item.GetString().ToCharArray().Contains('1') && item.GetString().ToCharArray().Contains('6'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
               

                
            }

        }
        public static void M27对数(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
               
                if (item.GetString().ToCharArray().Contains('2') && item.GetString().ToCharArray().Contains('7'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
               
            }

        }
        public static void M38对数(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
               
                if (item.GetString().ToCharArray().Contains('3') && item.GetString().ToCharArray().Contains('8'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
               
            }

        }
        public static void M49对数(ref List<NumberModel> numberModels)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {
               
                if (item.GetString().ToCharArray().Contains('4') && item.GetString().ToCharArray().Contains('9'))
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }


        public static void 杀两重号(ref List<NumberModel> numberModels, int L1) {

            foreach (var item in AllNumer.GetAllNumer())
            {
                List<int> list = new List<int>();
                list.Add(item.N1);
                list.Add(item.N2);
                list.Add(item.N3);
                list.Add(item.N4);


                List<int> array = list.FindAll(delegate (int u) { return u == L1; });

                if (array.Count>=2)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }
        }


        public static void 杀两位固定数(ref List<NumberModel> numberModels, int L1,int L2)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {

                if (item.GetString().IndexOf(L1.ToString())>=0 && item.GetString().IndexOf(L2.ToString()) >= 0)
                {

                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }

                }
            }

        }

        public static void 杀三位固定数(ref List<NumberModel> numberModels, int L1, int L2,int L3)
        {

            foreach (var item in AllNumer.GetAllNumer())
            {

                if (item.GetString().IndexOf(L1.ToString()) >= 0 && item.GetString().IndexOf(L2.ToString()) >= 0 && item.GetString().IndexOf(L3.ToString()) >= 0)
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
