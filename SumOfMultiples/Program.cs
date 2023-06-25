// See https://aka.ms/new-console-template for more information
int n = 4;
int m = 123;

Console.WriteLine(SumMul(n, m));
Console.WriteLine(BestSolutions(n, m));
static int SumMul(int n, int m)
{
    if (n < m && n > 0)
    {
        List<int> allNumbers = new List<int>();
        int nextNumber = 0;
        int currentNumber = 0;
        for (int i = 0; i < m; i++)
        {
            currentNumber = i;
            nextNumber = currentNumber;
            if (nextNumber % n == 0)
            {
                allNumbers.Add(nextNumber);
            }
            else
            {

            }
        }
        return allNumbers.Sum();
    }
    else
    {
        throw new ArgumentException();
    }
}
static int BestSolutions(int n, int m)
{
    if (m <= n || n <= 0)
    {
        throw new ArgumentException();
    }
    var result = 0;
    for (int i = n; i < m; i += n)
    {
        result += i;
    }
    return result;
}
