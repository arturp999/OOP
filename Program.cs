using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            


            //Shape t = new Shape();
            //Console.WriteLine(t.Area(15, 20, "Rectangle")); //Calculates Area and returns it
            //Console.WriteLine(Shape.ReturningObjShape());

            //Console.WriteLine("------------------------------");
            //Circle test = new Circle(45,15,20)
            //Console.WriteLine(Circle.ReturningObjShape(Circle.SHAPE_TYPE)); // Public Static returns SHAPE_TYPE

            //Shape test = new Shape(100, 200);
            //test.name = "This is the Shape Name";
            //test.returnObjValues(test);

            Circle ctest = new Circle(15, 1, 2, 5);
            ctest.name = "This is the Shape Name";

            ctest.returnObjValues(ctest);
           }
    }
}
