using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_part2
{
    public class ForInspection : IComparable
    {
        public ForInspection() { }
        public ForInspection(int i) { }
        public ForInspection(string str) { }

        public int Multiply(int x, int y) { return x * y; }
        public int Plus(int x, int y) { return x + y; }

        [NewAttribute("Описание для свойства1")]
        public string p1
        {
            get { return _p1; }
            set { _p1 = value; }
        }
        private string _p1;

        public int p2 { get; set; }

        [NewAttribute(Description = "Описание для свойства3")]
        public double p3 { get; private set; }

        public int field1;
        public float field2;
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
