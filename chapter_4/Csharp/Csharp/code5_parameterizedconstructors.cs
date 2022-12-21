using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class constr_class
    {
        private int x ;
        public constr_class(int setValue)
        {
            x = setValue;
        }

        public int display()
        {
            return x;
        }
    }
    class code5_parameterizedconstructors
    {

        public static void display()
        {
            constr_class obj1 = new constr_class(22);
            Console.Write("value of x as intialized to: ");
            Console.WriteLine(obj1.display() + "\n");
        }
        
    }
}
