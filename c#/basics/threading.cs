using System;
using System.Threading;
namespace App
{
    interface Inter{
            void run();
    }
    public class DemoClass: Inter{
        public void run(){
            for(int i=1;i<=10;i++){
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1= new Thread(new ThreadStart(funcWithNoArg));
            Thread t2= new Thread(new ParameterizedThreadStart(funWithArg));
            Thread t3= new Thread(()=>{
                for(int j=1;j<=10;j++){
                    Console.WriteLine(j);
                    Thread.Sleep(1000);
                }
            });
            Thread t4= new Thread(new ThreadStart(new DemoClass().run));
            t2.Start(new object[]{1,11,1});
            t1.Start();
            t3.Start();
            t4.Start();
        }
        static void funcWithNoArg(){
            for(int i=1;i<=10;i++){
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        static void funWithArg(object args){
            object[] par =(object[])args;
            int st = (int)par[0];
            int en = (int)par[1];
            int step = (int)par[2];

            for(int k=st;k<en;k=k+step){
                Console.WriteLine(k);
                Thread.Sleep(1000);
            }

        }
    }
}