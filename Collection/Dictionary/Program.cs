using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----Dictionary<TKey, TValue>------\n");

            Dictionary<string, int> dic = new Dictionary<string, int>();
            // c инициализациtq
            var dic2 = new Dictionary<string, int> { { "Anna", 1 }, { "Fedia", 2 } };

            Dictionary<string, int> dic3 = new Dictionary<string, int> { ["Anna"] = 1, ["Fedia"] = 2 };


            // конструктор со "сравнивателем" ключей (IEqualityComparer)
            Dictionary<string, int> dic4 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (KeyValuePair<string, int> element in dic2)
            {
                Console.WriteLine($"Name: { element.Key},  Age: { element.Value}");
            }

            dic2["Anna"] = 22;
            dic2.Add("Olga", 3);

            // обновляем существующий элемент (или создаём новый)
            dic2["Nikita"] = 2;
            dic2["Vlad"] = 40;
            Console.WriteLine("\n----Adding----------");
            foreach (KeyValuePair<string, int> element in dic2)
            {
                Console.WriteLine($"Name: { element.Key},  Age: { element.Value}");
            }
            Console.WriteLine("\n----Checking----------");
            Console.WriteLine(dic2["Nikita"]);
            Console.WriteLine(dic2.ContainsKey("Olga")); // быстрая операция
            Console.WriteLine(dic2.ContainsValue(40)); // медленная операция
            dic2.First(n => (n.Value == 40));


            int val;
            if (!dic2.TryGetValue("Olga", out val))
            {
                Console.WriteLine("No such value");
            }

            Console.WriteLine("\n----Keys- and -Valuse--------");
            foreach (var pair in dic2)
            {
                Console.WriteLine(pair.Key + "; " + pair.Value);
            }
            Console.WriteLine("\n----Keys----------");
            foreach (var key in dic2.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("\n----Values----------");
            foreach (var value in dic2.Values)
            {
                Console.WriteLine(value);
            }

            //  данные всегда отсортированы по ключу
          
            // SortedList<TKey, TValue> потребляет меньше памяти
            // SortedDictionary<TKey, TValue> быстрее при вставке несортировнных данных
            // у SortedList<TKey, TValue> быстрее методы получения Keys и Values
            var sd = new SortedDictionary<string, int>(dic2);
            foreach (var pair in sd)
            {
                Console.WriteLine(pair.Key + "; " + pair.Value);
            }

           
          
            // OrderedDictionary – запоминает порядок добавления элементов в словарь
            // ListDictionary - использует для хранения элементов односвязный список.
            // HybridDictionary – переключается с ListDictionary на Hashtable
            // SortedList

            Console.ReadLine();

        }
    }
}
