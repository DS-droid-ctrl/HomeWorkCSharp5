// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int num = 6;
int min = 0;
int max = 999;

int[] myRandomArray = CreateRandomArray(num, min, max);
Console.WriteLine($" [ {String.Join(", ", myRandomArray)} ] ");

int sum = 0;
for (int i = 1; i < myRandomArray.Length; i += 2)
{
    sum = sum + myRandomArray[i];
}
Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях: {sum}");