/**
 * Objectives:
 * -Build a program that will allow a user, the pilot, to enter a number
 *-If the number is above 100, or less than 0, keep asking
 *-Clear the screen once the program has collected a good number
 *-Ask a secon user, the hunter, to guess numbers
 *-Indicate whether the users guess is too high or too low
 *-Loop until they get it right, then end the program
 **/

/**
 * Additions:
 * -Added a guess counter
 * -Printed the number of guesses it took
 * -Use string interpolation to print out the numebr of guesses it took
 * -Added method to write certain lines in specific colors
**/
//initialize variables outside of the loops so that they can be used in BOTH loops.
//Initializing inside the loops would disallow using them in further loops.
string user1Response, user2Response;
int user1Int =0 , user2Int = 0, guessCounter=0;

//With the Do/While, we put the intial ask outside of the loop
Console.WriteLine("User 1, please select a number from 1-100");

do
{
    //start off by getting the input from user1
    user1Response = Console.ReadLine();
    user1Int = Convert.ToInt32(user1Response);

    //error handling NOT added in this task, but should ALWAYS be added when user input is received
    if (user1Int <=0 || user1Int > 100)
    {
        Console.WriteLine("That number is outside the given range. Please enter a number from 1-100:");
    }
}
while (user1Int < 0 || user1Int >100);

//Clear the console output of all writing
Console.Clear();

//move to second "phase" of program, the guessing game for user2
Console.WriteLine("User 2, please guess a number from 1-100:");

do
{
    user2Response = Console.ReadLine();

    //putting this BEFORE the INT conversion will allow for the user to quit without issue
    //error handling ignored, but SHOULD always be done when receiving user input
    if (user2Response == "quit" || user2Response == "Quit")
    {
        break;
    }

    //converting user input to a number, error handling ignored
    user2Int = Convert.ToInt32(user2Response);

    //if clauses take care of most likely options; do NOT take edge cases or error handling into consideration
    //because of the "break" in the first block, these are a separate if/else if block that consider only the users' numbers
    if (user2Int < user1Int)
    {
        Console.WriteLine("That guess is too low, please try again or \"quit\" to exit.");
    }
    else if (user2Int > user1Int)
    {
        Console.WriteLine("That guess is too high, please try again or \"quit\" to exit.");
    }
    else if (user2Int == user1Int)
    {
        Console.WriteLine("Congrats you guessed correctly!");
        guessCounter++;
        break;
    }
    guessCounter++;
}while (user1Int != user2Int);

if (user2Int == user1Int)
{
    if (guessCounter == 1)
    {
        Console.WriteLine("You got it on the first try!!! Are you psychic??");
    }
    else
    {
        Console.WriteLine($"You guessed the number in {guessCounter} guesses");
    }
}

//This line uses the method to print one line in green
WriteLineInGreen("Thank you for playing!");

static void WriteLineInGreen(string statement)
{
    //Only using ForegroundColor because I know my terminal has black background.
    //Otherwise, I would set both background AND foreground
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(statement);
    Console.ResetColor();
}