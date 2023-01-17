/* The Defense of Consolas Objectives:
 * -Ask the user for a row and column
 * -Compute the neighboring rows and columns of where to "deploy the squad"
 * -Display the deployment instructions in a color of your choosing
 * -Change the window title to "Defense of Consolas"
 * -Play a sound with Console.Beep when the results have been computed and displayed
 */

Console.Title = "The Defense of Consolas";

//Get column from user and convert to int
Console.Write("Enter the column of the impending attack: ");
string input = Console.ReadLine();
int attackCol = int.Parse(input);

//Get row from user and convert to int
Console.Write("Enter the row of the impending attack: ");
input = Console.ReadLine();
int attackRow = int.Parse(input);

Console.Clear();
Console.WriteLine($"The attack location is ({attackCol}, {attackRow})!\n");


//String attackPos = $"({attackRow}, {attackCol})";
//Console.WriteLine(attackPos);

//string leftDef = $"({attackCol - 1}, {attackRow})";
//string rightDef = $"({attackCol + 1}, {attackRow})";
//string topDef = $"({attackCol}, {attackRow + 1})";
//string bottomDef = $"({attackCol}, {attackRow - 1})";
//string defenseLocations = $"{leftDef}; {topDef}; {rightDef}; {bottomDef}";
//Console.WriteLine($"Set up the barriers at {defenseLocations}!");

Console.WriteLine($"Set up the barrier at \n{getPosition(attackCol, attackRow)}");
Console.Beep(1000,500);


// Function for calculating the points that the barriers need to be placed according to Player's Guide pg. 65
string getPosition(int column, int row)
{
    string leftDefensePoint = $"({column - 1}, {row})";
    string rightDefensePoint = $"({column + 1}, {row})";
    string topDefensePoint = $"({column}, {row + 1})";
    string botDefensePoint = $"({column}, {row - 1})";
    
    string defensePosition = $"Left: {leftDefensePoint, 20}\n" +
        $"Top: {topDefensePoint, 21}\n" +
        $"Right: {rightDefensePoint, 19}\n" +
        $"Bottom: {botDefensePoint, 18}";

    return defensePosition;
}