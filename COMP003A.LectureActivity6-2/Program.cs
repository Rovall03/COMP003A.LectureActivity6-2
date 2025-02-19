namespace COMP003A.LectureActivity6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCalcuator calculator = new ShapeCalcuator();
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(5,10)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5,10,true)}");


            Shape myCrircle = new Circle(7);

            Shape myRectangle = new Rectangle(4,8);

            myCrircle.DisplayArea();
            myRectangle.DisplayArea();
        
        }
    }
}
