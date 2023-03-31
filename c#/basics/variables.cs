using System;

namespace App
{
    class Program{
        static void Main(string [] args){
            int a=90;//integer
            Int16 b=10;//16 bit-integer
            Int32 c;//32 bit int or int
            Int64 d;//64 bit int or long
            

            float e;
            double f;

            decimal h = 1.543643545246465765345657354M;

            bool r;

            char ch;

            string str;

            int[] arr=new int [10];

            Console.WriteLine("The max value of int : "+int.MaxValue);
            Console.WriteLine("The max value of Int16 : "+Int16.MaxValue);
            Console.WriteLine("The max value of Int32 : "+Int32.MaxValue);
            Console.WriteLine("The max value of int64 : "+Int64.MaxValue);

        }
    }
}