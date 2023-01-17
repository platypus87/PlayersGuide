/* Buying/Discounted Inventory, Player's Guide pgs. 78-9
 * 
 * Buying Objectives
 * -Build a program that will show the menu illustrated [on pg. 78]
 * -Ask the user to enter a number from the menu.
 * -Using the infomation [on pg. 78], use a switch to show the item's cost
 * 
 * Discounted Objectives
 * -Modify the above requirements to also ask the user for their name.
 * -If their name equals your name, divide the cost in half.
 * 
 * **Added continuous loop functionality**
 */

using System.Runtime.CompilerServices;

Console.Title = "Buying Inventory";
bool cont = true;

while (cont == true)
{
    displayMenu();
    string selection = makeSelection(getChoice());
    Console.WriteLine(selection);
    Console.Write("Would you like to see another item (y/n): ");
    string input = Console.ReadLine();
    if (input != "y")
    {
        cont = false;
    }
}
        
void displayMenu()
{
    Console.WriteLine("The following items are available for sale: \n" +
        "1 - Rope\n" +
        "2 - Torch\n" +
        "3 - Climbing Equipment\n" +
        "4 - Clean Water\n" +
        "5 - Machete\n" +
        "6 - Canoe\n" +
        "7 - Food Supplies");
}

int getChoice() { 
    Console.Write("Enter the number of the item you would like the price of: ");
    string input = Console.ReadLine();
    int choice;
    try
    {
        choice = int.Parse(input);
    } catch (FormatException){
        Console.WriteLine("I don't understand that input.");
        choice = getChoice();
    }

    return choice;
}

string makeSelection(int num)
{
    //string answer;
 
    //switch (num)
    //{
    //    case 1:
    //        answer = "\nRope cost 10g\n";
    //        break;
    //    case 2:
    //        answer = "\nTorches cost 15g\n";
    //        break;
    //    case 3:
    //        answer = "\nClimbing Equipment cost 25g\n";
    //        break;
    //    case 4:
    //        answer = "\nClean Water cost 1g\n";
    //        break;
    //    case 5:
    //        answer = "\nMachetes cost 20g\n";
    //        break;
    //    case 6:
    //        answer = "\nCanoes cost 200g\n";
    //        break;
    //    case 7:
    //        answer = "\nFood Supplies cost 1g\n";
    //        break;
    //    default:
    //        answer = "\nThat might be a hidden item.\n" +
    //            "Please enter a number 1-7";
    //        break;
    string answer;

    answer = num switch
    {
        1 => "Rope costs 10g",
        2 => "Torches cost 15g",
        3 => "Climbing Equipment costs 25g",
        4 => "Clean Water costs 1g",
        5 => "Machetes cost 20g",
        6 => "Canoes cost 200g",
        7 => "Food Supplies cost 1g",
        _ => "That might be a hidden item.\n" +
        "Please enter a number 1-7."
    };
    return answer;
}