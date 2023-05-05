using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumber
    {
        public static void Coupon()
        {
            Console.Write("Enter the number of coupons to generate: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] coupons = GenerateCoupons(n);
            Console.WriteLine("The generated coupons are:");
            foreach (string coupon in coupons)
            {
                Console.WriteLine(coupon);
            }
        }

        static string[] GenerateCoupons(int n)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int codeLength = 10;

            string[] coupons = new string[n];

            for (int i = 0; i < n; i++)
            {
                string coupon = " ";
                for (int j = 0; j < codeLength; j++)
                {
                    coupon += alphabet[new Random().Next(alphabet.Length)];
                }
                coupons[i] = coupon;
            }

            return coupons;
        }
    }

}
