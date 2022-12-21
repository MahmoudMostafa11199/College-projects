using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class class1
    {
        public class1(int n)
        {
            Console.WriteLine("The square of integer value {0} is: {1}", n, Math.Pow(n, 2));
        }

        public class1(double n)
        {
            Console.WriteLine("The square of integer value {0} is: {1}", n, Math.Pow(n,2));
        }

        ~class1()
        {
            Console.WriteLine("GoodBye...! \n now !! object was terminated.");
        }
    }
    class code8_destructor
    {
        public static void display()
        {
            details();
            GC.Collect();
        }

        public static void details()
        {
            class1 obj1 = new class1(10);
            class1 obj2 = new class1(2.5);
        }
    }
}
