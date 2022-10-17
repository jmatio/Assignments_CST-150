
using System;
using System.Collections.Generic;
using System.Linq;	
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{

    //Corrected by Justin Matioschat
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}
//The first debugging method used was the step over method. The code highlighted will still be run by the compiler, but will move the debugger to the next method if there is nothing that needs to be stepped into.
//The next debugging method is the step into method. This will follow the order of code into other methods and show what is being executed and in what order.
//The last debugging method is the step out method. This will allow to return from a method to the original program or code.


namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                //the else statement was redundant and preventing values from being changed
                //this was the only syntax error I came across where the index variable indicated unreachable code
                if (val == elements[i])
                    return true;
                //else
                //return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            //created new object so values would not change in sets after union anymore
            Set AB = new Set();

            //redirected loop to new object
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                AB.addElement(rhs.elements[i]);
                //this.addElement(rhs.elements[i]);
            }

            //added another value to keep in new object
            for (int i = 0; i < this.elements.Count; i++)
            {
                AB.addElement(this.elements[i]);
            }

            return AB;
            //return rhs;
        }
    }
}
