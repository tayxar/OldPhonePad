using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OldPhonePad
{
    public class Phone
    {
       
       public static String OldPhonePad(string input)
        {
            // declaring the result string variable
            String result = "";

            // Setting up hashtable for key and values pair
            Hashtable KeyPad = new Hashtable();
            KeyPad.Add('1', new List<string> { "&", "\'", "(" });
            KeyPad.Add('2', new List<string> { "A", "B", "C" });
            KeyPad.Add('3', new List<string> { "D", "E", "F" });
            KeyPad.Add('4', new List<string> { "G", "H", "I" });
            KeyPad.Add('5', new List<string> { "J", "K", "L" });
            KeyPad.Add('6', new List<string> { "M", "N", "O" });
            KeyPad.Add('7', new List<string> { "P", "Q", "R","S" });
            KeyPad.Add('8', new List<string> { "T", "U", "V" });
            KeyPad.Add('9', new List<string> { "W", "X", "Y","Z" });
            KeyPad.Add('0', new List<string> { "_" });
            KeyPad.Add('*', new List<string> { "backSpace" });
            KeyPad.Add('#', new List<string> { "send" });


            // split the input into array with space (" ")
            string[] ModifiedInput = Regex.Split(input, "( )");
            
            // split the modifiedInput into Array of same char : Example => {"33344"," ","55"} to {"333","44"," ","55"}
            string[] keys = separatebySameCharacter(ModifiedInput);

            // Nested Loop is used to filter and build the alphabet
            foreach (string key in keys) {

                // split each string in keys into char (Logically {"333"} will become {'3','3','3'})
                char[] charArray = key.ToCharArray();
                
                string tempKey= "";
                foreach (char c in charArray) {

                    switch (c) {

                        case '1':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;


                        case '2':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '3':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '4':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '5':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '6':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '7':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '8':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '9':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '0':
                            tempKey = SearchHashTableWithKey(c, KeyPad, charArray);
                            break;

                        case '*':
                            if (result.Length > 0) {
                                result = result.Remove(result.Length - 1);
                            }
                            break;

                        case '#':
                            
                            break;
                    }
                    

                }
                result = result + tempKey;


            }

           
            return result;
        }

        // This "searchHashTableWithKey" Method will track times of each key pad's clicks and populate respective chracter
        public static string SearchHashTableWithKey(char key, Hashtable keypad, char[] cArray) {

            string result = "";

            // try catch block is made if keypad hashtable was not initialized
            try
            {
                List<string> KeyList = (List<string>)keypad[key];


                int index = 0;

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
                
                // User click less than or equal 3 times
                else
                {
                    index = cArray.Length - 1;
                }



                result = KeyList[index];

            }
            catch (Exception e) { 
            
            }

            return result;

        }

        public static String[] separatebySameCharacter(string[] inputArray) {
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

            // Convert the result list to an array
            string[] resultArray = resultList.ToArray();

            return resultArray;

        }


    }
}
