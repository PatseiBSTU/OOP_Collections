using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Queue<T>------\n");
            
            var q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            Console.WriteLine(q.Dequeue()); // 100
            q.Enqueue(89);
            Console.WriteLine(q.ElementAt(1)); //89
            Console.WriteLine(q.First());//200


            Console.WriteLine("---- Stack<T>------\n");
            var stack = new Stack<char>();
            stack.Push('F');
            stack.Push('I');
            stack.Push('T');
            stack.Push('G');
            stack.Push('X');
            stack.OrderBy(n => n);
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Max());
        }
    }
}
