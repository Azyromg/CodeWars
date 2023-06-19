// See https://aka.ms/new-console-template for more information


static string HighAndLow(string number)
{
   //1 переводим строку в массив чисел.
    var numbers = number.Split(" ");
    var numberslist = new List<int>();
    for(int i = 0; i < number.Length; i++)
    {
        numberslist.Add(int.Parse(numbers[i]));
    }
   //2 пробежатся по массиву чисел и найти самое большое число и самое маленькое.
   var max = numberslist.Max();
    var min = numberslist.Min();
    //3 вывести в нужной форме.
    string result = $"{max} {min}";

    return result;
}


static string BestPractices(string numbers)
{
    var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
}
