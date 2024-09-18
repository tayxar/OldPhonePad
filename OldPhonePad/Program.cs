// See https://aka.ms/new-console-template for more information
using OldPhonePad;


Console.Write("Please enter number keys : "); String NumKey = Console.ReadLine();

if (Utility.IsInputValid(NumKey))
{
    Console.WriteLine("Answer is : " + Phone.OldPhonePad(NumKey));
}
else
{
    Console.WriteLine("Invalid Input");
}

Console.ReadKey();




