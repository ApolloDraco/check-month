/*
* This program prompts the user to enter their birth month and day.
* It then checks if the inputted month and day form a valid date.
* If the inputted date is valid, the program outputs a message indicating that it is a valid birthday.
* If the inputted date is invalid, the program outputs a message indicating that it is an invalid date.
*/

using System;

class CheckMonth
{
    static void Main()
    {
        int month, day;
        
        // Prompts the user to enter their birth month and day
        Console.Write("Please enter your month of birth (1-12): ");
        
        if (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month");
            return;
        }
        
        Console.Write("Please enter your day of birth: ");
        
        if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > DateTime.DaysInMonth(DateTime.Now.Year, month))
        {
            Console.WriteLine("Invalid day");
            return;
        }
        
        Console.WriteLine($"{month}/{day} is a valid birthday.");
    }
}
