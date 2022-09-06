using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class.OOP_Class.CircleClass
{
    public class Circle_Class
    {
        public double pie;
        public double radius;
        public double angleOfCircle;

        public double CalculateCircumference()
        {
            double result = 2 * pie * radius;
            return result;
        }
        public double CalculateArea()
        {
            double result = pie * radius*radius;
            return result;
        }
        public double CalculateSector()
        {
            double result = angleOfCircle*pie*radius*radius/360;
            return result;
        }
    }
}
