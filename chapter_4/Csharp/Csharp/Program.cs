using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           //code1 public
        Console.WriteLine("---------------------------------code1 public---------------------------------\n");
        code1_public.display();

        //code2 private
        Console.WriteLine("---------------------------------code2 private---------------------------------\n");
        code2_private.display();

        //code3 protected
        Console.WriteLine("---------------------------------code3 protected---------------------------------\n");
        code3_protected.display();

        //code4 constructor
        Console.WriteLine("---------------------------------code4 constructors---------------------------------\n");
        code4_constructors.display();

        //code5 parameterized constructor
        Console.WriteLine("-----------------------------code5 parameterized constructors-----------------------\n");
        code5_parameterizedconstructors.display();

        //code7 parameterized constructor
        Console.WriteLine("-----------------------------code7 parameterized constructors----------------------\n");
        code6_parameterized_constructors.display();

        //code8 parameterized constructor
        Console.WriteLine("-----------------------------code8 parameterized constructors----------------------\n");
        code7_parameterized_constructors.display();

        //code9 destructor
        Console.WriteLine("----------------------------------code9 destructor---------------------------------\n");
        code8_destructor.display();

        Console.ReadLine();
        }
    }
}
