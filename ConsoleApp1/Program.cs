using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region OutPutInf
            //Console.WriteLine("A = {0}", a);
            //Console.WriteLine($"A = {a}");
            #endregion
            #region Input information
            //string str = Console.ReadLine();
            //int age = Convert.ToInt32(str);
            //Console.WriteLine($"Age = {age}");

            //double d = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(d);

            //int ab = int.Parse(Console.ReadLine());
            //Console.WriteLine(ab);
            //double d = Convert.ToDouble(Console.ReadLine());
            //int result = Convert.ToInt32(d);
            //Console.WriteLine($"Object type double {d} were convert to type int {result}");
            #endregion
            #region Convert type
            /*double d = 10.5;
            int ab = (int)d;

            int x = 8;
            double f = x;*/
            #endregion
            #region if switch


            //if (a>0) {
            //  Console.WriteLine("Positive");

            //};

            #endregion

            #region Exercise 1
            // Console.WriteLine(" It's easy to win forgiveness for being wrong; \n being right is what gets you into real trouble.\n Bjarne Stroustrup");
            // System.Threading.Thread.Sleep(500);
            #endregion
            #region Exercise 2
            /* Console.WriteLine("Input five numbers:");
             int a1 = Convert.ToInt32(Console.ReadLine());
             int a2 = Convert.ToInt32(Console.ReadLine());
             int a3 = Convert.ToInt32(Console.ReadLine());
             int a4 = Convert.ToInt32(Console.ReadLine());
             int a5 = Convert.ToInt32(Console.ReadLine());
             int sum = a1 + a2 + a3 + a4 + a5;
             int sum2 = a1 * a2 * a3 * a4 * a5;
             int numbermax=0;
             int numbermin = 0;
             if (a1 > a2)
             {
                 numbermax = a1;
                 numbermin = a2;
             }
             else { numbermax = a2; numbermin = a1;  };
             if (a1 > a3)
             {
                 numbermax = a1;
                 numbermin = a3;
             }
             else { numbermax = a3; numbermin = a1; };
             if (a1 > a4)
             {
                 numbermax = a1;
                 numbermin = a4;
             }
             else { numbermax = a4; numbermin = a1; };
             if (a1 > a5)
             {
                 numbermax = a1;
                 numbermin = a5;
             }
             else { numbermax = a5; numbermin = a1; };
             if (a2 > a3)
             {
                 numbermax = a2;
                 numbermin = a3;
             }
             else { numbermax = a3; numbermin = a2; };
             if (a2 > a4)
             {
                 numbermax = a2;
                 numbermin = a4;
             }
             else { numbermax = a4; numbermin = a2; };
             if (a2 > a5)
             {
                 numbermax = a2;
                 numbermin = a5;
             }
             else { numbermax = a5; numbermin = a2; };
             if (a3 > a4)
             {
                 numbermax = a3;
                 numbermin = a4;
             }
             else { numbermax = a4; numbermin = a3; };
             if (a3 > a5)
             {
                 numbermax = a3;
                 numbermin = a5;
             }
             else { numbermax = a5; numbermin = a3; };
             if (a4 > a5)
             {
                 numbermax = a4;
                 numbermin = a5;
             }
             else { numbermax = a5; numbermin = a4; };
             Console.WriteLine($"Max number : {numbermax} \nMin number : {numbermin}\nSumm:{sum}\nSumm*:{sum2}");
             Console.ReadKey();
            */

            #endregion
            #region Exercise 3
            /*int number = int.Parse(Console.ReadLine());
            int a1 = number % 10;
            int a2 = number / 10 % 10;
            int a3 = number / 100 % 10;
            int a4 = number / 1000 % 10;
            int a5 = number / 10000 % 10;
            int a6 = number / 100000 % 10;
            Console.WriteLine($"{a1}{a2}{a3}{a4}{a5}{a6}");
             Console.ReadKey();*/
            #endregion
            #region Exercise 4
            /*Console.WriteLine("Input numbers (first and second):");
           int a1 = Convert.ToInt32(Console.ReadLine());
           int a2 = Convert.ToInt32(Console.ReadLine());
           int proma3 = 0, proma4 = 1, finnub=0 ;
           for (; a1 <= a2; a1++)
           {
               Console.WriteLine($"{proma3}");
               proma3 += proma4;
               proma4 = proma3;


           };
           Console.ReadKey();*/
            #endregion
            #region Exercise 5
            /*int a = 1, b = 10;
            while (a <= b)
            {
                for (int i = 1; i <= a; i++)
                    Console.Write("{0}", a);
                a++;
                Console.WriteLine();
            }
            Console.ReadKey();*/
            #endregion
            #region Exercise 6
            Console.WriteLine("Input length sumbol:");
            int lon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input sumbol:");
            char chr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Vertical - 1 Horizontal: - 0");
            int checkbool = Convert.ToInt32(Console.ReadLine());
            switch (checkbool) {
                case 0:
                    for (int i = 0; i <= lon; i++)
                    {
                        Console.Write(chr);

                    };
                    break;

                case 1:
                    for (int i = 0; i <= lon; i++)
                    {
                        Console.Write($"{chr}\n");

                    };
                    break;

            }
             
            Console.ReadKey();
            #endregion

        }
    }
}
