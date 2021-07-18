using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Shape
    {
        public string name { get; set; }
        public const int SHAPE_TYPE = 1;

        protected double width, length;

        private int id = 0;

        private int result;

        public Shape(double dWidth, double dLength, int id)
        {
            this.id = id+1; //unique id 
            this.width = dWidth;
            this.length = dLength;
        }

        public Shape()
        {
        }

        public int Area(int width, int length, string type)
        {
            if (type == "Square")
            {
                result = length * 4;
            }

            if (type == "Rectangle")
            {
                result = length * width;
            }

            return result;
        }

        public static int ReturningObjShape(int shape)
        {
            return shape;
        }

        public virtual void returnObjValues(Shape shapeObj)
        {
            Console.WriteLine("\nThe Obj name is: " + name + "\nWidth is: " + width + "\nLength is: " + length + "\nid: " + id);
        }

    }
}
