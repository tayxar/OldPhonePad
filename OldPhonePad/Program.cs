// See https://aka.ms/new-console-template for more information
using OldPhonePad;


//Testing result as per Questions in PDF
Console.WriteLine(Phone.OldPhonePad("33#"));
Console.WriteLine(Phone.OldPhonePad("227*#"));
Console.WriteLine(Phone.OldPhonePad("4433555 555666#"));
Console.WriteLine(Phone.OldPhonePad("8 88777444666*664#"));
Console.WriteLine(Phone.OldPhonePad("444026082999099992777 0 944466#"));
Console.WriteLine(Phone.OldPhonePad("844266550 99966688 0 333666 7770 222666 6677774443 33 7774446640633#"));
Console.WriteLine();
//For more testing in console
Console.Write("Please enter number keys : ");

// Read input string
String NumKey = Console.ReadLine();

// check the string inputted is in correct format & provide answer by OldPhonePad method from Phone class
if (checkNumber(NumKey)) {

   Console.WriteLine("Answer is : " + Phone.OldPhonePad(NumKey));

}
Console.ReadKey();


//Method to check Input String is valid
static bool checkNumber(string input) {

    bool result = false;
    //remove the #
    string modifiedString = input.Replace("#", "");
    //remove the space
    modifiedString = modifiedString.Replace(" ", "");
    //remove the *
    string modifiedInput = modifiedString.Replace("*", ""); 

    //checking modified input is number or not (double is used because the number may very large)
    if (double.TryParse(modifiedInput, out double number))
    {
        
        result = true;
    }
    else
    {
        Console.WriteLine($"{input} is not a valid input.");
     
    }

    return result;
}

