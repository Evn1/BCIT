using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Quadrate : Rectangle, IPrint
    {
        public double length { get; set; }
        public Quadrate(double Length)
            : base(Length, Length)
        {
            length = Length;
        }
        public override string ToString() => ($"S(квадрата)={Square()}\n");
    }
}
