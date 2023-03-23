// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputUserData(string messageToUser)
{
    int result;
    Console.Write(messageToUser);
    string userAnswer = string.Empty;
    while (!(int.TryParse(Console.ReadLine(), out result) & (result > 0)))
    {
        Console.WriteLine("You must enter an integer greater than 0");
        Console.Write(messageToUser);
    }
    
    return result;
}

void PrintNto1(int num)
{
    Console.Write(num + ", ");
    if (num != 2) PrintNto1(num - 1);
    else Console.WriteLine(num - 1);
    
}

int number = InputUserData("Введите целое число больше 0: ");
Console.Write($"N = {number} -> ");
PrintNto1(number);