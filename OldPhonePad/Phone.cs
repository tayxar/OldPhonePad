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
            String Text = "";
            
            Hashtable KeyPad = Utility.InitializeKeyPad();

            string[] inputArrayWithoutSpace = Regex.Split(input, "( )");
            
            // Return match char List : Example => {"33344"," ","55"} to {"333","44"," ","55"}            
            List<String> matchCharList = Utility.ReturnMatchCharList(inputArrayWithoutSpace);
            
            //Translate Number of KeyPad Clicks to alphabet
            foreach (string key in matchCharList) {

                char[] charArray = key.ToCharArray();
                string alphabet= "";

                foreach (char c in charArray) {

                    switch (c) {

                        case '1':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '2':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '3':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '4':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '5':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '6':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '7':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '8':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '9':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '0':
                            alphabet = Utility.TranslateWithClickTimes(c, KeyPad, charArray);
                            break;

                        case '*':
                            if (Text.Length > 0) {
                                Text = Text.Remove(Text.Length - 1);
                            }
                            break;

                        case '#':
                            
                            break;
                    }
                    
                }
                Text = Text + alphabet;

            }

           return Text;
        }
    }
}
