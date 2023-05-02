using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void PrimeNo()
        {
            Console.WriteLine("Enter the number : ");
            int num=Convert.ToInt32(Console.ReadLine());     //take input from the user

            if (num >= 2)                                  //check condition
            {
                int i = 2, count = 0;                      //initialize i=0 and count =0
                while ((num / 2) >= i)
                {
                    if (num % i == 0)                     //check condition 
                    {
                        count++;                         //if number is divisible by i then count will increase one
                    }
                    i++;
                }
                if (count == 0)                        //check condition
                    Console.WriteLine(num + " is Prime Number.");
                else
                    Console.WriteLine(num + " is not Prime Number");
            }
            else
            Console.WriteLine(num + " is not a Prime number.");
        }
    }
}
