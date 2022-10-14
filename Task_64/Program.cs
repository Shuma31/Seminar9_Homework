// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


    Console.Write("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    NaturalNumbers(number);

    void NaturalNumbers(int number)
    {
        if (number == 0) return;
        Console.Write(" " + number);
        NaturalNumbers(number - 1);
        
    }
    Console.WriteLine();
