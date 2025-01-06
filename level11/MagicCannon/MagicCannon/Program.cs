/***
 * The Magic Cannon (pg. 85)
 * Objectives:
 * -DONE-Write a program that will loop through the values between 1-100 and display what kind of blast the crew should expect. (The % operator may be of use)
 * -DONE-Every third number needs to be red for fire
 * -DONE-Every fifth number needs to be yellow for electricity
 * -DONE-If third and fifth end up together, it is blue for Electric Fire
 * -DONE-Change the color of the output based on the type of blast. (For example, red for Fire, yellow for Electric, and blue for Electric and Fire)
 */

/***
 * ADDITIONS/CHANGES
 * -DONE-Ask if user wants a full list; if so, what number should it stop at?
 * -DONE-Ask if user wants a specific number; if so, only print what that number would be
 * -Make it a loop until the user is done
 */

/***
 * CODE FLOW
 * Ask for list or number
 * Create method for printing the list to whichever number is input
 * Create method for printing ONLY the number that is entered
 */

/***
 * THOUGHTS:
 */

using System;

string userResponse, continueResponse="";
Console.WriteLine("Hello! Welcome to Cannon Cranker 5000.");
Console.WriteLine("Please enter \n'list' for a list of the elements for each crank, or \n'number' for the element of a specific number of cranks. \nIf you would like to exit, please enter 'quit' or 'exit'");
userResponse = Console.ReadLine();

if (userResponse == "list" || userResponse == "List")
{
    Console.WriteLine("How high would you like to go?");
    string input = Console.ReadLine();
    int listLength = Convert.ToInt32(input);
    CannonList(listLength);
}
else if (userResponse == "number" || userResponse == "Number")
{
    Console.WriteLine("Which number would you liike to examine?");
    string input = Console.ReadLine();
    int specificNumber = Convert.ToInt32(input);
    CannonSpecific(specificNumber);
}
else
{
    
    WriteInRed("WRONG");
}





//This is where the methods start
static void CannonList(int list)
{
    for(int i =0; i<=list; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("You didn't do anything silly");
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            WriteInBlue($"{i} cranks is Electric AND Fire!!");
        }
        else if (i % 3 == 0)
        {
            WriteInRed($"{i} cranks is Fire");
        }
        else if (i % 5 == 0)
        {
            WriteInYellow($"{i} cranks is Electric");
        }
        else { Console.WriteLine($"{i} cranks is nothing special; keep cranking!"); }

    }
}

static void CannonSpecific(int userNumber)
{
    int i = userNumber;
    if (i == 0)
    {
        Console.WriteLine("You didn't do anything silly");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        WriteInBlue($"{i} cranks is Electric AND Fire!!");
    }
    else if (i % 3 == 0)
    {
        WriteInRed($"{i} cranks is Fire");
    }
    else if (i % 5 == 0)
    {
        WriteInYellow($"{i} cranks is Electric");
    }
    else { Console.WriteLine($"{i} cranks is nothing special; keep cranking!"); }
}
static void WriteInYellow(string statement)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(statement);
    Console.ResetColor();
}

static void WriteInRed(string statement)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(statement);
    Console.ResetColor();
}
static void WriteInBlue(string statement)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(statement);
    Console.ResetColor();
}