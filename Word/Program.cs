// See https://aka.ms/new-console-template for more information
string str = "word";
Console.WriteLine(Solution(str));
static string BestSolution(string str)
{
    var newStr = new string(str.Reverse().ToArray());
    return newStr;
}

static string Solution(string str)
{
    char[] massivStr = str.ToCharArray();
    string newStr = "";
    for (int i = massivStr.Length - 1; i >= 0; i--)
    {
        newStr += massivStr[i];
    }
    return newStr;
}
