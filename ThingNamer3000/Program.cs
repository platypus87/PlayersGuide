Console.WriteLine("What kind of thing are we talking about?");
string a =  Console.ReadLine();
Console.WriteLine("How would you describe is? Big? Azure? Tattered?");
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";

//Console.WriteLine("The "+ b + " "+a+" of"+c+" "+d+"!");
//the above line is the original from the text and needed to be fixed
/* the choice was to remove 'of' from c or 
 * to remove 'of' from final printed string
 * the solution here removed the 'of' from the printed string concatenation
 */

Console.WriteLine("The " + b + " " + a +" "+ c + " " + d + "!");

/* What can be done to make this code more readable?
 * 
 * it would be best to not a single char as the variable name
 * usually you want to have descriptive variable names
 */

var varName = "This is a 'var'";
Console.WriteLine(varName);
Console.WriteLine(varName.GetType().Name);
//output is String

var number = Math.PI;
Console.WriteLine(number);
Console.WriteLine(number.GetType().Name);
//output is Double