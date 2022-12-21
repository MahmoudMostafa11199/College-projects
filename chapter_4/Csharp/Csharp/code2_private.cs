using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class person
    {
        public int intAge;
        private string strName;

        public void setName(string name)
        {
            strName = name;
        }

        public string getName()
        {
            return strName;
        }

        public void displayData()
        {
            Console.WriteLine("age= " + intAge);
            Console.WriteLine("name= " + strName + "\n");
        }
    }
    class code2_private
    {
        public static void display()
        {
            person pr1 = new person();
            pr1.intAge = 23;
            pr1.setName("Mahmoud");
            pr1.displayData();
        }
    }
}
