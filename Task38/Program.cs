// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
int minimum = -100;
int maxsimum = 999;

int[] myRandomArray = CreateRandomArray(num, minimum, maxsimum);
Console.WriteLine($" [ {String.Join(", ", myRandomArray)} ] ");

int min = myRandomArray[0];
for (int i = 1; i < myRandomArray.Length;)
{
    if (min > myRandomArray[i])
    {
        min = myRandomArray[i];
    }
    i++;
}
Console.WriteLine($" Минимальное число равно: {min}");

int max = myRandomArray[0];
for (int i = 1; i < myRandomArray.Length;)
{
    if (max < myRandomArray[i])
    {
        max = myRandomArray[i];
    }
    i++;
}
Console.WriteLine($" Максимальное число равно: {max}");

int resalt = max - min;
Console.WriteLine($" Разница между максимальным и минимальным числом составляет: {resalt}");