using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //foreach (int n in stack)
            //{
            //    Console.WriteLine(n);

            //}
            //Console.ReadKey();

            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            
            
            Console.ReadLine();
            

        }
    }
}
