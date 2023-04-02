using System;
using System.Collections.Generic;

namespace App
{
    public class Array<Type>
    {
        private Type[] arr;
        private int size = 0;
        private int maxSize;
        public Array(int size)
        {
            arr = new Type[size];
            maxSize = size;
        }
        public void insert(Type data)
        {
            if (size == maxSize) throw new IndexOutOfRangeException("Exceeded the array limit");
            arr[size] = data;
            size++;
        }
        public void display()
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i].ToString() + '\t');
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array<int> intArray = new Array<int>(10);
            intArray.insert(10); intArray.insert(20); intArray.insert(30);
            intArray.insert(40); intArray.insert(50);

            Array<char> charArray = new Array<char>(10);
            charArray.insert('a'); charArray.insert('b'); charArray.insert('c');
            charArray.insert('d'); charArray.insert('e');

            intArray.display();charArray.display();
        }
    }
}