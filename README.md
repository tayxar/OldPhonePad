C# Coding Challenge (Iron Software)

Question
============================================
Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.

For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.
You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.
Prompt:
Please design and document a class of method that will turn any input to OldPhonePad into the correct output.

Assume that a send “#” will always be included at the end of every input.

public static string input String OldPhonePad( ) {
}

Expected OutPut:
- OldPhonePad(“33#”) => output: E
- OldPhonePad(“227*#”) => output: B
- OldPhonePad(“4433555 555666#”) => output: HELLO
- OldPhonePad(“8 88777444666*664#”) => output: ?????

Solution
===========================================================================================================


1. Decide most suitable Collection Class 

- First I think what collection to use List, Array or Hashtable. To create with List I need to create class and obj to put in List. This might result messy code.
- Since the question is simple and just to pair the values with each Key, I decided to work with Hashtable.
- But To sort String and character, I decided to use array.


2. Explore Sort Logic

- The string will have any sequence with space such as "22 33 555* 444#" , "2233 555*444#" etc.
- 1st , to split string with space but space also need to be one of the array element. "2233 555*444#" to {"2233"," ","555*444#"}
- 2nd, to split string by matching character.  {"2233"," ","555*444#"} to {"22","33"," ","555","*","444","#}
- 3rd, the above second module is separated for cleaner code.
- 4th,  Nested loop is chosen. Outside loop to sort each array element "22" and inside loop will translate key click times into alphabet by char array.
- 5th, Separate "Translation of key click times to alphabet" method to get cleaner code.
- 6th, I choose switch case since we are comparing the Character "Key" to get alphabet translation.
- 7th, backspace mechanism was implemented with swtich case condition.
- 8th, to build the string loop by loop, tempKey is used and later after each inside loop, I added to main result string.


 3. Testing

- I tested with space
- I tested with many *
- I tested with a long key input
- In order to prevent other inputs, I write one more method in program file to check the input string is valid or not.
