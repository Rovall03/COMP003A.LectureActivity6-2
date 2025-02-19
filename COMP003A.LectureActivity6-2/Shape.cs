using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
 /// <summary>
/// represents a base class for goemetric shapes 
/// </summary>
     class Shape
    {
     /// <summary>
    /// displays the srea of a shape
    /// </summary>
        public virtual void DisplayArea()
        {
            Console.WriteLine("Calculating area of a shape");
        }
    }
}
