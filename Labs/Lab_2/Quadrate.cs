using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Quadrate : Rectangle, IPrint
    {
        public double length { get; set; }
        public Quadrate(double Length)
            : base(Length, Length)
        {
            length = Length;
        }
        public override string ToString() => ($"~~~~Quadrate~~~~\nlength: {length}\nsquare: {Square()}\n");
    }
}
