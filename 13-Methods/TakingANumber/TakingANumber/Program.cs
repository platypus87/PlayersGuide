/***
 * Level 13 - Taking a Number
 * Many previous tasks have required getting a number from a user.
 * To save time writing out this code over and over,
 * you have decided to make a method to do this common task.
 * 
 * **OBJECTIVES**
 * - Make a method with the signature 'int AskForNumber(string text).
 *   Display the 'text' parameter on the command line.
 *   Retrieve a response from the user, convert it to an 'int,' and return it
 * - Make a method with the signature int AskForNumberInRange(string text, int min, int max).
 *   Only return if the entered number is between 'min' and 'max' values
 * - Place this method in at least one of your previous programs to improve it.
 *
 * **ADDITIONS**
 * 
 * 
 * **NOTES**
 * Added this to the next Quest - Countdown
 */

Console.WriteLine(AskForANumber("Please enter a number"));

int AskForANumber(string text)
{
    int retnum;
    Console.WriteLine(text);
    string input = Console.ReadLine();
    retnum = Convert.ToInt32(input);

    return retnum;
}