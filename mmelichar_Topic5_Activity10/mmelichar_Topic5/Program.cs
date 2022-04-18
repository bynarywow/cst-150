namespace mmelichar_Topic5_Activity10
{
    //Corrected by Michael Melichar

    //use for IC08
    //Lydia's code
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //these imports don't need to be here, they're not being used
    //thus, waste of memory.
    //using System.Text;
    //using System.Threading.Tasks;

    namespace CST117_IC08_console
    {
        class Program
        {
            static void Main(string[] args)
            {
                //make some sets
                //use lists instead - base functionality rather than rewriting
                //Set A = new Set();
                //Set B = new Set();

                List<int> A = new List<int>();
                List<int> B = new List<int>();

                //put some stuff in the sets
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    //changed from addElement to Add
                    A.Add(r.Next(4));
                    B.Add(r.Next(12));
                }
                //a lot easier to use extensively documented functions rather than
                //reinvent the wheel.
                List<int> union = A.Union(B).ToList();

                //make the list of integers printable
                //instead of overriding base ToString functionality,
                //use string.Join, since it does the exact same thing
                //in one line of code instead of 9.
                string stringA = string.Join(" ", A);
                string stringB = string.Join(" ", B);
                string stringUnion = string.Join(" ", union);

                //display each set and the union
                Console.WriteLine("A: " + stringA);
                Console.WriteLine("B: " + stringB);
                Console.WriteLine("A union B: " + stringUnion);

                //display original sets (should be unchanged)
                Console.WriteLine("After union operation");
                Console.WriteLine("A: " + stringA);
                Console.WriteLine("B: " + stringB);

            }
        }
    }
    //Set
    //Describe several debugging techniques and scenarios for their use.


    //Lydia's code - find the errors!
    //the error is not looking up if these things already exist
    //finding preexisting documentation is key to not wasting company
    //time and money - don't reinvent the wheel.
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
                    if (val == elements[i])
                        return true;
                    else
                        return false;
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

            //if the sets are to remain the same, the union function needs to not
            //add the elements of B to A in order to make a union of it
            //she would also be better off not reinventing the wheel and just
            //using the built in linq enumerable union function, since we're already
            //importing those resources. This code also doesn't produce correct output
            //since it doesn't actually give an end result that shows all members of each set
            public Set union(Set rhs)
            {
                for (int i = 0; i < rhs.elements.Count; i++)
                {
                    this.addElement(rhs.elements[i]);
                }
                return rhs;
            }
        }
    }
}