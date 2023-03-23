// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumNumbers(int m, int n)
{
    int result = 0;
    if (n == m) return n;
    return m + SumNumbers(m + 1, n);
    
}

int M = InputUserData("Введите целое число больше 0: ");
int N = InputUserData($"Введите целое число больше {M}: ");
Console.WriteLine($"M = {M}, N = {N} -> {SumNumbers(M, N)}");
