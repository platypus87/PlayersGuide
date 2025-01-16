/*** Simula's Test pg. 128
 * 
 * **DESCRIPTION**
 * As you move through the village of Enumerant, you notice a short, cloaked figure following you.
 * You confront the figure, it is Simula, and she wants your help.
 * She gives you a chest, but it is broken.
 * You need to create a program with enumeration to recreate the locking mechanism.
 * There are three states, Open->(close)->Closed->(lock)->Locked->(unlock)->Closed->(open)->Open
 * If you attempt an impossibe action in the current state (like opening a locked box), nothing happens.
 * 
 * **OBJECTIVES**
 * - Define an enumeration for the state of the chest
 * - Make a variable whose type is this new enumeration
 * - write code to allow you to manipulate the chest with the 'lock,' 'unlock,' 'open,' and 'close' commands, but ensure that you don't transition between states that don't support it
 * - Loop forever, asking for the next command
 * 
 * **ADDITIONS**
 * Added a loop to ask user if you want to continue; should be easily removed if/when needed :)
 */
string action;
bool loop = true;
Chest box = Chest.Locked;

while (loop)
{
    PrintStatus(box);
    action = GetAction();

    while(box == Chest.Locked)
    {
        if (action == "unlock")
        {
            box = Chest.Closed;
        }
        PrintStatus(box);
        break;
    }
    while(box == Chest.Closed)
    {
        if(action == "lock")
        {
            box = Chest.Locked;
        }else if(action == "open")
        {
            box = Chest.Open;
        }
        PrintStatus(box);
        break;
    }
    while (box == Chest.Open)
    {
        if (action == "close")
        {
            box = Chest.Closed;
        }
        PrintStatus(box);
        break;
    }

    loop = Continue();
}
Console.WriteLine($"The chest is {box}");

void PrintStatus(Chest chest)
{
    Console.WriteLine($"The chest is {chest}. What would you like to do?");
}

string GetAction()
{
    string userAction = Console.ReadLine();
    return userAction;
}

void WrongAction(Chest chest)
{
    Console.WriteLine($"That action is not allowed when box is {chest}");
}

bool Continue()
{
    Console.WriteLine("Would you like to continue?");
    string input = Console.ReadLine();

    if (input == "yes" || input == "Yes")
    {
        return true;
    }else 
        return false;
}

Chest CloseChest(Chest chest)
{
    chest=  Chest.Closed;
    return chest;
}
Chest OpenChest(Chest chest)
{
    chest = Chest.Open;
    return chest;
}

Chest LockChest(Chest chest)
{
    chest = Chest.Locked;
    return chest;
}

enum Chest { Open, Closed, Locked};
enum Operations { Close, Open, Unlock,Lock };