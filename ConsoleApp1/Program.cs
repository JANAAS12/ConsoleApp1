using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter String ");
            str1 =Console.ReadLine();
            Console.WriteLine(str1);
            ///////////////////
            int x = 5;
            Console.WriteLine(x);
            double y = 5.66;
            Console.WriteLine(y);
            string st = "Hello Wold";
            Console.WriteLine(st);
            char c = 'J';
            Console.WriteLine(c);
            bool b = true;
            Console.WriteLine(b);
            const int num= 12;
            Console.WriteLine(num);
            /////////////////////

            string[] car = { "Tesla","Ford","Honda"};
            for(int i=0;i<3;i++)
                Console.WriteLine(car[i]);
            Console.WriteLine(car.Length);

            //////////
            Console.WriteLine("Enter a FirstName");
            string FN=Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string LN = Console.ReadLine();
            Console.WriteLine("Enter Year Of Birth");
            int Birth = int.Parse(Console.ReadLine());
            Console.WriteLine(FN + " " + LN + " " + Birth);
            ////////////
            int[] array = new int[10];
            Console.WriteLine("Enter 10 element ");
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

               
            }
            Console.WriteLine("Element in array are :");
            for (int i = 0; i < array.Length; i++)
            {
                
                Console.WriteLine("element " + i + " : " + array[i]);
            }

        }
    }
}
