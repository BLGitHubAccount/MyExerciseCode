using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Animal.sdk;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Path.Combine(Environment.CurrentDirectory,"Animals");
            string[] files = Directory.GetFiles(folder);
            List<Type> animalTypes = new List<Type>();

            
            foreach (var file in files)
            {
                Assembly assembly = Assembly.LoadFile(file);
                Type[] types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if (type.GetInterfaces().Contains(typeof(IAnimal)))
                    {
                        var isUnfinish = type.GetCustomAttributes(false).Any(o => o.GetType() == typeof(UnFinishAttribute));
                        if (isUnfinish) continue;
                    }
                    animalTypes.Add(type);
                }
            }


            while (true)
            {
                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i+1},{animalTypes[i].Name}");
                }
                Console.WriteLine("================");
                Console.WriteLine("please choose animal:");
                int index = int.Parse(Console.ReadLine());
                Type t = animalTypes[index - 1];
                     
                var o= Activator.CreateInstance(t);
                var m = t.GetMethod("Voice");
                var a = o as IAnimal;
                a.Voice();
            }

        }
    }
}
