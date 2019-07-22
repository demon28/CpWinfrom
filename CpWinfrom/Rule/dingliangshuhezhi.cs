using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
    public static class  dingliangshuhezhi
    {

        public static void 两数和值(List<int> hezhi, ref List<NumberModel> numberModels) {

            if (hezhi.Count <= 0)
            {
                return;
            }


            foreach (var item in AllNumer.GetAllNumer())
            {

                if (!hezhi.Contains(item.N1+item.N2) && !hezhi.Contains(item.N1 + item.N3) && !hezhi.Contains(item.N1 + item.N4) && !hezhi.Contains(item.N2 + item.N3) && !hezhi.Contains(item.N2 + item.N4) && !hezhi.Contains(item.N3 + item.N4))
                {
                    Add(item,ref numberModels);
                }

            }

        }

        private static void Add(NumberModel item, ref List<NumberModel> numberModels) {

            if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
            {
                numberModels.Add(item);
            }
        }
    }
}
