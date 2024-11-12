using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{

    public delegate int MultiplyDelegate(int i, int j);
    public delegate string ConcatStringDelegate(string s1,string s2 );
    public class Maths
    {

        public int Multiply(int i, int j) {

            return i * j;
        }

    }
}
