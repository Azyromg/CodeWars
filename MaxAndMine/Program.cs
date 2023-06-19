// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число");
var humanYears = Convert.ToInt32(Console.ReadLine());
var result = HumanYearsCatYearsDogYears(humanYears);
foreach (var year in result)
{
    Console.WriteLine(year);
}

static int[] HumanYearsCatYearsDogYears(int humanYears)
{
    if (humanYears == 0)
    {
        return new int[] { 0, 0, 0 };
    }
    int catYears = 0; 
    int dogYears = 0;
    if (humanYears == 1)
    {
        catYears = 15;
        dogYears = 15;
    }
    else if (humanYears == 2)
    {
        catYears = 15 + 9;
        dogYears = 15 + 9;
    }
    else
    {
        catYears = 15 + 9 + (humanYears - 2) * 4;
        dogYears = 15 + 9 + (humanYears - 2) * 5;
    }
    return new int[] { humanYears, catYears, dogYears };
}


