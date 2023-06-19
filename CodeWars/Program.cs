// See https://aka.ms/new-console-template for more information
string str = "The greatest victory is that which requires no battle";
Console.WriteLine(Solution(str));

static string Solution(string str)
{
    string[] massivStr = str.Split(' ');
    string newStr = "";
    for (int i = massivStr.Length - 1; i >= 0; i--)
    {
        newStr += massivStr[i] + ' ';
    }
    return newStr;
}