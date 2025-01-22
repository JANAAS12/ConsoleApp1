using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5._22_1
{

    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Start() {
            Console.WriteLine("Vehicle is starting");
        
        }



    }
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }


        public void print()
        {
            Console.WriteLine("Car Brand : " + Brand + " Model : " + Model + " Nomber of doors "+NumberOfDoors);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Car c = new Car();
                c.Brand = "Ford";
                c.Model = " ";
                c.NumberOfDoors = 4;
                c.print();
                c.Start();
                Vehicle v=new Vehicle();


            /////////
            //What is constructor? its a method that called when we create an object of class used to initialize the object
            //What are the basic concepts of OOPs? Encapsulation, Inheritance, Polymorphism, Abstraction
            //What is the Encapsulation? Encapsulation is the bundling of data with the methods that operate on that data, or the restricting of direct access to some of an object's components.
            //What is the sealed class?used to restrict the users from inheriting the class . No class can be derived from a sealed class.
            //What is the Inheritance concept ? Inheritance is a mechanism in which one class acquires the property of another class.





        }
    }
}
