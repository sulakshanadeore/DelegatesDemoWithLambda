using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Customer
    {
        static List<string> names = new List<string>();
        public Customer()
        {
            names.Add("Jack");
            names.Add("Jim");
            names.Add("Jill");
            names.Add("Anant");

        }

        public void PrintNames()
        {

            //names.ForEach(s =>Console.WriteLine( s.StartsWith("A")));
           // names.ForEach(s => Console.WriteLine(s));
            names.ForEach(s => {
                Console.WriteLine(s + " =" + s.Length);
                
                Console.WriteLine(s.ToUpper());
            });





           



        }



        public void PrintIfLengthisGreaterThan4()
        {
            names.ForEach(n => {

                if(n.StartsWith("J"))
                    Console.WriteLine(n);
                //if (n.Length > 4) Console.WriteLine(n);

            });

        }



        public void RemoveStringFromList(string s)
        {
            string s1=names.Find(n=>n==s);
            if (s1 != null)
            {
                names.Remove(s1);
                Console.WriteLine("Removed");
                Console.WriteLine("Print remaining");
                names.ForEach(p => Console.WriteLine(p));

            }
            else {
                Console.WriteLine("Name not found");
            }


        }


        public void UpdateNameInList(string oldstring,string newstring)
        {
            string s1 = names.Find(n => n == oldstring);
            if (s1 != null)
            {
                int index=names.IndexOf(s1);
                names.Remove(s1);
                names.Insert(index, newstring);
                Console.WriteLine("Now the values are:");
                names.ForEach(p => Console.WriteLine(p));

            }


        }
        
       


    }
}
