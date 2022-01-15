using static System.Console;
using static System.Convert;

int n;
int[] arr;

Input();

BubbleSort(arr);

Output();

void Input()
{
    n = ToInt32(ReadLine() ?? "0");
    arr = new int[n];
    var split = ReadLine().Split();
    for (int i = 0; i < n; i++)
    {
        arr[i] = ToInt32(split[i]);
    }
}

void BubbleSort(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            if(arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

void Output()
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}
