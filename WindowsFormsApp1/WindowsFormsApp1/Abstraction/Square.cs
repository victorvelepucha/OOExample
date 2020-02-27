using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // class 'AreaClass' inherit 
    // in child class 'Square' 
    class Square : Area
    {
        int side = 0;

        // constructor 
        public Square(int n)
        {
            side = n;
        }

        // the abstract method  
        // 'Area' is overridden here 
        public override int AreaCalculated()
        {
            return side * side;
        }
    }
}
