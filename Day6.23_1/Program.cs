using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6._23_1
{

    class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
    }
    class Shape
    {
        public virtual void drow()
        {
            Console.WriteLine("Drow a shape");
        }
       
    }
    class circle : Shape
    {
        public override void drow() {
            Console.WriteLine("drow a circle");
        }

    }

    class Rectangle : Shape
    {
        public override void drow()
        {
            Console.WriteLine("drow a Rectangle");
        }

    }

    abstract class Animal
    {
        public abstract void makeSound();
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }


    }
    class dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
    class cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    interface Playable
    {
         void play();
    }

    class Guitar : Playable
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar");
        }
    }
    class Piano : Playable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano");
        }
    }



    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(1, 2);
            calc.Add(1, 2, 3);
            calc.Add(1.2, 2.3);
            Shape s1=new circle();
            Shape s2 = new Rectangle();
            s1.drow();
            s2.drow();
            dog d1= new dog();
            d1.makeSound();
            cat c1 = new cat();
            c1.makeSound();
            Guitar g1 = new Guitar();
            Piano p1 = new Piano();
            g1.play();
            p1.play();
        }
    }
}
