using System;

namespace App{
    class Program{
        static void Main(string [] args){
            Console.WriteLine("Enter yoir age : ");
            int age = Convert.ToUInt16(Console.ReadLine());
            if(age >0 && age <13)
                Console.WriteLine("Too young");
            else if(age <= 21){
                Console.WriteLine("Ok!");
            }else if(age<100){
                Console.WriteLine("Sorry boomer");
            }else{
                Console.WriteLine("Stop capping.");
            }
        }
    }
}