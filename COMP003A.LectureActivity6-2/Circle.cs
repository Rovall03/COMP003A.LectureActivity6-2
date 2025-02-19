using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// represents a circle with a specific area calculation
    /// </summary>
     class Circle : Shape
    {
        //Auto-implemented property for the radius of the circle
        public double Radius { get; set; }


        /// <summary>
        /// constructor for the circle class
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius) 
        {
        
            Radius = radius;
        }
        /// <summary>
        /// displays the are of a circle
        /// </summary>
        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Ares: {Math.PI * Radius * Radius}");
        }
    }
}
