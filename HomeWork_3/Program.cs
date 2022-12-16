// Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n
// и заполняет его случайными числами в диапазоне от min до max.
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Мin");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Мax");
int max = int.Parse(Console.ReadLine()!);

int[] array = GenerateArray(n, min, max);

int[] GenerateArray(int N, int Min, int Max)
{
    int[] array = new int [N];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(Min, Max);
    }

    return array;

} 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }


