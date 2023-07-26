using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double findCircumference(double radius) 
        {
            return 2 * Math.PI * radius;
        }
    }
}
