// See https://aka.ms/new-console-template for more information
using OldPhonePad;

Console.WriteLine("--- Key Pad Phone System ---");
Console.WriteLine("--- (Please Enter 'x' to exist from system!) ---");
Console.WriteLine();
Console.Write("Please enter number keys : "); String Input = Console.ReadLine();


while(Input != "x") { 

if (Utility.IsInputValid(Input))
{
    Console.WriteLine("Answer is : " + Phone.OldPhonePad(Input));
}
else
{
    Console.WriteLine("Invalid Input");
}

    Console.Write("Please enter number keys : "); Input = Console.ReadLine();
}




