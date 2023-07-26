using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues findValuesObj = new FindValues();
            double area = findValuesObj.findArea(radius);
            double circumference = findValuesObj.findCircumference(radius);

            Console.WriteLine();

            Console.WriteLine("The area of the circle is {0}.", area);
            Console.WriteLine("The circumference of the circle is {0}.", circumference);

            Console.ReadLine();
        }
    }
}
