/*** Level 13 - Countdown pg. 102
 * NOTE-This challenge requires that you have read "The Basice of Recursion" side quest to attmept.
 * 
 * **DESCRIPTION**
 * The Council of Freach has summoned you.
 * New writing has appeared on the Tomb of Algol the Wise,
 * the last True Programmer to wander this land.
 * The writing strikes fear and awe into the hearts of the loop-loving people of Freach:
 * "The next True Programmer shall be able to write any looping code with a method called 'instead.'"
 * The Senior Counselor, scared of a world without loops, asks you to put your skill to the test
 * and write the following code, which counts down from 10-1, with no loops.
 * 
 * for (int x = 10; x>0; x--)
 *      Console.WriteLine(x);
 *      
 * As you consider the words on the Tomb of Algod the Wise,
 * you begin to think that, with recursion, you might be able to 
 * rewrite code to count down from 10 to 1 using recursion instead of a loop.
 *      
 * **OBJECTIVES**
 * -Write code that counts down from 10 to 1 using a recursive method
 * -HINT: Remember that you must have a base case that ends the recursion and
 *  every time you call the method recursively, you must be getting closer and closer to the base case.
 * 
 * **ADDITIONS**
 * 
 * 
 * **NOTES**
 * 
 * Might want to add a request for the user to input a number that you can count down from
 */
Console.WriteLine(CountDown(AskForANumber("Which number are you counting down from?")));
int CountDown(int x)
{
    Console.WriteLine(x);
    if (x == 1) return 1;
    return x - CountDown(x-1);
}

int AskForANumber(string text)
{
    int retnum;
    Console.WriteLine(text);
    string input = Console.ReadLine();
    retnum = Convert.ToInt32(input);

    return retnum;
}