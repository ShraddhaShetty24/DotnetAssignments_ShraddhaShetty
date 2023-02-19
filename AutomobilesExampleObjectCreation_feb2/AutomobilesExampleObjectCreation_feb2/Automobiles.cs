using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobilesExampleObjectCreation_feb2
{
    internal class Automobiles
    {
        String name="Car";
        String modelName ="Baleno";
        String dateOfManufacture = "24-03-2000";
        int twoOrFourWheelDrive = 4;
        static void Main(string[] args)
        {
            Automobiles obj= new Automobiles();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.modelName);
            Console.WriteLine(obj.dateOfManufacture);
            Console.WriteLine(obj.twoOrFourWheelDrive);
        }
    }
}
