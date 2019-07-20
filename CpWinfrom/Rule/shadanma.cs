using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpWinfrom.Rule
{
   public static class shadanma
    {
        public static void ShaYiEnter(List<int> danma, ref List<NumberModel> numberModels)
        {
            foreach (var item in AllNumer.GetAllNumer())
            {
                if (danma.Contains(item.N1) || danma.Contains(item.N2) || danma.Contains(item.N3) || danma.Contains(item.N4))
                {
                    if (numberModels.Count(S => S.N1 == item.N1 && S.N2 == item.N2 && S.N3 == item.N3 && S.N4 == item.N4) == 0)
                    {
                        numberModels.Add(item);
                    }
                }

               
            }
        }


        public static void ShaWuYiMa(List<int> danma, ref List<NumberModel> numberModels)
        {
           
            foreach (var item in AllNumer.GetAllNumer())
            {

                foreach (var n in danma)
                {
                    if (item.N1 !=n && item.N2 != n  && item.N3 != n && item.N4 != n)
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
