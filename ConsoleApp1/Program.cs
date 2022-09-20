using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void Message();
        static void Main(string[] args)
        {
            int i = 1;
            
            object obj = i;
            object j = obj;
            obj = 2;
            j = 3;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine(j);
        }

    }
    
}
