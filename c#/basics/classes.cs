using System;

namespace App
{
    public class Greeting{
        public static int numberOfPeople=0;
        string name;
        public Greeting(string name){
            this.name = name;
            ++numberOfPeople;
        }

        public Greeting(){
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            ++numberOfPeople;
        }

        public void sayHello(){
            Console.WriteLine($"Hello,{name}");
        }
        public void sayHi(){
            Console.WriteLine($"Hi,{name}");
        }
        public void sayMorningGreet(){
            Console.WriteLine($"Good Morning ,{name}");
        }
        public void sayEveningGreet(){
            Console.WriteLine($"Good Evening , {name}");
        }
    }
    public class Program{
        static void Main(string[] args)
        {
            Greeting p1=new Greeting();
            Greeting p2 = new Greeting("Chethan");
            Greeting p3 = new Greeting("Alan");

            p2.sayEveningGreet();p2.sayHello();
            p1.sayHi();p3.sayMorningGreet();

            Console.WriteLine("The no of people are :{0}",Greeting.no);
        }
    }
}