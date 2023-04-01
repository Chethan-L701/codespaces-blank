using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace App
{
    class Program{

        static double findFibo(long num){
            double first=0,second=1;
            double third=1;
            for(int i=2;i<=num;i++){
                third = first +second;
                first = second;
                second = third;
            }
            return third;
        }
        static async Task Test(){
            var watch = new Stopwatch();
            watch.Start();
            Task<double> t1 =Task.Run(()=>findFibo(1750000000));
            Task<double> t2 =Task.Run(()=>findFibo(1900000000));
            await Task.WhenAll(t1,t2);
            watch.Stop();
            TimeSpan time = watch.Elapsed;
            Console.WriteLine($"Execution completed in {time.ToString()}");
            var watch1 = new Stopwatch();
            watch1.Start();
            findFibo(1750000000);
            findFibo(1900000000);
            watch1.Stop();
            TimeSpan time1 = watch1.Elapsed;
            Console.WriteLine($"Execution of non-sync completed in {time1.ToString()}");

        }
        static void Main(string []args){
            Task t = Task.Run(()=>Test());
            t.Wait();
        }
    }
}