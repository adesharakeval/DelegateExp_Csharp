

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExp
{
    class Program
    {
        public delegate int BindaryOp(int x, int y);
        public class SimpleMath
        {
            public static int Add(int x, int y)
            {
                return x + y;

            }
            public static int Sub(int x, int y)
            {
                return x - y;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Deleagate Example"+"");
            BindaryOp op1 = new BindaryOp(SimpleMath.Add);
            Console.WriteLine("10+10 is : {0}", op1(10, 10));
            Console.Read();

        }
    }
}
