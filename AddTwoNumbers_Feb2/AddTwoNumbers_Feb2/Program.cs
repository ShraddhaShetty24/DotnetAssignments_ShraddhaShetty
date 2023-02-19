using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers_Feb2
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, result;
            
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            result = firstNum + secondNum;
            Console.WriteLine(result);

        }
    }
}
