using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interface
{
    // A simple interface 
    interface interface1
    {

        // method having only declaration 
        // not definition 
        void show();
    }

    // A class that implements the interface. 
    class MyClass : interface1
    {

        // providing the body part of function 
        public void show()
        {
            Console.WriteLine("Welcome to GeeksforGeeks!!!");
        }

        
    }
}
