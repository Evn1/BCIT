using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Circle : Geometric_figure , IPrint
    {
        public double radius { get; set; }
        public Circle(double Radius)
        {
            radius = Radius;
        }
        public override double Square() => (Math.PI * radius * radius);
        public override string ToString() => ($"S(круга)={Square()}\n");
    }
}
