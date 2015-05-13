using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split(' ');
            Array.Sort(items);

            foreach (var value in items)
            {
                Console.WriteLine(value);
               
            }
         
        }

    }
