// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ввидите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiply(x));



static int Multiply(int x)
{
    if (x % 2 == 0)
    {
        return (x * 8);
    }
    else
    {
        return (x * 9);
    }
}