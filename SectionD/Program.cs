using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Q1();
            //Program.Q2();
            //Program.Q3();
            Program.Q4();
        }
        static void Q1()
        {
            Console.WriteLine("Question 1:");
            int num = 0;
            while (num != 88)
            {
                Console.Write("input an integer:");
                String input = Console.ReadLine();
                num = Convert.ToInt32(input);
            }
            Console.WriteLine("Lucky you...");
        }
        static void Q2()
        {
            Console.WriteLine("Question 2:");
            int a;
            int b;
            int max;
            int min;
            int hcf;
            int lcm;
            int t;
            Console.Write("input A:");
            String input = Console.ReadLine();
            a = Convert.ToInt32(input);
            Console.Write("input B:");
            input = Console.ReadLine();
            b = Convert.ToInt32(input);
            max = Math.Max(a, b);
            min = a + b - max;
            do
            {
                max = max - min;
                if (max < min)
                {
                    t = min;
                    min = max;
                    max = t;
                }
                hcf = max;
                max = Math.Max(max, min);
            }
            while (max != min);
            lcm = a * b / hcf;
            Console.WriteLine("HCF:{0}", hcf);
            Console.WriteLine("LCM:{0}", lcm);
        }
        static void Q3()
        {
            Console.WriteLine("Question 3:");
            int rand;
            Random r = new Random();
            rand = r.Next(0, 10);
            int i = 0;
            int guess = 100;
            Console.WriteLine("Secret number:{0}", rand);
            while (guess != rand)
            {
                Console.Write("Guess a number:");
                String input = Console.ReadLine();
                guess = Convert.ToInt32(input);
                if (guess != rand)
                {
                    Console.WriteLine("Try again");
                }
                i++;
            }
            if (i <= 2)
            {
                Console.WriteLine("You are a Wizar!Guessing times:{0}", i);
            }
            else if (2 < i && i < 6)
            {
                Console.WriteLine("You are a good guess.Guessing times:{0}", i);
            }
            else
            {
                Console.WriteLine("You are lousy.Guessing times:{0}", i);
            }
        }
        static void Q4()
        {
            Console.WriteLine("Question 4:");
            Console.Write("Insert a number N:");
            string input = Console.ReadLine();
            double n = Convert.ToDouble(input);
            if (n == 0)
            {
                Console.WriteLine("Square root of N is:0.000");
            }
            else
            {
                double g;
                double dec;
                bool needToLoop = true;
                Random rand = new Random();
                g = rand.Next(1, (Int32)n);
                Console.WriteLine("Guess number:{0}", g);
                if (g * g == n)
                {
                    needToLoop = false;
                }
                while (needToLoop)
                {

                    g = (g + n / g) / 2;
                    dec = n - g * g;
                    if (dec <= 0.00001 && -0.00001 <= dec)
                    {
                        needToLoop = false;
                    }

                }
                Console.WriteLine("Square root of N is:{0:0.000}", g);

            }
        }
    }
}
