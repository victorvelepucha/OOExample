using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interface
{
    // Base class 
    class Interface2
    {

        // data members 
        public string name;
        public string subject;

        // public method of base class  
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the GFG class using :  
    class Interface2a : Interface2
    {

        // constructor of derived class 
        public Interface2a()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }

    // Driver class 
    class Sudo
    {

        // Main Method 
        static void Main(string[] args)
        {

        }
    }
}
