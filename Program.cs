using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("въведете дължината на правоъгълника");
            int a =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("въведете ширината на правоъгълника");
            int b = Convert.ToInt32(Console.ReadLine());
    
            Console.WriteLine("Лицето на правоъгълника е:");
            int s = a * b;
            Console.WriteLine(s);
        }
    }
}
