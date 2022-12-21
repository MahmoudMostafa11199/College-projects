using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class student
    {
        public string firstName, lastName;
        public int studentID;

        public student()
        {
            Console.WriteLine("Parameter not set yet");
        }

        public student(int id)
        {
            studentID = id;
            Console.WriteLine("ID= " + studentID);
        }

        public student(string fn, string ln = "Mostafa")
        {
            firstName = fn;
            lastName = ln;
            Console.WriteLine("The first name is " + firstName + " and the last name is " + lastName);
        }
    }
    class code7_parameterized_constructors
    {
        public static void display()
        {
            student std1 = new student();
            student std2 = new student(22);
            student std3 = new student("Mahmoud");
            Console.WriteLine();
        }
    }
}
