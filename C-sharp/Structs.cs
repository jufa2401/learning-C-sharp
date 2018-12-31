using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class Rectangle
    {
            public double Length;
            public double Height;

            public Rectangle(double length = 1, double height = 1)
            {
                this.Length = length;
                this.Height = height;
            }

            public double Area()
            {
                return Length * Height;
            }

        struct Circle
        {
            private double radius;

            public double Radius
            {
                get => radius;
                set => radius = value;
            }
        }

        // Above is the same as
        struct Circle2
        {
            public double Radius { get; set; }
        }

        private struct Minute
        {
            private double second;
            public double Second
            {
                get => second;
                set
                {
                    if ((value >= 0) && (value < 60)) Second = value;
                }
            }
        }
    }
}
