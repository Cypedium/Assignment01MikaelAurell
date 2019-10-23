using System;

namespace Assignment01MikaelAurell
{{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = AskUserFor("first name");
            //string lastName = AskUserFor("last name");
            //int age = AskUserForNumber("age");

            Console.WriteLine($"Your full name is {firstName} {lastName} and you are {age} years old");

            double result = 7.4 * AskUserForNumber();

            Console.WriteLine("7.4 * your munber is: " + result);


            char aLetter = 'a';

            Console.WriteLine(aLetter + 1);
            Console.WriteLine(aLetter + "1");
        }

        static string AskUserFor(string forWhat)
        {
            Console.Write($"Pleace input {forWhat}: ");
            return Console.ReadLine();
        }

        static int AskUserForNumber(string forWhat)
        {
            return int.Parse(AskUserFor(forWhat));
        }

        static double AskUserForNumber() //Overload
        {
            return double.Parse(AskUserFor("decimal number"));
        }
    }
}