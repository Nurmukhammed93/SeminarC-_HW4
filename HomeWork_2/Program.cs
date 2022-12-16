// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int summa = Sum(number);
Console.WriteLine(summa);

int Sum(int num)
{
    int res = 0;
    for (int i = 1; i < num; i++)
    {
        res += num % 10;
        num = num / 10;

    }
    
    return res;
}
