using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompoundInterest_Feb2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int principal, rateOfInterest, time,compoundInterest, finalCompoundInterest;
            
            Console.WriteLine("Enter the princiapl amount: ");
            principal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest: ");
            rateOfInterest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time: ");
            time = Convert.ToInt32(Console.ReadLine());
           
            compoundInterest = (principal * (1 + rateOfInterest) / 100);
            finalCompoundInterest = (int)Math.Pow(compoundInterest, time);
            Console.WriteLine("The compound interest is: ");
            Console.WriteLine(finalCompoundInterest);



        }
    }
}
