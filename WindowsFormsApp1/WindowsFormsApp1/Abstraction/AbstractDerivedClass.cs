using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Abstraction
{
    abstract class AbstractClass
    {

        // Non abstract method 
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        // An abstract method which  
        // overridden in the derived class 
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);

    }

    // Child Class of AbstractClass 
    class Derived : AbstractClass
    {

        // implementing the abstract  
        // method 'MultiplyTwoNumbers' 
        // using override keyword, 
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
