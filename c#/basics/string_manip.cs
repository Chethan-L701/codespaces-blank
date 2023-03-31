using System;

namespace App
{
    class StringManip{
        static void Main (string [] args){
            //Few string function.

            string str="This is a string";
            Console.WriteLine($"The string is {str}");
            Console.WriteLine($"The string 'is' a sub string of   {str.Contains("is")}");
            Console.WriteLine($"The index of 'is' sub string is {str.IndexOf("is")}");
            Console.WriteLine($"Replace 'string' with 'another string' {str.Replace("string","another string")}");
            Console.WriteLine($"Remove 'a' from the string  {str.Remove(8,1)}");
            Console.WriteLine($"Compare \"A\" with \"B\" : {String.Compare("A","B")}");
            Console.WriteLine($"Length of a string : {str.Length}");
            Console.WriteLine($"Inserting a text  : {str.Insert(5,"<inserted text>")}");
        }
    }
}