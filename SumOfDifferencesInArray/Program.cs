// See https://aka.ms/new-console-template for more information
int[] arr = new int[4] {1, 4, 6, 3};

Console.WriteLine(SumOfDifferences(arr));

int SumOfDifferences(int[] arr)
{
    //Рассортировать элементы массива от самого большого к самому маленькому числу.

    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                max = arr[j];
                arr[j] = arr[i];
                arr[i] = max;
                
            }
        }
    }
    int sum = 0;
    //Просуммировать различие между последовательными парами.
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int dif = arr[i] - arr[i + 1];
        sum = sum + dif;
    }
    //Вывести сумму всех элементов массива.
    return sum;
    
}
