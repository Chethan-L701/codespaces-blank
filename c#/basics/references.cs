using System;

namespace App
{
    class Program{
        static void Main(string [] args){
            int b=40;
            ref int a = ref b;
            a=90;

            Console.WriteLine($"The value of b is {b}");

        }
    }
}