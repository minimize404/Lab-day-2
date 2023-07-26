using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Substraction");
            Console.WriteLine("Enter 3 For Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.WriteLine();

            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            CalculateValues calculateValues = new CalculateValues();

            double ans;

            if (choice == 1)
            {
                ans = calculateValues.calAddition(num1, num2);
                Console.WriteLine("Your Answer is : {0}", ans);
            }
            else if (choice == 2)
            {
                ans = calculateValues.calSubstraction(num1, num2);
                Console.WriteLine("Your Answer is : {0}", ans);
            }
            else if (choice == 3)
            {
                ans = calculateValues.calMultiplication(num1, num2);
                Console.WriteLine("Your Answer is : {0}", ans);
            }
            else if (choice == 4)
            {
                ans = calculateValues.calDivision(num1, num2);
                Console.WriteLine("Your Answer is : {0}", ans);
            }
            else
            {
                Console.WriteLine("Error");
            }


            

            Console.ReadLine();
        }
    }
}
