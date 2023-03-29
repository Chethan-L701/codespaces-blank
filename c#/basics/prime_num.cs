using System;

namespace App
{
    class Program{
        static void Main(string [] args){
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime=true;
            for(int i=2;i<=(num/2);i++){
                if((num%i)==0){
                    isPrime=false;
                    break;
                }
            }
            string res = (isPrime)?"is prime":" is not prime";
            Console.WriteLine("The number "+res);
        }
    }
}