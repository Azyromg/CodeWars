// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число которое хотите возвезти в 3 степень");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumCubes(n));

static long SumCubes(int n)
{
    var sum = 0;
    for (int i = 1; i <= n; i++)
    {
        int result = (int)Math.Pow(i, 3);
        sum += result;
    }

    return sum;
}
