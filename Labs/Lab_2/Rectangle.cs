using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Rectangle : Geometric_figure, IPrint
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public override double Square() => (width * height);
        public override string ToString() => ($"~~~~Rectangle~~~~\nwidth: {width}\nheight: {height}\nsquare: {Square()}\n");
    }
}
