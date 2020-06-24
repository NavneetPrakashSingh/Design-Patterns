using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Builder
{
    class Product
    {
        List<string> str = new List<string>();
        public List<string> add(string input)
        {
            str.Add(input);
            return str;
        }
        public void print()
        {
            Console.WriteLine("Product contains:");
            for (int i = 0; i < str.Count; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine("----");
        }
    }
}
