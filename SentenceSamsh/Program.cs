// See https://aka.ms/new-console-template for more information
string[] words = { "hello", "amazing", "world" };

Console.WriteLine(Smash(words));
static string Smash(string[] words)
{
    string result = words[0];
    for (int i = 1; i < words.Length; ++i)
    {
        result += " " + words[i];
    }
    return result;
}
