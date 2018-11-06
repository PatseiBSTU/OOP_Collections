using System;
using System.Reflection;
using System.Collections;


namespace ArrayColl
{
    class Program
    {
        static void Main(string[] args)
        { // создание массива 
          
            Array arr = Array.CreateInstance(typeof(int), 4);    // тип, длина
            arr.SetValue(200, 0);                 
            arr.SetValue(30, 1);
            arr.SetValue(200, 2);
            arr.SetValue(40, 3);
            int s = (int)arr.GetValue(2);

            Console.WriteLine("----Reverse--------\n");
            int[]arr2 = { 7, 6, 5, -7, 0, -4 };
            Array.Reverse(arr2);
            Array.ForEach(arr2, Console.Write);


            Console.WriteLine("\n----Find-------\n");
            // поиск элемента по предикату
            int b = Array.FindLastIndex(arr2, x => x>50 );

            Console.WriteLine(b);
            Console.WriteLine("");
            // поиск всех элементов
            var c = Array.FindAll(arr2, x =>x == 200);
            Array.ForEach(c, Console.Write);

            // действие над элементами
            Array.ForEach(arr2, Console.WriteLine);

            // проверка условия
            bool flag = Array.TrueForAll(arr2, x => x > 0);
            Console.WriteLine("\n----Sort------\n");
            // сортировка
            Array.Sort(arr2, (x, y) => x == y ? 0 : x > y ? -1 : 1);
            Array.ForEach(arr2, Console.WriteLine);
            // двоичный поиск
            Console.WriteLine("\n----Search------\n");
            int pos = Array.BinarySearch(arr, 3);

            // копирование; 
            int[] source = { 10, 3, 5, -7, 0, 20, 10, 4 };
            int[] dest = new int[arr.Length];
            
             //сортировка
            Array.Sort(source);
            Array.ForEach(source, Console.WriteLine);
            Console.WriteLine(source.Rank); //Свойство для чтения, возвращает размерность массива
            Console.WriteLine(source.GetValue(3));

           

            Console.ReadLine();

        }
    }
}
