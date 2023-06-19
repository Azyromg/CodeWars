// See https://aka.ms/new-console-template for more information
string s = "HELLO word";

Console.WriteLine(ToAlternatingCase(s));

static string ToAlternatingCase(string s)
{
    char[] vs = s.ToCharArray();
    for(int i = 0; i < s.Length; i++)
    {
        if(char.IsUpper(s[i]))
        {
            vs[i] = char.ToLower(s[i]);
        }
        else
        {
            vs[i] = char.ToUpper(s[i]);
        }
    }
    return new string(vs);
}