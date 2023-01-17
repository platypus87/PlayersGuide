/* "Watchtower," Player's Guide pg. 74
 * Objectives:
 * -Ask the user for an x value and a y value. This will be the coordinate of the
 * enemy's location relative to the watchtower.
 * -Using the image [on page 74], if statements, and relational operators,
 * display a message about what direction the enemy is coming from.
 * For example, "The enemy is to the northwest!" or "The enemy is here!"
 */

using System.Reflection.Metadata.Ecma335;

Console.Title = "Watchtower";

Console.WriteLine("What is the enemy's location?");

Console.WriteLine(findEnemy(getEnemyX(),getEnemyY()));

int getEnemyX()
{
    int enemyX;
    Console.Write("X-Value: ");
    string input = Console.ReadLine();
    try
    {
        enemyX = int.Parse(input);
    }
    catch (FormatException)
    {
        Console.WriteLine("can't convert that to an int, try again");
        enemyX = getEnemyX();
    }
    
    return enemyX;
}

int getEnemyY()
{
    int enemyY;
    Console.Write("Y-Value: ");
    string input = Console.ReadLine();
    try
    {
        enemyY = int.Parse(input);
    }catch(FormatException)
    {
        Console.WriteLine("can't convert that to an int, try again");
        enemyY=getEnemyY();
    }
    
    return enemyY;
}
string findEnemy(int x, int y)
{
    string enemyLocation = "The enemy is ";

    if (x < 0 && y > 0)
    {
        enemyLocation = enemyLocation + "northwest!";
    }
    else if (x > 0 && y > 0)
    {
        enemyLocation = enemyLocation + "northeast!";
    }
    else if (x < 0 && y < 0)
    {
        enemyLocation = enemyLocation + "southwest!";
    }
    else if (x > 0 && y < 0)
    {
        enemyLocation = enemyLocation + "southeast!";
    }
    else if (x == 0 && y > 0)
    {
        enemyLocation = enemyLocation + "north!";
    }
    else if (x > 0 && y == 0)
    {
        enemyLocation = enemyLocation + "east!";
    }
    else if (x == 0 && y < 0)
    {
        enemyLocation = enemyLocation + "south!";
    }
    else if (x < 0 && y == 0)
    {
        enemyLocation = enemyLocation + "west!";
    }
    else if (x == 0 && y == 0)
    {
        enemyLocation = "The enemy is here!";
    }
    else
    {
        Console.WriteLine("Something went wrong");
    }

    return enemyLocation;
}