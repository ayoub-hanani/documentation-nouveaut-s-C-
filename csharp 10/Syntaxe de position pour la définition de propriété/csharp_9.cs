using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_10.Syntaxe_de_position_pour_la_définition_de_propriété
{
    internal class csharp_9
    {
        public record Person(string FirstName, string LastName);

        public static void Main()
        {
            Person person = new("Nancy", "Davolio");
            Console.WriteLine(person);
            // output: Person { FirstName = Nancy, LastName = Davolio }
        }
    }
}
