// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

var text = "pppp32444GazatuIsSmol4444443223p";
var matches = new List<Int64>();
ulong sum = 0;



for (int currentChar = 0; currentChar < text.Length; currentChar++)
{
    for (int findMatch = currentChar + 1; findMatch < text.Length; i++)
    {
        CheckIfIsDigit(text[findMatch]);
        if (false)
        {
            break;
        }

        if (text[currentChar] == text[findMatch])
        {
            PrintString(currentChar, findMatch);
            ListOfMatches(currentChar, findMatch);
            
            break;
        }
    }
}
PrintTotalSumOfMatches(sum);

bool CheckIfIsDigit(char checkMatch)
{
    if (!Char.IsDigit(checkMatch))
    {
        return false;
    }
    else
        return true;
}
void PrintString(int startIndex, int stopIndex)
{
    Console.Write(text.Substring(0, startIndex));
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(text.Substring(startIndex, stopIndex - startIndex + 1));
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(text.Substring(stopIndex + 1, text.Length - (stopIndex + 1)));
    Console.WriteLine("");
}
ulong ListOfMatches(int startNumber, int endNumber)
{
    var match = UInt64.Parse(text.Substring(startNumber, endNumber - startNumber + 1));
    sum = sum + match;
    return sum;
}
void PrintTotalSumOfMatches(ulong totalSum)
{
    Console.Write("\nSumman av alla matcher är: ");
    Console.Write(totalSum);

}