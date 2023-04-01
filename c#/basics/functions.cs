using System;

namespace App
{
    class Program{
        static void add(int a,int b){//a common function with no return value.
            Console.WriteLine($"The sum is {a+b}");
        }
        static double square(int b){
            return b*b;
        }
        static double square(float b){//overloaded function
            return b*b;
        }
        static double area(int a,int b,float c=1.0f){//default argument
            return (c*a*b);
        }
        static void funArg(int a=10,int b=40,int c= 30,int d=50){
            Console.WriteLine($"The values of a,b,c and d is :{a},{b},{c} and {d}");
        }
        static void getX(out int x){//parameter modifier 'out'(must assign the value)
            x=40;//all the oit parameter must get a value assigned in the function
            //x is passed by reference but it can only be assigned and not read
        }
        static void printY(in int y){//parameter  modifier 'in'(can only use the parameter value)
            Console.WriteLine($"The value of y is {y}");//cannot modify y in this funtion
            //y is passed by reference it only be read but cannot be modified
        }
        static void getZ(ref int Z){
            Console.WriteLine($"The value of Z is {Z}");
            Z=10;
        }
        static void Main(string [] args){
            add(29,89);
            Console.WriteLine($"The square of 5 is {square(5)}");
            Console.WriteLine($"The square of 2.5 is {square(2.5f)}");
            Console.WriteLine($"The area of rectangle of dimension 4 x 8 is {area(4,8)}");
            Console.WriteLine($"The area of triangle of height 10 and base 20 is {area(10,20,0.5f)}");
            funArg();
            funArg(15,35,45,75);
            funArg(12,36,48);
            funArg(a:99,d:79);
            funArg(c:87,b:11);
            funArg(d:78,c:69,b:17,a:43);
            int x;
            getX(out x);
            Console.WriteLine($"The value of x is {x}");
            int y=50;
            printY(in y);
            int Z=60;
            getZ(ref Z);
            Console.WriteLine($"The current value of Z is {Z}");
        }
    }
}