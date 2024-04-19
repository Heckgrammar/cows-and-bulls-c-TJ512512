using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cows_and_bulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = 0;
            int TestingNumber = 0;
            int TestingNumber2 = 0;
            // Console.WriteLine(TestingNumber);
            // Console.WriteLine(number);
            int NumOfDuplicates = 5;
            while (NumOfDuplicates > 4)
            {
                NumOfDuplicates = 0;
                 number = rand.Next(1000, 10000);
                Console.WriteLine(number);
                for (int i = 0; i < 4; i++)
                {
                    TestingNumber = Convert.ToInt32(number.ToString().Substring(i, 1));
                    // Console.WriteLine(TestingNumber);
                    for (int j = 0; j < 4; j++)
                    {
                        TestingNumber2 = Convert.ToInt32(number.ToString().Substring(j, 1));
                        // Console.WriteLine(TestingNumber2);
                        if (TestingNumber == TestingNumber2)
                        {
                            NumOfDuplicates++;
                            // Console.WriteLine(NumOfDuplicates);
                        }
                    }
                }
            }

            bool NumberFound = false;
            int guesses = 0;
            NumOfDuplicates = 5;
            int NumGuessed = 0;
            int cows = 0;
            int bulls = 0;
            while (NumberFound == false)
                {
                cows = 0;
                bulls = 0;
                guesses++;
                while (NumOfDuplicates > 4)
                {
                    NumOfDuplicates = 0;
                    Console.WriteLine("Guess a 4 digit number with no repeating digits");
                    NumGuessed = Convert.ToInt32((Console.ReadLine()));
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    for (int i = 0; i < 4; i++)
                    {
                        TestingNumber = Convert.ToInt32(NumGuessed.ToString().Substring(i, 1));
                        // Console.WriteLine(TestingNumber);
                        for (int j = 0; j < 4; j++)
                        {
                            TestingNumber2 = Convert.ToInt32(NumGuessed.ToString().Substring(j, 1));
                            // Console.WriteLine(TestingNumber2);
                            if (TestingNumber == TestingNumber2)
                            {
                                NumOfDuplicates++;
                                // Console.WriteLine(NumOfDuplicates);
                            }
                        }
                    }
                }
                NumOfDuplicates = 0;
                for (int i = 0;i < 4;i++)
                {
                    TestingNumber = Convert.ToInt32(number.ToString().Substring(i, 1));
                    NumOfDuplicates = 0;
                    for (int j = 0;j < 4;j++)
                    {
                        TestingNumber2 = Convert.ToInt32(NumGuessed.ToString().Substring(j, 1));
                        if (TestingNumber == TestingNumber2)
                        {
                            cows++;
                            // Console.WriteLine(NumOfDuplicates);
                        }
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    TestingNumber = Convert.ToInt32(NumGuessed.ToString().Substring(i, 1));
                    TestingNumber2 = Convert.ToInt32(number.ToString().Substring(i, 1));
                    if (TestingNumber == TestingNumber2)
                    {
                        cows--;
                        bulls++;
                    }
                }
                Console.WriteLine(cows + " cows");
                Console.WriteLine(bulls + " bulls");
                if (bulls == 4)
                {
                    NumberFound = true;
                }
                NumOfDuplicates = 5;
            }
            if (guesses == 1)

            {
                Console.WriteLine("Well done! you did it in " + guesses + " try!");
            }
            else
            {
                Console.WriteLine("Well done! you did it in " + guesses + " tries!");
            }

        }
    }
}
