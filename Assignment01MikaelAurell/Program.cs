using System;

namespace Assignment01MikaelAurell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator.");
            double number = AskUserForNumber("a number");

            bool keepAlive2 = true;
            while (keepAlive2)
            {
                try
                {

                    Console.WriteLine($"{number}");

                    Console.Write("Press x for Exit and c for Clear. Choose +, -, * or /.");
                    char selectionNumber = char.Parse(Console.ReadLine() ?? "");


                    switch (selectionNumber)
                    {
                        case '+':
                            number = CalcAddition(number);
                            break;
                        case '-':
                            number = CalcSubtration(number);
                            break;
                        case '*':
                            number = CalcMultiplikation(number);
                            break;
                        case '/':
                            number = CalcDived(number);
                            break;
                        case 'c':
                            number = 0;
                            break;
                        case 'x':
                            keepAlive2 = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                    Console.WriteLine(e);
                }

                Console.ResetColor();
                Console.Clear();
            }
        }    
            static double CalcAddition(double number)
            {
                double newnumber = AskUserForNumber("a number");
                newnumber= number + newnumber;
                return newnumber;
            }
            static double CalcSubtration(double number)
            {
                double newnumber = AskUserForNumber("a number");
                newnumber = number - newnumber;
                return newnumber;
            }
            static double CalcMultiplikation(double number)
            {
                double newnumber = AskUserForNumber("a number");
                newnumber = number * newnumber;
                return newnumber;
            }
            static double CalcDived(double number)
            {
                double newNumber = AskUserForNumber("a number");
                if (newNumber != 0)
                {
                    newNumber = number / newNumber;
                    return newNumber;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't dived by 0");
                    Console.ResetColor();
                    Console.WriteLine("Press a button to continue.");
                    Console.ReadKey(true);
                    return number;
                }
            }
            static string AskUserFor(string forWhat)
            {
                 Console.Write($"Please input {forWhat}: ");
                 return Console.ReadLine();
            }
            static double AskUserForNumber(string forWhat)
            {
                return double.Parse(AskUserFor(forWhat));
            }
    }
}