using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void ReverseNo()
        {
            Console.WriteLine("Enter the number : ");
            int num =Convert.ToInt32(Console.ReadLine());     //take input from the user

            int reverse = 0;                //Initialize revese=0

            //condition for reverse
            while (num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is " + reverse);  //Print Reverse number
        }
    }
}
