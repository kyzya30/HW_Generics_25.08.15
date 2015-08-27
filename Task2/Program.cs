using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,int> dictionary = new MyDictionary<int, int>();
            dictionary.Add(4,20);
            dictionary.Add(5, 22);
            Console.WriteLine("Введите key в словаре:");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} -> {1}", key, dictionary[key]);
          
        }
    }

   
}
