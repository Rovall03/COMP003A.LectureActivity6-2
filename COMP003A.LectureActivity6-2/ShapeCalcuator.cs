using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    class ShapeCalcuator
    {/// <summary>
    /// Calculates the are odf circle
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
        public double CalculateArea(double radius)
        {
            return Math.PI * radius*radius;
        }    
    
        /// <summary>
        /// cal. the are of a rectangle
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public double CalculateArea(double length, double width)
        {
            return length*width;
        }
        /// <summary>
        /// cal the area of triangle
        /// </summary>
        /// <param name="baseLength"></param>
        /// <param name="height"></param>
        /// <param name="isTriangle"></param>
        /// <returns></returns>
        public double CalculateArea(double baseLength,double height, bool isTriangle)
        {
            return 0.5 * baseLength * height;
        }
    
    }


}
