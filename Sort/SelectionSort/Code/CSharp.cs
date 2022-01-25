using static System.Console;
using static System.Convert;

int n;
int[] arr;

Input();

SelectionSort(arr);

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

void SelectionSort(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        int index = i;
        for (int j = i + 1; j < size; j++)
        {
            if (arr[index] > arr[j])
            {
                index = j;
            }
        }

        int temp = arr[i];
        arr[i] = arr[index];
        arr[index] = temp;
    }
}

void Output()
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}
