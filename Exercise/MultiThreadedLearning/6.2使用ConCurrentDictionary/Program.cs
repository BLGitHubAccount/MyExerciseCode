using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace _6._2使用ConCurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var concurrentDictionary = new ConcurrentDictionary<int, string>();
            var dictionary = new Dictionary<int,string>();
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < Iteration; i++)
            {
                lock (dictionary)
                {
                    dictionary[i] = Item;
                }
            }
            sw.Stop();
            Console.WriteLine($"writing to dictionary with a lock:{sw.Elapsed}");
            sw.Restart();

            for (int i = 0; i < Iteration; i++)
            {
                concurrentDictionary[i] = Item;
            }
            sw.Stop();
            Console.WriteLine($"writing to concurrentdictionary with a lock:{sw.Elapsed}");
            sw.Restart();
            for (int i = 0; i < Iteration; i++)
            {
                lock (dictionary)
                {
                    CurrentItem = dictionary[i];
                }
            }
            sw.Stop();
            Console.WriteLine($"read from dictionary with a lock:{sw.Elapsed}");
            sw.Restart();
            for (int i = 0; i < Iteration; i++)
            {
                CurrentItem = concurrentDictionary[i];
            }
            sw.Stop();
            Console.WriteLine($"read from concurrentdictionary with a lock:{sw.Elapsed}");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        const string Item = "Dictionary item";
        const int Iteration = 10000000;
        public static string CurrentItem;
    }
}
