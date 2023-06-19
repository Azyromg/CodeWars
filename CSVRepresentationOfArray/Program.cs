// See https://aka.ms/new-console-template for more information
int[][] array = new int[3][];
for(int i = 0; i < 3; i++)
{
    array[i] = new int[3];
    array[i][0] = i;
    array[i][1] = i + 1;
    array[i][2] = i + 2;
}

Console.WriteLine(ToCsvText(array));

Console.WriteLine(BestPractices(array));

static string ToCsvText(int[][] array)
{
    string str = "";

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            str += array[i][j];
            if (j != array[i].Length - 1) { str += ","; }
        }
        if (i != array.Length - 1) { str += "\n"; }
    }

    return str;
}

static string BestPractices(int[][] array)
{
    return string.Join("\n", array.Select(x => string.Join(",", x)));
}
