// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(EvenOrOdd(number));


 static string EvenOrOdd(int number)
 {

    if (number % 2 == 0)
    {
        return ("Even");
    }
    else
    {
        return ("Odd");
    }
 }