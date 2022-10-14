// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int temp = numberOne;
if (numberOne > numberTwo)
{
    numberOne = numberTwo;
    numberTwo = temp;
}
SummaNumbers(numberOne, numberTwo, temp = 0);

void SummaNumbers(int numberOne, int numberTwo, int sum)
{
    if (numberOne > numberTwo) 
    {
        Console.WriteLine("Сумма чисел от M до N = " + sum);
        return;
    }
    sum = sum + (numberOne++);
    SummaNumbers(numberOne, numberTwo, sum);
}