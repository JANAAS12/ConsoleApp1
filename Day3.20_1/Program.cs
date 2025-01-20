﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3._20_1
{
    internal class Program
    {


        public class Room
        {
            public int roomNumber;
            public string roomType;
            public double price;
            public bool isBooked;
            public const string hotelName = "Grand Stay Hotel";

            
        }

        public static void IsOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("The number " + x + " is even");
            }
            else
            {
                Console.WriteLine("The number " + x + " is odd");
            }
        }

        public static void secondsmal(int a, int b, int c, int d, int e)
        {
            int s = a;
            int[] arr = { a, b, c, d, e };
            Array.Sort(arr);

            Console.WriteLine(arr[1]);
        }
        public static void factorial(int x)
        {
            int f = 1;
            for (int i = x; i > 0; i--)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }

        public static void Prime(int x, int y)
        {
            
            for (int i = x; i <= y; i++)
            {
                bool f = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                        break;

                    }
                    
                }
                if (f==true)
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        public static void Maximum(int[] arr)
        {
            int max = arr[0];
            foreach(int i in arr)
            {
                if (i > max)
                    max = i;
            }
            Console.WriteLine(max);
        }

        public static void Tri()
        {
            int z = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                   
                    Console.Write(z+" ");
                    z++;

                }
                Console.WriteLine();

            }
        }

        static void Main(string[] args)
            {

                IsOdd(4);
                secondsmal(4, -3, 7, 2, 0);
                Console.WriteLine("enter a number to find factorial");
                int num = int.Parse(Console.ReadLine());
                factorial(num);
                Prime(10, 30);
                int[] arr = { 3, 1, 4, 1, 5, 9 };
                Maximum(arr);
                Tri();

            Room r1 = new Room();
            r1.roomNumber = int.Parse(Console.ReadLine());
            r1.roomType = Console.ReadLine();
            r1.price = double.Parse(Console.ReadLine());
            r1.isBooked = bool.Parse(Console.ReadLine());
            Console.WriteLine("Number of room 1 is : " + r1.roomNumber + " Room 1 type is : " + r1.roomType + " Room 1 Price is : " + r1.price + " Room 1 is booked :" + r1.isBooked);

            Room r2 = new Room();
            r2.roomNumber = int.Parse(Console.ReadLine());
            r2.roomType = Console.ReadLine();
            r2.price = double.Parse(Console.ReadLine());
            r2.isBooked = bool.Parse(Console.ReadLine());
            Console.WriteLine("Number of room 2 is : " + r2.roomNumber + " Room 2 type is : " + r2.roomType + " Room 2 Price is : " + r2.price + " Room 2 is booked :" + r2.isBooked);






        }
    }
    
}
