using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refVsout
{

    public class Program
    {
        public int AddAnotherNumber(int b)
        {
            b += 3;
            return b;
        }
        public int Addnumber( ref int a)
        {
            a += 2;
            return a;
        }
        
        static void Main(string[] args)
        {
            int a = 0;
            int b = 6;
            Console.WriteLine("a before modification = " + a);
            Console.WriteLine("a before modification = " + b);
            Program prog = new Program();
            int newA=prog.Addnumber(ref a);
            int newb = prog.AddAnotherNumber(b);
            
            Console.WriteLine("a after ref function =" + newA);
            Console.WriteLine("a after out function =" + newb);
            Console.WriteLine("original a after reference  = " + a);
            Console.WriteLine("original b after reference = " + b);
            Console.ReadKey();

        }
    }
}
