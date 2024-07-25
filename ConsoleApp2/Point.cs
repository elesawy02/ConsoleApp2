using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        public int CompareTo(object? obj)
        {
            Point passedPoint = (Point)obj;




            if (obj is Point passedPoint)
            {
                

                if (this.X == passedPoint.X)
                    return this.Y.CompareTo(passedPoint.Y);
                else
                    return this.X.CompareTo(passedPoint.X);

            }
            if (obj is null)
                return 1;

            return 1;



            Point passedPoint = obj as Point;


            if (passedPoint is not null)
            {
                if (this.X == passedPoint.X)
                    return this.Y.CompareTo(passedPoint.Y);
                else
                    return this.X.CompareTo(passedPoint.X);
            }

            return 1;








        }

        public int CompareTo(Point? passedPoint)
        {
            if (passedPoint is not null)
            {
                if (this.X == passedPoint.X)
                    return this.Y.CompareTo(passedPoint.Y);
                else
                    return this.X.CompareTo(passedPoint.X);
            }
            return -1;
        }
    }
}
