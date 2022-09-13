// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Sum of 1, 3, and 5: " + Methods.Add(1, 3, 5));
Console.WriteLine("100 minus 5 and minus 70: " + Methods.Subtract(100, 5, 70));
Console.WriteLine("5 multiplied four times: " + Methods.Multiply(5, 5, 5, 5));
Console.WriteLine("100 divided by 5, and then by 4: " + Methods.Divide(100, 5, 4));
Console.WriteLine("The modulus of 57 divided by 17. That number, divided by 5; the modulus of that: " + Methods.Modulus(57, 17, 5));
Console.ReadLine();