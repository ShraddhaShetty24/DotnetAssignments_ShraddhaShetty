using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Protected
{
    class FirstClass
    {
        protected int x ;
    }

    class SecondClass : FirstClass
    {
        static void Main()
        {
            //FirstClass obj1 = new FirstClass();
            SecondClass obj2 = new SecondClass();

            // Error - because x can only be accessed by
            // classes derived from FirstClass.
            //obj1.x = 10;

            // because this class derives from FirstClass.
            obj2.x = 20;
        }
    }
}
