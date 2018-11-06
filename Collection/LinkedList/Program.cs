using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {

        public struct Student
        {
            public Student (string n, int m)
            {
                Name = n;
                Mark = m;
            }
            public string Name { get; set; }
            public int Mark { get; set; }

            public override string ToString() => Name + " " + Mark;            
                
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----Adding--------");
            Student oleg = new Student("Oleg", 7);
            LinkedList<Student> group  = new LinkedList<Student>();
            group.AddFirst(oleg);
            group.AddLast(new Student("Anna", 10));
            group.AddAfter(group.First, new Student("Nikita", 3));
            group.AddAfter(group.First.Next, new Student("Olga", 8));
            group.AddBefore(group.Last, new Student("Oleg", 7));
            foreach (Student n in group)
                Console.WriteLine(n);
            Console.WriteLine("-----Removing--------");
            group.RemoveFirst(); 
            group.RemoveLast(); 
            foreach (Student n in group)
                Console.WriteLine(n);
            Console.WriteLine("-----Find--------");
            Console.WriteLine( group.Find(oleg));
           
            

        }
    }
}
