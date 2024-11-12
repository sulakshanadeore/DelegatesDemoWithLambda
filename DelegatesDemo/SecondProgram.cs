using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeLibrary;
namespace DelegatesDemo
{

    public delegate void PrintDataDelegate(string s, string s1);

    internal class SecondProgram
    {
        static void Main(string[] args)
        {
            Customer c=new Customer();
            //c.PrintNames();

            //Console.WriteLine("============================");

            //c.PrintIfLengthisGreaterThan4();

            //    Console.WriteLine("-------------------");
            //Console.WriteLine("enter a name to remove");
            //string input=Console.ReadLine();
            //c.RemoveStringFromList(input);


            Console.WriteLine("Enter old string");
            string old=Console.ReadLine();
            Console.WriteLine("Enter new string");
            string newstr=Console.ReadLine();
            c.UpdateNameInList(old, newstr);    



            ////Lambda is a brief way of writing delegate methods
            //PrintDataDelegate pd = new PrintDataDelegate((s1, s2) => 
            //    Console.WriteLine(s1 +  "  " + s2)
            //         );
            //pd.Invoke("Jack And ", "Jill");




            //MultiplyDelegate del = delegate (int a, int b) 
            //{
            //    int ans = a * b;
            //    return ans; 

            //};
            //int multians=del.Invoke(10, 2);
            //Console.WriteLine(multians);
            //Console.WriteLine("------------------------------------");
            //MultiplyDelegate obj = new MultiplyDelegate(
            //    (i, j) => {
            //    int multiAns = i * j*10;
            //   return multiAns;

            //}
            //    );

            //int multiplyAns=obj(10, 20);
            //Console.WriteLine(multiplyAns);

            //Console.WriteLine("--------------------------");
            //ConcatStringDelegate sd = new ConcatStringDelegate((string p1,string p2) => {

            //    string s3=string.Concat(p1, p2);
            //    return s3;
            //});

            //string finalString=sd.Invoke("Hello   ", "World");
            //Console.WriteLine(finalString);



            Console.Read();

        }
    }
}
