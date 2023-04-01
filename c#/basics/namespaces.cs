using System;

namespace NameSpace1
{
    public class Program{
        public static void fun1(){
        Console.WriteLine("This is the function 1 of Program class in Namespace 1.");
        }
        public static void fun2(){
            Console.WriteLine("This is the function 2 of Program class in Namespace 1.");
        }
    }
}

namespace NameSpace2
{
    public class Program{
        public static void fun1(){
        Console.WriteLine("This is the function 1 of Program class in Namespace 2.");
        }
        public static void fun2(){
            Console.WriteLine("This is the function 2 of Program class in Namespace 2.");
        }
    }
}

namespace App
{
    public class Program{

        public static void fun1(){
            Console.WriteLine("This is the function 1 of Program class of App namespace.");
        }
        public static void fun2(){
            Console.WriteLine("This is the function 2 of Program class of App namespace.");
        }
        public static void Main(string [] args){
            Program.fun1();
            Program.fun2();
            NameSpace1.Program.fun1();
            NameSpace2.Program.fun1();
            NameSpace1.Program.fun2();
            NameSpace2.Program.fun2();
        }
    }
}