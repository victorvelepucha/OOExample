using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interface
{
    // declaring an interface 
    public interface A
    {

        // method of interface 
        void mymethod1();
        void mymethod2();
    }

    // The methods of interface A  
    // is inherited into interface B 
    public interface B : A
    {

        // method of interface B 
        void mymethod3();
    }


    // Below class is inherting 
    // only interface B 
    // This class must  
    // implement both interfaces 
    class ClassInterface3 : B
    {

        // implementing the method 
        // of interface A 
        public void mymethod1()
        {
            Console.WriteLine("Implement method 1");
        }

        // Implement the method  
        // of interface A 
        public void mymethod2()
        {
            Console.WriteLine("Implement method 2");
        }

        // Implement the method 
        // of interface B 
        public void mymethod3()
        {
            Console.WriteLine("Implement method 3");
        }
    }
}
