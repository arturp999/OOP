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

        protected double width, length;

        private int id;
        private int result;
        public const int SHAPE_TYPE = 1;

      
        public Shape(double dWidth, double dLength)
        {
            this.id = 99;
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

        public static int ReturningObjShape()
        {
            return SHAPE_TYPE;
        }
       

    }
}
