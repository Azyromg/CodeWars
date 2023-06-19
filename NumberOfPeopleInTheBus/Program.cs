// See https://aka.ms/new-console-template for more information
List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };

Console.WriteLine(Number(peopleList));


static int Number(List<int[]> peopleListInOut)
{
    int peopleIn = 0;
    foreach (int[] peopleInOut in peopleListInOut)
    {
        peopleIn += peopleInOut[0] - peopleInOut[1];
    }
    return peopleIn;

}
