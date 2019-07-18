using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom
{
    public static class Tool
    {
        /// <summary>
        /// 是否偶数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsOdd(int n)
        {
            return Convert.ToBoolean(n % 2);
        }
        /// <summary>
        /// 是否奇
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool NotOdd(int n)
        {
            return !Convert.ToBoolean(n % 2);
        }
        /// <summary>
        /// 是否全是偶数
        /// </summary>
        /// <param name="lastnumber"></param>
        /// <returns></returns>
        public static bool CheckOdd(NumberModel lastnumber)
        {

            if (IsOdd(lastnumber.N1) && IsOdd(lastnumber.N2) && IsOdd(lastnumber.N3) && IsOdd(lastnumber.N4))
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// 是否全是奇数
        /// </summary>
        /// <param name="lastnumber"></param>
        /// <returns></returns>
        public static bool ChecNotkOdd(NumberModel lastnumber)
        {

            if (!IsOdd(lastnumber.N1) && !IsOdd(lastnumber.N2) && !IsOdd(lastnumber.N3) && !IsOdd(lastnumber.N4))
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// 是否全是小数
        /// </summary>
        /// <param name="lastnumber"></param>
        /// <returns></returns>
        public static bool CheckBig(NumberModel lastnumber)
        {
            if (lastnumber.N1 < 5 && lastnumber.N2 < 5 && lastnumber.N3 < 5 && lastnumber.N4 < 5)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 是否全是大数
        /// </summary>
        /// <param name="lastnumber"></param>
        /// <returns></returns>
        public static bool CheckSmall(NumberModel lastnumber)
        {
            if (lastnumber.N1 >= 5 && lastnumber.N2 >= 5 && lastnumber.N3 >= 5 && lastnumber.N4 >= 5)
            {
                return true;
            }
            return false;
        }

        public static List<NumberModel> ListSort(List<NumberModel> numberModels)
        {
            List<NumberModel> numbers = numberModels.OrderBy(S => S.GetInt()).ToList();

            return numbers;

        }

        /// <summary>
        ///  是不是质数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsZhiShu(int n)
        {

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += 1;
                }
            }
            return (sum == 2);


        }


        /// <summary>
        ///  是不是合数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool NotZhiShu(int n)
        {

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += 1;
                }
            }
            return !(sum == 2);


        }


        public static bool L0123(NumberModel number, string rule)
        {
            //0路包括的数字：0、3、6、9
            //1路包括的数字：1、4、7
            //2路包括的数字：2、5、8

            int[] L0 = { 0, 3, 6, 9 };
            int[] L1 = { 1, 4, 7 };
            int[] L2 = { 2, 5, 8 };

            char[] rulechar = rule.ToCharArray();

            bool B1=false, B2=false, B3=false, B4=false;

            if (rulechar[0].ToString() == "0")
            {
                B1 = L0.Contains(number.N1);
            }
            if (rulechar[0].ToString() == "1")
            {
                B1 = L1.Contains(number.N1);
            }
            if (rulechar[0].ToString() == "2")
            {
                B1 = L2.Contains(number.N1);
            }

            if (rulechar[1].ToString() == "0")
            {
                B2 = L0.Contains(number.N2);
            }
            if (rulechar[1].ToString() == "1")
            {
                B2 = L1.Contains(number.N2);
            }
            if (rulechar[1].ToString() == "2")
            {
                B2 = L2.Contains(number.N2);
            }

            if (rulechar[2].ToString() == "0")
            {
                B3 = L0.Contains(number.N3);
            }
            if (rulechar[2].ToString() == "1")
            {
                B3 = L1.Contains(number.N3);
            }
            if (rulechar[2].ToString() == "2")
            {
                B3 = L2.Contains(number.N3);

            }
            if (rulechar[3].ToString() == "0")
            {
                B4= L0.Contains(number.N4);
            }
            if (rulechar[3].ToString() == "1")
            {
                B4= L1.Contains(number.N4);
            }
            if (rulechar[3].ToString() == "2")
            {
                B4 = L2.Contains(number.N4);

            }

            return (B1 && B2 && B3 && B4);
        
        }
    }
}
