using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class human
    {
        private string name;
        private int age;

        public human(string n , int a)
        {
            name = n;
            age = a;
        }

        public human(int a)
        {
            age = a;
        }

        public human(string n)
        {
            name = n;
        }

        public human()
        {
            Console.WriteLine("Parameter not set yet");
        }

        public void printdata()
        {
            Console.WriteLine("My name " + name);
            Console.WriteLine("My age " + age);
        }
    }
    class code6_parameterized_constructors
    {
        public static void display()
        {
            human h1 = new human("Mahmoud", 23);
            human h2 = new human("Mahmoud");
            human h3 = new human(23);
            h1.printdata();
            Console.WriteLine("-------");
            h2.printdata();
            Console.WriteLine("-------");
            h3.printdata();
            Console.WriteLine("-------");
            human h4 = new human();
            h4.printdata();
            Console.WriteLine();
        }
    }
}
