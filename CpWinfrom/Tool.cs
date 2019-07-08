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
        /// 奇偶判断
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsOdd(int n)
        {
            return Convert.ToBoolean(n % 2);
        }

        /// <summary>
        /// 是否全是偶数
        /// </summary>
        /// <param name="lastnumber"></param>
        /// <returns></returns>
        public static bool CheckOdd(NumberModel lastnumber)
        {

            if (IsOdd(lastnumber.N1) && IsOdd(lastnumber.N2) && IsOdd(lastnumber.N3) && IsOdd(lastnumber.N4) )
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
            if (lastnumber.N1 < 5 && lastnumber.N2 < 5 && lastnumber.N3 < 5 && lastnumber.N4 < 5 )
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
    }
}
