using System;
namespace program
{
    class hello{
        static void Main(string []args){
            Console.WriteLine("Enter two numbers two add:");
            int y = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.BackgroundColor=ConsoleColor.DarkGray;
            Console.Clear();
            Console.WriteLine("The sum is "+(x+y));
        }
    }
}