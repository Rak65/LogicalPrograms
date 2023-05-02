using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void PerfectNo()
        {
            Console.WriteLine("Enter the number : ");
            int num=Convert.ToInt32(Console.ReadLine());    //take input from the user

            int sum = 0;                                    //initialize sum is Zero
            for(int i=1; i<= num/2;  i++) 
            {
                if (num % i == 0)                    //check condition
                    sum = sum + i;                   //if number is divisible by i then add i
            }
            //check condition
            if (sum == num)       
                Console.WriteLine(num + " is Perfect number.");
            else
                Console.WriteLine(num + " is not Perfect number.");
        }
    }
}
