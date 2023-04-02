using System;
using System.Text.RegularExpressions;
namespace App
{
    interface Person{
        string Name{get;set;}
        int Age{get;set;}
        double Height{get;set;}
        void printInfo();
        void setInfo();
    }
    public class Student :Person{
        private string name;
        private int age;
        private double height;
        private string usn;
        private double gpa;
        private static int noOfStudents=0;
        private static Regex validate = new Regex(@"^[0-9]{1}[a-zA-Z]{2}[0-9]{2}[a-zA-Z]{2}[0-9]{3}$");
        public Student(){noOfStudents++;}
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
        public string Name{
            get{return name;}
            set{name=value;}
        }
        public int Age{
            get{return age;}
            set{
                if(value>=16 && value<=30)
                    age=value;
                else
                {
                    throw new ArgumentException(@"Age is out of bounds {must be within 0-129}");
                }
            }
        }
        public double Height{
            get{return height;}
            set{
                if(value >=1.0 && value<=9.0)
                    height=value;
                else
                    throw new ArgumentException("Height must be within {1.0-8.0ft}");
            }
        }
        public void setInfo(){
            Console.WriteLine("Enter the name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the USN : ");
            USN = Console.ReadLine();
            Console.WriteLine("Enter the age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the GPA : ");
            GPA = Convert.ToDouble(Console.ReadLine());
        }
        public void printInfo(){
            Console.WriteLine("Name : {0}\nAge: {1}\nHeight : {2}\nUSN : {3}\nGPA : {4}",
            this.name,this.age,this.height,this.usn,this.gpa);
        }
    }
    public class Employee:Person{
        private string name;
        private int age;
        private double height;
        private string empID;
        private double salary;
        private static int noOfEmployees=0;
        private static Regex validate = new Regex(@"^[a-zA-Z]{3}[0-9]{5}$");

        public Employee(){noOfEmployees++;}
        public int NoOfEmployees{
            get{return noOfEmployees;}
        }
        public string Name{
            get{return this.name;}
            set{this.name = value;}
        }
        public int Age{
            get{return this.age;}
            set{
                if(value>=21 && value<=60){
                    this.age=value;
                }
                else{
                    throw new ArgumentException("Not a valid age.");
                }
            }
        }
        public double Height{
            get{return height;}
            set{
                if(value>=1.0&&value<=8.0){
                    this.height=value;
                }else{
                    throw new ArgumentException("Not a valid height.");
                }
            }
        }
        public string EmpID{
            get{return empID;}
            set{
                if(validate.IsMatch(value)){
                    this.empID=value;
                }else{
                    throw new ArgumentException("Not a valid Employee ID.");
                }
            }
        }
        public double Salary{
            get{return salary;}
            set{
                this.salary = value;
            }
        }
        public void setInfo(){
            Console.WriteLine("Enter the name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Employee ID : ");
            EmpID = Console.ReadLine();
            Console.WriteLine("Enter the age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void printInfo(){
            Console.WriteLine("Name : {0}\nAge: {1}\nHeight : {2}\nEmpID : {3}\nSalary : {4}",
            this.name,this.age,this.height,this.empID,this.salary);
        }
    }
    class Program{
        static void Main(string []args){
            Person s = new Student();
            Person p = new Employee();
            s.setInfo();
            p.setInfo();
            s.printInfo();
            p.printInfo();
        }
    }
}