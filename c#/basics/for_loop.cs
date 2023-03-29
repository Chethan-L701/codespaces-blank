using System;

namespace App
{
    class Program{
        static void Main(string [] args){
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the number of time to print :");
            int n = Convert.ToInt16(Console.ReadLine());

            for(int i=0;i<n;++i){
                Console.WriteLine(text+" : "+i);
            }
        }
    }
}