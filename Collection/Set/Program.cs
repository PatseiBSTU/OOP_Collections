using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----HashSet--------");
            var setOne = new HashSet<char>("Hello world");
            foreach (char c in setOne)
                Console.Write($" {c} ");
            Console.WriteLine();
            var setTwo = new HashSet<char>("the end of year");
            foreach (char c in setTwo)
                Console.Write($" {c} ");
            Console.WriteLine();
            Console.WriteLine("-----IntersectWith--------");
            setOne.IntersectWith(setTwo);
            foreach (char c in setOne)
                Console.Write($" {c} ");
            setOne.Add('s');
            Console.WriteLine();
            Console.WriteLine(setOne.Contains('t')); // True
            Console.WriteLine(setOne.Contains('j')); // False
            setTwo.RemoveWhere(c => c < 'k');
            foreach (char c in setTwo)
                Console.Write($" {c} ");
            Console.WriteLine();


            Console.WriteLine("-----SortedSet <T> --------"); // множество на основе красно-чёрного дерева
            var sSetOne = new SortedSet<char>("Hello Fit");
            foreach (char c in sSetOne)
                Console.Write($" {c} ");
            Console.WriteLine("\n------------Min Max---------");
            Console.WriteLine($"{sSetOne.Min} {sSetOne.Max}" );
            IEnumerable<char> reversed = sSetOne.Reverse();
            foreach (char c in reversed)
                Console.Write($" {c} ");
            Console.WriteLine();
            var sSetTwo = sSetOne.GetViewBetween('e', 'i');
            foreach (char c in sSetTwo)
                Console.Write($" {c} ");
            Console.WriteLine("\n------------Min Max---------");
            Console.WriteLine($"{sSetTwo.Min} {sSetTwo.Max}");
            Console.ReadLine();

           

        }
    }
}
