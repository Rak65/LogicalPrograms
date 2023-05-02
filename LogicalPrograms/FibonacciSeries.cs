using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            Console.WriteLine("Enter the range of Fibonacci Series."); //take range from the user
            int range = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");

            for (int i = 2; i < range; i++)
            {
                int num3 = num1 + num2;       //Add previous no and current number
                Console.Write(num3 + " ");
                num1 = num2;                  //take next position number
                num2 = num3;                  //take next position number
            }
        }
    }
}
