// See https://aka.ms/new-console-template for more information
public static int SumOfIntegersInString(string s)
{
    string currentNumber = string.Empty;
    int total = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (char.IsDigit(s[i])) currentNumber += s[i];
        else if (currentNumber.Length > 0)
        {
            total += int.Parse(currentNumber);
            currentNumber = string.Empty;
        }
    }

    if (currentNumber.Length > 0) total += int.Parse(currentNumber);

    return total;
}
