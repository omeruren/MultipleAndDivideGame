using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleAndDivideGame
{
    class Program
    {
        //  take string value from user
        static string Value()
        {

            string text = Console.ReadLine();
            return text;
        }

        // check number is digit or not
        static bool IsDigits(string text)
        {
            return text.All(char.IsDigit);
        }

        // Diving function without Divide and Mod Operator
        static void Dividing()
        {
            //10 / 2 = 10-2=8 8-2=6 6-4=4 4-2=2 2-2=0
            // 10 / 3 = 10-3=7 7-3
            int divisor = 0, number1 = 0, number2 = 0;
            int temp1 = 0, temp2 = 0;

            while (true)
            {
                while (true)
                {
                    TwoTab("\n Enter the first number :");
                    string num1 = Value();
                    if (IsDigits(num1))
                    {
                        number1 = int.Parse(num1);
                        break;
                    }
                    else
                    {
                        TwoTab("Please enter a number");
                    }
                }

                while (true)
                {

                    TwoTab("\n Enter the second number :");
                    string num2 = Value();
                    if (IsDigits(num2))
                    {
                        number2 = int.Parse(num2);
                        break;
                    }
                    else
                    {
                        TwoTab("Please enter a number");

                    }
                }

                temp1 = number1;
                temp2 = number2;

                if (number2 != 0)
                {
                    if (number1 >= number2)
                    {
                        do
                        {

                            TwoTab1($"{temp1}-{temp2} = {temp1 -= temp2}");
                            divisor++;

                        } while (temp1 >= temp2);
                        break;
                    }
                    else
                    {

                        TwoTab($"{temp1} / {temp2} = {String.Format("{0:0.00}", (double)temp1 / temp2)}");
                        break;
                    }
                }
                else
                {
                    TwoTab1("Second number is can not be 0\n");
                }
            }

            Align($"{number1} / {number2} = {divisor} remainder is {temp1}");

        }

        // Multiple Function without multiple operator
        static void Multiplying()
        {
            //10 x 5 = 10+10+10+10+10
            int temp1 = 0, number1 = 0, number2 = 0;
            while (true)
            {
                TwoTab("\n Enter the first number :");
                string num1 = Value();
                if (IsDigits(num1))
                {
                    number1 = int.Parse(num1);
                    break;
                }
                else
                {
                    TwoTab("Please enter a number");
                }

            }
            while (true)
            {

                TwoTab("\n Enter the second number :");
                string num2 = Value();
                if (IsDigits(num2))
                {
                    number2 = int.Parse(num2);
                    break;
                }
                else
                {
                    TwoTab("Please enter a number");

                }
            }

            temp1 = number1;
            for (int i = 0; i < number2 - 1; i++)
            {
                TwoTab1($"{temp1} + {number1} = {temp1 += number1}");

            }

            Align($"{number1} x {number2} = {temp1} ");
        }

        static void Align(string text)
        {

            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        static void TwoTab(string text)
        {
            Console.Write($"\t\t{text}");
        }

        static void TwoTab1(string text)
        {
            Console.WriteLine($"\n\t\t{text}");
        }

        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Align("WELCOME TO DIVISON & MULTIPLYING GAME\n");
            Align("IN THIS GAME WE ARE TEACHING HOW DIVISON AND MULTIPLYING WORKS \n");

            while (true)
            {

                Align("For Contuniue game press C Key on Keyboard");
                Align("For Quit game press Q Key on Keyboard\n");
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.C)
                {
                    Align("----- MENU -----");
                    Align("1 : Multiplying ");
                    Align("2 : Dividing ");
                    Align("-----      -----");


                choosing:
                    TwoTab("\nChoose a Selection : ");
                    int choosing = Convert.ToInt32(Console.ReadLine());

                    switch (choosing)
                    {
                        case 1:
                            Align("YOU SELECTED THE MULTIPLYING");
                            Multiplying();
                            break;

                        case 2:
                            Align("YOU SELECTED THE DIVIDIING");
                            Dividing();
                            break;

                        default:
                            Align("Please Choose a correct Selection\n");
                            goto choosing;

                    }

                }
                else if (key.Key == ConsoleKey.Q)
                {
                    TwoTab("Quitting the Game Good Bye :(");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);

                }
            }
        }
    }
}
