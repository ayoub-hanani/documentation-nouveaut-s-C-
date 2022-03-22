using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_8.Modèles_de_propriétés
{
    internal class csharp_8
    {
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
        location switch
         {
                    { State: "WA" } => salePrice * 0.06M,
                    { State: "MN" } => salePrice * 0.075M,
                    { State: "MI" } => salePrice * 0.05M,
                    // other cases removed for brevity...
                    _ => 0M
                }       ;        
    }
}
