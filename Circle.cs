using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle : Shape
    {
        protected int radius;
        new public const int SHAPE_TYPE = 3;

        public Circle(int iradius, double dWidth, double dLength, int id) : base(dWidth, dLength, id)
        {
            this.radius = iradius;
        }

        public double CalculateCArea(int iradius)
        {
            var result = 3.14 * (iradius * iradius);

            return result;
        }

        public override void returnObjValues(Shape shapeObj)
        {
            Console.WriteLine("\nCircle Radius is : " + name + "\nCircle Radius is : " + radius);
        }


    }
}
