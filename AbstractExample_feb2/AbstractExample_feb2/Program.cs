using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample_feb2
{
    //abstract class Vehicles
    //{
    //     public abstract void running();
        
    //}
    //class Car: Vehicles
    //{
    //    public override void running()
    //     {
    //        Console.WriteLine("Hello ");
    //    }

    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car object = new Car();
    //        object.running();
    //    }
    //}

    // Abstract class
abstract class Animal
{
  
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("SLEEP");
  }
}

// Derived class (inherit from Animal)
class Dog : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The dog says: bow bow");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Dog myDog = new Dog(); // Create a Pig object
    myDog.animalSound();  // Call the abstract method
    myDog.sleep();  // Call the regular method
  }
}
}
