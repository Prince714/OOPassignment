using System;
using System.Collections.Generic;
using System.Text;

namespace Psim
{
    namespace Geometry2D
    {

        class Point
        {
            public double X{ get; set; }
            public double Y { get; set; }
            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }


            public void GetCoords(out double x, out double y)
            {
                x = X;
                y = Y;
            }

           

            public void  SetCoords(double? x, double? y)
            {
                 X = x?? X;
                 Y = y??Y;
            }


         
            public override string ToString()
            {
                return $"({X}, {Y})";
            }

        }

        class Vector
        { 
            public double DX { get; private set; }
            public double DY { get; private set; }


            public Vector(double DX = 0, double DY = 0)
            { 
                  
            }


            public void Set(double dx, double dy)
            {

                if (dx >= 1 && dy <= -1 || dx <= -1 && dy >= 1)
                {
                    DX = dx;
                    DY = dy;
                }
                else
                {
                    Console.WriteLine(" This is an invalid argument and the vector is out of range");

                }

                // here dx and dy >=1 or <=-1 it shows exception
            }

           
            public override string ToString()
            {
                return $"({DX},{DY})";
            }


        }


        class Rectangle
        {

            public double Length{get; }
            public double Width { get; }

            public double Area { get; }


            public Rectangle(double length, double width)
            { 
            
            
            }
        }




    }
}
