/* Name: Hello_World
 * Author: Derrick Minor
 * Author Url: http://www.codersyntax.com
 * Description: A 'Hello World' program in C#. This program displays the string 'Hello World' as well as an exit prompt.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
