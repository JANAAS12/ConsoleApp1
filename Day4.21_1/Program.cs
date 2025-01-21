using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4._21_1
{
    internal class Program
    {

        public class Student
        {
            private string name; //field
            private int age; //field
            private int studentId; //field
            public const int MinAge= 18; //constant
            public const int MaxAge= 20; //constant

            public string Name    //property for name
            {
                get {  return name; }
                set { name = value; }
            }

            public int Age //property for age
            {
                get { return age; }
                set { age = value; }
            }
            public int StudentId {  //property for Id
            
            get { return studentId; }
            set { studentId = value; }

            }
            public string email {  get; set; }  //auto property for email


            public Student()    // constractor without parameters
            {
                name = "";
                age = 0;
                studentId = 0;
            }

            public Student(string name,int age,int Id)  // constractor with parameters
            {
                this.name = name;
                this.age = age;
                this.studentId = Id;
            }
            public void GetDetails()   //method to get details
            {
                Console.WriteLine("Student Name is "+name+" Age : "+age+" Id : "+ studentId );
            }
            ~Student() //destructor
            {
                Console.WriteLine("The object is destroyed");
            }

            static void Main(string[] args)
            {
                Student s = new Student(); //crate object
                s.Name= "Ahmad"; //set name by property
                s.Age = 22; //set age by property
                s.StudentId = 100; //set Id by property
                s.GetDetails(); //get details for obj1
                Student s1 = new Student("Jana", 22, 612); //create object with parameters
                Student s2 = new Student("Rama", 24, 150); //create object with parameters
                s1.GetDetails(); //get details for obj2
                s2.GetDetails(); //get details for obj3

                //What is class? its a template for objects 
                //what is object? its an instance of class
                //Differens between class and object? class is a template for objects and object is an instance of class
                //Mention the OOP principles? Encapsulation, Inheritance, Polymorphism, Abstraction
                //What is property? its a method that provides a flexible mechanism to read or write value of a private field
                //Whta is feild? its a variable that ,that we can modify its value and call it by obj.fieldname
                //what is constructor? its a method that called when we create an object of class used to initialize the object
                //what is destructor? its a method that called when the object is destroyed 


            }

        }
    }
}
