using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public abstract class Geometric_figure:IComparable
    {
        public int CompareTo(object obj)
        {
            var gf = (Geometric_figure)obj;
            if (this.Square() > gf.Square())
                return 1;
            else if (this.Square() < gf.Square())
                return -1;
            else
                return 0;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public virtual double Square() => 0;
    }
}
