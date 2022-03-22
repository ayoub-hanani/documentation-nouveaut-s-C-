using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_8.Types_construits_non_managés
{
    internal class csharp_8
    {
        public struct Coords<T>
        {
            public T X;
            public T Y;
        }
        Span<Coords<int>> coordinates = stackalloc[]
{
            new Coords<int> { X = 0, Y = 0 },
            new Coords<int> { X = 0, Y = 3 },
            new Coords<int> { X = 4, Y = 0 }
        };
    }
}
