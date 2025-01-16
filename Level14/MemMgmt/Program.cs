/*** Hunting the Manticore pg. 118
 * 
 * **OBJECTIVES**
 * - Establish the game's starting state: the Manticore begins with 10 hp and the city with 15. The game starts at round 1.
 * - Ask the first player to choose the Manticore's distance from the city (0-100). Clear the screen afterward.
 * - Run the game in a loop until either the Maticore's or city's health reaches 0.
 * - Before the second player's turn, display the round number, city health, and the Manticore's health.
 * - Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple of 3 AND 5, 3 if it is a multiple of 3 OR 5, and 1 otherwise. Display this to the player.
 * - Get the target range from the second player, and resolve its effect. Tell the user if they overshot (too far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore's health by the expected amount.
 * - If the Manticore is still alive, reduce the city's health by 1.
 * - Advance to the next round.
 * - When the Manticore or the city reaches 0, end the game and display the outcome.
 * - Use different colors for the different types of messages.
 * NOTE- This is the largest program so far, expect it to take some time.
 * NOTE- Use methods to focus on solving one problem at a time.
 * NOTE- This version requires two players, but in the future we will modify it to allow the computer to randomly place the Manticore so that it can be a single player game.
 * 
 * EXAMPLE OUTPUT
 * --Player one, how far do you want to station the manticore? 35
 * clear screen
 * --Player two, it's your turn
 * ----------------------------
 * STATUS: Round: 1 City: 15/15 Manticore 10/10
 * The cannon is expected to deal 1 damage this round.
 * Enter desired cannon range: 50
 * That round overshot the target.
 *------------------------------
 *Status: Round: 2 City 14/15 Manticore 10/10
 *The cannon is expected to deal 1 damage this round
 *Enter the desired range: 25
 *That round FELL SHORT of the target
 *------------------------------
 * 
 * **NOTES**
 * -This is a high/low game with complexity :)
 * - Need to balance the city health to 20-25
 * - Need to add a finish message
 * 
 * **ADDITIONS**
 * - Made it a random number from the computer instead of one selected by a player :)
 * 
 * **DESIGN**
 * - intake the distance from player one
 * - ask player two to what distance to fire at
 * - deal with too far, too short, or hit
 * - calculate and deal with Manticore damage
 * - ALWAYS remove one hp from the city
 * 
 * 
 */

int damage, distance, range, round=0, cityHealth=15, manticoreHealth=10;
Random random = new Random();

Console.WriteLine("The computer has stationed the Manticore at a random distance up to 100 meters away.");
distance = random.Next(101);

do
{
    round += 1;
    damage = GetDamage(round);
    
    DisplayStatus(round, manticoreHealth, cityHealth, damage);

    range = GetRange();

    if (range == distance)
    {
        GoodGuess();
        manticoreHealth=DoDamage(manticoreHealth, damage);
        distance = random.Next(101);
    }else if (range > distance)
    {
        TooFar();
    }
    else
    {
        TooShort();   
    }

    cityHealth -= 1;

}while(cityHealth>0 && manticoreHealth>0);

void DisplayStatus(int round, int MHealth, int CHealth, int damage)
{
    
    Console.WriteLine($"STATUS: Round: {round}: City: {CHealth}/15 Manticore: {MHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
    
}

int GetRange()
{
    Console.Write("Enter a desired range: ");
    string input = Console.ReadLine();
    int range = Convert.ToInt32(input);
    return range;
}

int GetDamage(int round)
{
    int cannonDamage;
    if (round % 3 == 0 && round % 5 == 0)
    {
        cannonDamage = 10;
    }
    else if (round % 5 == 0 || round % 3 == 0)
    {
        cannonDamage = 3;
    }
    else cannonDamage = 1;

    return cannonDamage;
}

void TooFar()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your range was too long, try something closer.");
    Console.ForegroundColor = ConsoleColor.White;
}

void TooShort()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Your range was too short, try something further.");
    Console.ForegroundColor = ConsoleColor.White;
}

void GoodGuess()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("That's a hit, great job!!");
    Console.ForegroundColor = ConsoleColor.White;
}

int DoDamage(int currentHealth, int damage)
{
    return currentHealth - damage;
}