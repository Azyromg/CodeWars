// See https://aka.ms/new-console-template for more information
string str ="wortD";
Console.WriteLine(IsUpperCase(str));
static bool IsUpperCase(string str)
{
    bool rt = true;
        char[] array = str.ToCharArray();
   for (int j = 0; j < array.Length; j++)
   {
        if(Char.IsLetter(array[j]))
        {
            if (!Char.IsUpper(array[j]))
            {
                return false;
            }
        }
   }
    return rt;
}
