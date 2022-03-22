using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_8.Flux_asynchrones
{
    internal class csharp_8
    {
        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }

        }
    }
}
