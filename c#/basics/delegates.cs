using System;

namespace App
{
    class Program
    {
        public delegate Type Operation<Type>(Type a, Type b);
        static void Main(string[] args)
        {
            Operation<int> add = (a, b) => a + b;
            Operation<int> sub = (a, b) => a - b;
            Operation<int> mult = (a, b) => a * b;
            Console.WriteLine($"The add of 45 and 78 is {add(45,78)}");
            Console.WriteLine($"The sub of 45 and 78 is {sub(45,78)}");
            Console.WriteLine($"The mult of 45 and 78 is {mult(45,78)}");
        }
    }
}