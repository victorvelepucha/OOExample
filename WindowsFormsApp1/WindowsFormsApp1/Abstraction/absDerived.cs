using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Abstraction
{
    abstract class absClass
    {

        protected int myNumber;

        public abstract int numbers
        {
            get;
            set;
        }
    }

    class absDerived : absClass
    {

        // Implementing abstract properties 
        public override int numbers
        {
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }
    }
}
