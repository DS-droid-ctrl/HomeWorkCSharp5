// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int num = 4;
int min = 100;
int max = 999;

int[] myRandomArray = CreateRandomArray(num, min, max);
Console.WriteLine($" [ {String.Join(" , ", myRandomArray)} ] ");

int sum = 0;
for (int i = 0; i < myRandomArray.Length; i++)
{
    if (myRandomArray[i] % 2 == 0)
    {
        sum += 1;
    }

}
Console.WriteLine($" Количество четных чисел в массиве: {sum}");