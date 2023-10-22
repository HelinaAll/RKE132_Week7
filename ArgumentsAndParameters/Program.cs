
Console.WriteLine("Enter something:");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput - argument



static void PrintAnyWord(string anystring) //anyString - parameter
{
    anystring = anystring.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anystring);
    }
}