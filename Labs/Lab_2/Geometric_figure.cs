using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    abstract class Geometric_figure: IPrint
    {
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public virtual double Square() => 0;
    }
}
