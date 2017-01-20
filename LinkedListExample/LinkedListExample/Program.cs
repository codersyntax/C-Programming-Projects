using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test with a non-empty list of names.
            GenericList<string> gll = new GenericList<string>();
            gll.AddNode("Nathan");
            gll.AddNode("Derrick");
            gll.AddNode("Tilly");

            string names = gll.GetFirstAdded();
            // The following line displays Nathan.
            Console.WriteLine(names);
            Console.ReadKey();

        }
    }
}
