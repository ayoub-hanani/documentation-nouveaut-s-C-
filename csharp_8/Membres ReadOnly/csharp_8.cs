using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_8.Membres_ReadOnly
{
    internal class csharp_8
    {
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            // public double Distance => Math.Sqrt(X * X + Y * Y);
            public readonly double Distance => Math.Sqrt(X * X + Y * Y);

            // public override string ToString() => $"({X}, {Y}) is {Distance} from the origin";
            public readonly override string ToString() => $"({X}, {Y}) is {Distance} from the origin";

            public /*readonly*/ void Translate(int xOffset, int yOffset)
            {
                X += xOffset;
                Y += yOffset;
            }
        }
    }
}
