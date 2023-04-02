using System;
using System.Text.RegularExpressions;
namespace App
{
    public class Person{
        protected string name;
        protected long aadhar;
        protected int age;
        protected double height;
        protected static int totalNo;
        protected static Regex validateAadhar = new Regex(@"^[0-9]{12}$");
        public Person(){
            totalNo++;
        }
        public string Name{
            get{return this.name;}
            set{this.name=value;}
        }
        public int Age{
            get{return age;}
            set{
                if(value>=0 && value<=120){
                    this.age=value;
                }else{
                    throw new ArgumentException("Not a valid age.");
                }
            }
        }
        public long AadharNo{
            get{return aadhar;}
            set{
                if(validateAadhar.IsMatch(value.ToString())){
                    this.aadhar=value;
                }else{
                    throw new ArgumentException("Not a valid Aadhar Number.");
                }
            }
        }
        public double Height{
            get{return height;}
            set{
                if(value>=1.0 && value<= 8.0){
                    this.height=value;
                }else{
                    throw new ArgumentException("Not a valid height.");
                }
            }
        }
        public int TotalNo{
            get{return totalNo;}
        }
        public void readInfo(){
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the AadharNo : ");
            AadharNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public void printInfo(){
            Console.WriteLine("Name : {0}\nAge : {1}\nHeight : {2}\nAadhar No : {3}",
            Name,Age,Height,AadharNo);
        }
    }
    public class Student:Person{
        private string usn;
        private double gpa;
        private static int noOfStudents=0;
        private static Regex validate = new Regex(@"^[0-9]{1}[a-zA-Z]{2}[0-9]{2}[a-zA-Z]{2}[0-9]{3}$");
        public Student():base(){
            noOfStudents++;
        }
        public int NoOfStudents{
            get{return noOfStudents;}
        }
        public string USN{
            get{return usn;}
            set{
                if(validate.IsMatch(value)){
                    this.usn = value;
                }else{
                    throw new ArgumentException("Not a valid USN.");
                }
            }
        }
        public double GPA{
            get{return gpa;}
            set{
                if(value<=10.0 && value>=0.0){
                    this.gpa=value;
                }
                else{
                    throw new ArgumentException("Invalid gpa score.");
                }
            }
        }
        new public void printInfo(){
            base.printInfo();
            Console.WriteLine("USN : {0}\nGPA : {1}",
            USN,GPA);
        }
        new public void readInfo(){
            base.readInfo();
            Console.WriteLine("Enter the USN : ");
            USN = Console.ReadLine();
            Console.WriteLine("Enter the GPA : ");
            GPA = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.readInfo();
            s.printInfo();
        }
    }
}