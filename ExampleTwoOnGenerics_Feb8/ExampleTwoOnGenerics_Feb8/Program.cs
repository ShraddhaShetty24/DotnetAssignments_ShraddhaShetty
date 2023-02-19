using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwoOnGenerics_Feb8
{
    internal class Program
    {

       public class DiffDataType
        {

            //for two different data types
            public void fun<Integer,String>(Integer a,String s)
            {
                Console.WriteLine($"Integer a={a}, String s={s}");
            }

            //for same data types
            //public void funOne<Integer>(int a, int b)
            //{
            //    int sum = a+b;
            //    Console.WriteLine($"Integer a={a}, Integer b={b}, Sum={sum}");
            //}

            public void funOne<T>(T num1, T num2)
            {
                int sum=Convert.ToInt32(num1)+Convert.ToInt32(num2);
                Console.WriteLine($"Sum:{sum}");
            }

        }

        public class Shapes
        {
            public void shapes1<T>(T name, T length, T bredth)
            {
                if (Convert.ToString(name)=="Rectangle")
                {
                    int area = Convert.ToInt32(length) * Convert.ToInt32(bredth);
                    Console.WriteLine($"Area of the {name}: {area}");
                }
                if (Convert.ToString(name)=="Square")
                {
                    int area = Convert.ToInt32(length) * Convert.ToInt32(length);
                    Console.WriteLine($"Area of the {name}: {area}");
                }


            }
        }

               
        static void Main(string[] args)
        {
            DiffDataType diffDataType = new DiffDataType();
            diffDataType.fun(10, "Hello");
            diffDataType.funOne<int>(10, 20);

            Shapes shapes=new Shapes();
            shapes.shapes1("Rectangle", "10","20");
            shapes.shapes1("Square", "10", "20");


        }
    }
}
