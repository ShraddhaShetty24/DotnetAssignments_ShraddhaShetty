using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading_feb2
{
    class AddNumbers
    {
        public int add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        public double add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }

        public static void Main(String[] args)
        {

            // Creating Object
            AddNumbers ob = new AddNumbers();

            int sum2 = ob.add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);
            double sum3 = ob.add(1.0, 2.0, 3.0);
            Console.WriteLine("sum of the three "
                              + "double value : " + sum3);
        }
    }
}
