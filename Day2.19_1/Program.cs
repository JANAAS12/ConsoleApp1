using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2._19_1
{
    internal class Program
    {
        static double FromKilo(double num)
        {
            double result = num * 0.621371;
            return result; 
        }

        static int Minuts(int h,int m)
        {
            int result = h * 60 + m;
            return result;

        }
        static void HourseandMinuts(int m)
        {
            int hours = m / 60; 
            int minutes = m % 60;
            Console.WriteLine(hours + " Hourse " + minutes + " Minutes ");
            
        }
        static void Comparasion(int x,int y)
        {
            string result = x > y ? " grater " : x < y ? "smaller " : "Equal ";
            Console.WriteLine(result);

            
        }

        static void Divisible(int x, int y)
        {
            if (x % y == 0)
                Console.WriteLine("Divisible");
            else
                Console.WriteLine("Not Divisible");

        }

        static void middle(int x,int y,int z)
        {
            if (x > y && x < z || x < y && x > z)
                Console.WriteLine(x);
            else if (y > x && y < z || y < x && y > z)
                Console.WriteLine(y);
            else
                Console.WriteLine(z);
        }
        static void summition(int x)
        {
            Console.WriteLine("Enter a number");
            int sumition = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sumition > 0)
            {
                sum = sum + sumition % 10;
                sumition = sumition / 10;

            }
            Console.WriteLine("The Sum of digit is " + sum);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter Double Number ");

             double x= double.Parse(Console.ReadLine());
            int y=(int)x;
            Console.WriteLine("Double" + x);
            Console.WriteLine("Converted Int:"+ y);

            /////////////////
            int num = 25;
            Console.WriteLine("Your number is: " + num.ToString());
            //////////////
            Console.WriteLine("Enter A String ");
            string s=Console.ReadLine();
            Console.WriteLine("To UpperCase: " + s.ToUpper());
            Console.WriteLine("To LowerCase: " + s.ToLower());

            /////////////
            Console.WriteLine("Enter Full Name");
            string FullName = Console.ReadLine();
            
            int FnameIndex = FullName.IndexOf(' ');
            string Fname = FullName.Substring(0, FnameIndex);
            string Lname = FullName.Substring(FnameIndex);
            Console.WriteLine("FirstName: " + Fname);
            Console.WriteLine("LastName: " + Lname);
            Console.WriteLine("Total character : " + FullName.Length);
            //////////////
            Console.WriteLine("Enter 2 numbers");
            int num11 = int.Parse(Console.ReadLine());
            int num22 = int.Parse(Console.ReadLine());
            if (num11 > num22)
                Console.WriteLine(num22);
            if(num22 > num11)
                Console.WriteLine(num11);
            /////////////////
            Console.WriteLine("The Result Of Convert is " + FromKilo(15)+" mph ");
            /////////////////
            Console.WriteLine(Minuts(5, 37));
            ////////////
            HourseandMinuts(546);
            //////////
            Comparasion(10,20);
            ////////////
            summition(123);
            ///////////////
            Console.WriteLine("Enter at least four digit");
            int digit = int.Parse(Console.ReadLine());
            int d,reverseum=0;
            while (digit > 0) { 

                d = digit % 10;
                reverseum = reverseum * 10+d;
                digit = digit / 10;

            }
            Console.WriteLine(reverseum);
            //////////
            Divisible(25, 5);
            ////////////
            middle(7,6,8);

        }
        
    }
    }

