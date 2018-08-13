using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cirlce
    {
        private double radius;
        public Cirlce(double r = 5) { radius = r; }
        public void setRadius(int r) { radius = r; }
        public double getRadius() { return radius; }
        public double getDiameter() { return 2 * radius; }
        public double getArea() { return 3.14 * radius * radius; }

    }
    class Executer
    {
        static void Main()
        {
            Cirlce circle1 = new Cirlce();
            Cirlce circle2 = new Cirlce(17.19);
            Console.WriteLine(circle1.getRadius());
            Console.WriteLine(circle2.getRadius());
        }
    }
}
