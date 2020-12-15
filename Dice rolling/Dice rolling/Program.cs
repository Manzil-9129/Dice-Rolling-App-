using System;

namespace Dice_rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Random ernd = new Random();
            int[] die1array = { 1, 2, 3, 4, 5, 6 };
            int[] die2array = { 1, 2, 3, 4, 5, 6 };
            int[] sum = new int[13];

            for (int index = 1; index <= 36000; index++)
            {
                int die1;
                die1 = rnd.Next(1, 7);

                int die2;
                die2 = rnd.Next(1, 7);

                int sum1;
                sum1 = die1 + die2;
                int counter = 0;



                if (sum1 == 2)
                {
                    sum[0] = sum[0] + 1;
                }


                if (sum1 == 3)
                {

                    sum[1] = sum[1] + 1;
                }

                if (sum1 == 4)
                {
                    sum[2] = sum[2] + 1;
                }
                if (sum1 == 5)
                {
                    sum[3] = sum[3] + 1;
                }
                if (sum1 == 6)
                {
                    sum[4] = sum[4] + 1;
                }
                if (sum1 == 7)
                {
                    sum[5] = sum[5] + 1;
                }
                if (sum1 == 8)
                {
                    sum[6] = sum[6] + 1;
                }
                if (sum1 == 9)
                {
                    sum[7] = sum[7] + 1;
                }
                if (sum1 == 10)
                {
                    sum[8] = sum[8] + 1;
                }
                if (sum1 == 11)
                {
                    sum[9] = sum[9] + 1;
                }
                if (sum1 == 12)
                {
                    sum[10] = sum[10] + 1;
                }

            }
            Console.WriteLine("The sum of 2 will appear for = "+sum[0]);
            Console.WriteLine("The sum of 3 will appear for = " + sum[1]);
            Console.WriteLine("The sum of 4 will appear for = " + sum[2]);
            Console.WriteLine("The sum of 5 will appear for = " + sum[3]);
            Console.WriteLine("The sum of 6 will appear for = " + sum[4]);
            Console.WriteLine("The sum of 7 will appear for = " + sum[5]);
            Console.WriteLine("The sum of 8 will appear for = " + sum[6]);
            Console.WriteLine("The sum of 9 will appear for = " + sum[7]);
            Console.WriteLine("The sum of 10 will appear for = " + sum[8]);
            Console.WriteLine("The sum of 11 will appear for = " + sum[9]);
            Console.WriteLine("The sum of 12 will appear for = " + sum[10]);
           
            Console.ReadKey();
            Console.Clear();
        }

    }
}
