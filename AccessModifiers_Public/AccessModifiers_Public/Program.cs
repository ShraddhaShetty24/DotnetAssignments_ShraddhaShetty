using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Public
{
    internal class ValuesOfVariables
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main()
        {
            ValuesOfVariables p = new ValuesOfVariables();
            
            p.x = 10;// directly assigning
            p.y = 15;// directly assigning
            Console.WriteLine();
        }
    }
   
}
