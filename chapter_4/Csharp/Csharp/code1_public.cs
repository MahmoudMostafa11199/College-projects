using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Box
    {
        public double length;
        public double breadth;
        public double height;

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        public double getVolume()
        {
            return length * breadth * height;
        }
    }

    class code1_public
    {
        
        public static void display()
        {
            Box box1 = new Box();
            Box box2 = new Box();
            box1.setLength(10);
            box1.setHeight(12);
            box1.setBreadth(5);
            box2.setLength(15);
            box2.setHeight(17);
            box2.setBreadth(9);
            Console.WriteLine("Volume of Box1 is " + box1.getVolume());
            Console.WriteLine("Volume of Box2 is " + box2.getVolume() + "\n");
        }
    }
}
