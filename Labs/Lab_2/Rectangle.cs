using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Rectangle : Geometric_figure, IPrint
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public override double Square() => (width * height);
        public override string ToString() => ($"S(прямоугольника)={Square()}\n");
    }
}
