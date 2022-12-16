// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите число А");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine()!);

int Pow = Power(numA, numB);
Console.WriteLine(Pow);

int Power(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
