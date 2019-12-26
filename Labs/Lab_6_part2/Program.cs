using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_part2
{
    class Program
    {
        static void TypeInfo()
        {
            ForInspection obj = new ForInspection();
            Type t = obj.GetType();

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПоля данных:");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nForInspection реализует IComparable -> " +
            t.GetInterfaces().Contains(typeof(IComparable))
            );
        }
        static void InvokeMemberInfo()
        {
            Type t = typeof(ForInspection);
            Console.WriteLine("\nВызов метода:");

            ForInspection fi = (ForInspection)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            object[] parameters = new object[] { 3, 2 };
            object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("Plus(3,2)={0}", Result);
        }
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }
        static void AttributeInfo()
        {
            Type t = typeof(ForInspection);
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                {
                    NewAttribute attr = attrObj as NewAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
        }
        static void Main(string[] args)
        {
            TypeInfo();
            InvokeMemberInfo();
            AttributeInfo();
            Console.ReadLine();
        }
    }
}
