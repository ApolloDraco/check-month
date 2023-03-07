using static System.Console;
using System;

class CheckMonth
{
static void Main()
{
int month, day;
//Prompts a user to enter a birth month and day.
Console.Write("Please enter your month of birth: ");
month = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your day of birth: ");
day = Convert.ToInt32(Console.ReadLine());
//Display an error message if the month is invalid (not 1 through 12)
//or the day is invalid for the month
//If the month and day are valid, display them with a message.
if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
if(day <= 31 && day >= 1)
Console.WriteLine(month+"/"+day+" is a valid birthday.");
else
Console.WriteLine("Invalid date");
else if(month == 4 || month == 6 || month == 9 || month == 11)
if(day <= 30 && day >= 1)
Console.WriteLine(month+"/"+day+" is a valid birthday.");
else
Console.WriteLine("Invalid date");
else if(month == 2)
if(day <= 29 && day >= 1)
Console.WriteLine(month+"/"+day+" is a valid birthday.");
else
Console.WriteLine("Invalid date");
else
Console.WriteLine("Invalid date");

}
}
