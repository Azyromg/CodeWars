// See https://aka.ms/new-console-template for more information
int value = 10;

Console.WriteLine(ToBinary(value));


static int GoogleBinary(int value)
{
    string binary = Convert.ToString(value, 2);
    int reselt = Convert.ToInt32(binary);
    return reselt;

}

static int ToBinary(int value)
{
    string result = string.Empty;
    while (value > 0)
    {
        int res = value % 2;
        value = value / 2;
        result = res.ToString() + result;
    }
    int number = Convert.ToInt32(reselt);
    return number;
}
