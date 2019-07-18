using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
   public static class lajihao
    {
        public static void Enter(string[] list, ref List<NumberModel> numberModels)
        {


            foreach (var n in list)
            {
                NumberModel item = NumberModel.ToParse(n);

                if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                {
                    numberModels.Add(item);
                }

            }

             
        }
    }
}
