using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{

    /// <summary>
    /// represents a rectangle with a specific area calculation
    /// </summary>
    class Rectangle : Shape
    {
        //Auto iplmanted properties for the length and width of the rectangle
        public double Length { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// constructor fort the rectangle class
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
    public Rectangle(double length, double width) 
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// displays tthe area of a rectangle
        /// </summary>
        public override void DisplayArea()
        {
            Console.WriteLine($"Rectangle Area: {Length * Width}");
        }

    }
}
