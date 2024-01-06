using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate and print the average from 1 to the number entered from the console (including the entered number).
            // Uncomment the following lines if you want to use this block of code.
            // Console.WriteLine("Please enter a number:");
            // int number = int.Parse(Console.ReadLine());
            // int counter = 1;
            // int sum = 0;
            // while (counter <= number)
            // {
            //     sum += counter;
            //     counter++;
            // }
            // Console.WriteLine(sum / (double)counter);

            // Count the number of digits in the entered number.
            Console.WriteLine("Please enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int digitCount = 0;
            while (number1 > 0)
            {
                digitCount++;
                number1 = number1 / 10;
            }
            Console.WriteLine("The entered number has " + digitCount.ToString() + " digits.");

            // Using foreach to iterate through an array of car names.
            Console.Write("***Foreach***");
            string[] cars = { "Nissan", "Bmw", "Toyota", "Lexus" };
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
