using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_8.Fonctions_locales_statiques
{
    internal class csharp_8_3
    {
        int M()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0;
        }
        /*           ||
         int M()
         {
             int y = 5;
             int x = 7;
             return Add(x, y);

             static int Add(int left, int right) => left + right;
         }
         */
    }
}
