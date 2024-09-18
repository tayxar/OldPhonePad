using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OldPhonePad
{
    public static class Utility
    {
           

        public static Hashtable InitializeKeyPad() {

            Hashtable KeyPad = new Hashtable();
            KeyPad.Add('1', new List<string> { "&", "\'", "(" });
            KeyPad.Add('2', new List<string> { "A", "B", "C" });
            KeyPad.Add('3', new List<string> { "D", "E", "F" });
            KeyPad.Add('4', new List<string> { "G", "H", "I" });
            KeyPad.Add('5', new List<string> { "J", "K", "L" });
            KeyPad.Add('6', new List<string> { "M", "N", "O" });
            KeyPad.Add('7', new List<string> { "P", "Q", "R", "S" });
            KeyPad.Add('8', new List<string> { "T", "U", "V" });
            KeyPad.Add('9', new List<string> { "W", "X", "Y", "Z" });
            KeyPad.Add('0', new List<string> { "_" });
            KeyPad.Add('*', new List<string> { "backSpace" });
            KeyPad.Add('#', new List<string> { "send" });

            return KeyPad;

        }

     
        public static bool IsInputValid(string input)
        {

            bool result = false;
            //remove the #
            input = input.Replace("#", "");
            //remove the space
            input = input.Replace(" ", "");
            //remove the *
            input = input.Replace("*", "");

            //checking modified input is number or not (double is used because the number may very large)
            if (double.TryParse(input, out double number))
                 result = true;
            
            return result;
        }

        public static List<String> ReturnMatchCharList(string[] inputArray)
        {
            List<string> resultList = new List<string>();

            // Regular expression to match consecutive characters
            Regex regex = new Regex("(.)\\1*");

            // Process each string in the input array
            foreach (string item in inputArray)
            {
                // Find matches and add them to the result list
                var matches = regex.Matches(item).Cast<Match>().Select(m => m.Value);
                resultList.AddRange(matches);
            }

            return resultList;

        }



        // Translate to Alphabet depends on number of times
        public static string TranslateWithClickTimes(char key, Hashtable keypad, char[] cArray)
        {
            string result = "";

            if (keypad.ContainsKey(key))
            {
                List<string> KeyList = (List<string>)keypad[key];

                int index = cArray.Length - 1;

                // if user clicks are more than keypad's values 
                if (cArray.Length > KeyList.Count)
                {
                    //if character are 7,9 (because 7 & 9 has 4 character)
                    if (key == '7' || key == '9')
                    {
                        index = (cArray.Length % 4) - 1;
                    }
                    else
                    {
                        index = (cArray.Length % 3) - 1;
                    }
                }

                result = KeyList[index];

            }
            return result;
            
            
        }
    }
}
