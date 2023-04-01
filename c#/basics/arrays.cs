using System;

namespace App
{
    public class Program{
        public static void Main(string[] args){
            //Arrays

            //declaration
            int[] a= new int[20];
            //int[20] b; or int a[20]; is wrong.

            //initialization

            int[] c = {10,20,30,40,50,60};
            int[] d = new int[]{90,80,10,40,70,46};

            //assignment

            a[0]=24;a[4]=40;

            //An array must have similar tupes of data stored in them ,
            //an int array can only store int type and not float type of data
            //to do that we can ise object array

            object[] arr={"Chethan",13,5.74,'A'};
            Console.WriteLine($"Name : {arr[0]}\nUSN : {arr[1]}\nHeight : {arr[2]}\nSec : {arr[3]}");
        }
    }
}