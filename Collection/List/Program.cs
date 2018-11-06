using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> l1 = new List<int>();
            var l2 = new List<int>(new[] { 10, 20, 33 });
            List<int> l3 = new List<int>(100);
            Console.WriteLine("-----Adding--------");
            l1.AddRange(new[] { 1, 2, -3, 4, 7, -89 });
                        l2.Insert(0, 10000);
            l1.ForEach(Console.WriteLine);
            Console.WriteLine("-----Removing--------");
            l1.Remove(1);
            l1.RemoveAt(3);
            l1.RemoveAll(s => s == 0);
            l1.ForEach(Console.WriteLine);
            Console.WriteLine("-----Getting--------");
            var subset = l1.GetRange(1, 3);
            Console.WriteLine(subset);
            var wordsArray = subset.ToArray();
            var stringsss = subset.ConvertAll<string>(s => s.ToString());
            stringsss.ForEach(Console.WriteLine);
              


            Console.ReadLine();
        }
    }

}