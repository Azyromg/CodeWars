// See https://aka.ms/new-console-template for more information
int[] arr = new int[] {1,2,3,4};

Console.WriteLine(IsAscOrder(arr));
static bool IsAscOrder(int[] arr)
{
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i - 1] > arr[i])
        {
           return false;
        }
    }
    return true;
}
