// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}
Console.WriteLine($"Функция Аккермана для чисел ({numberM}, {numberN}) = {AckermannFunction(numberM, numberN)}");