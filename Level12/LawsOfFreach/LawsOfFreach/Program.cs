/*** Level 12 - Page 91
 * The town of Freach recently had an awful looping disaster.
 * The lead investigator found that it was a faulty ++ operator in an old 'for' loop,
 * but the town council has chosen to ban all loops but the 'foreach' loop.
 * Yet Freach uses the code presented earlier in this level to compute the minimum and the average value in an int array.
 * They have hired you to rework their existing 'for'-based code to use 'foreach' loops instead.
 * 
 * **OBJECTIVES**
 * - Start with the code for computing an array's minimum values in the section 'Some Examples With Arrays,' Starting on pg. 90
 * - Modify the code to use 'foreach' loops instead of 'for' loops
 * 
 * **ADDITIONS**
 * 
 * 
 * **NOTES**
 * Could add a spot for a user to enter their numbers however they want, and then sort them
 *
 * **ORIGINAL CODE**

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -5, 45, 90 };
int currentMinimum = int.MaxValue;
for (int index =0; index < array.Length; index++)
{
    if (array[index] < currentMinimum)
        currentMinimum = array[index];
}
Console.WriteLine(currentMinimum);

 */

Console.Write("Enter how many numbers you would like to examine: ");
string input = Console.ReadLine();
int userIn = Convert.ToInt32(input);

//int[] arrays = new int[] { 4, 51, -7, 13, -99, 15, -5, 45, 90 }; This was used for the original "solution"
int[] numbers = new int[userIn];
int currentMinimum = int.MaxValue;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter a number: ");
    string anotherInput = Console.ReadLine();
    int getNumber = Convert.ToInt32(anotherInput);
    numbers[i] = getNumber;
}

foreach (int number in numbers)
{
    if (number < currentMinimum)
    { 
        currentMinimum = number;
    }
}
Console.WriteLine(currentMinimum);