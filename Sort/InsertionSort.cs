using static System.Console;
using static System.Convert;

int n;
int[] arr;

Input();

InsertionSort(arr);

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

void InsertionSort(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        int j = 0;
        int temp = arr[0];
        while (j + 1 < size && arr[j + 1] < temp) 
        {
            arr[j] = arr[j + 1];
            j++;
        }
        arr[j] = temp;
    }
}

void Output()
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}
