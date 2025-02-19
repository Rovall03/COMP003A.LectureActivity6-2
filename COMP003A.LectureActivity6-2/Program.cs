namespace COMP003A.LectureActivity6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //demostrating methode overloading
            ShapeCalcuator calculator = new ShapeCalcuator();
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(5,10)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5,10,true)}");

            //demonstrating method overrriding
            //creating a base class refrence to a derived class object for polymorphism
            Shape myCrircle = new Circle(7);


            //creating a base class reference to a derived class object for polymorphism
            Shape myRectangle = new Rectangle(4,8);

            //calling the DisplayArea method from the circle and rectangle objects
            myCrircle.DisplayArea();
            myRectangle.DisplayArea();
        
        }
    }
}
