using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary< string > mydictionary = new MyDictionary<string>();
            mydictionary.Add("OSMAN");
            Console.WriteLine(mydictionary.Length);
            mydictionary.Add("Kerpeten");
            Console.WriteLine(mydictionary.Length);
            mydictionary.Add("Ali");
            Console.WriteLine(mydictionary.Length);

            foreach (var isim in mydictionary.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
