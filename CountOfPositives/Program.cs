// See https://aka.ms/new-console-template for more information
int[] input = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, -23, -34, -77};
Console.WriteLine($"{Best(input)}");

static int[] CountPositivesSumNegatives(int[] input)
{
    if (input == null || input.Length == 0)
    {
        return new int[0];
    }
    int[] result = new int[2];
    result[0] = 0;
    result[1] = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (0 < input[i])
        {
            result[0] += 1;
        }
        else if (0 > input[i])
        {
            result[1] += input[i];
        }
    }
    return result;
}

static int[] Best(int[] input)
{
    if (input == null || !input.Any())
    {
        return new int[] { };
    }

    int countPositives = input.Count(n => n > 0);
    int sumNegatives = input.Where(n => n < 0).Sum();

    return new int[] { countPositives, sumNegatives };
}