// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


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

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int M = InputUserData("Enter an integer greater than 0: ");
int N = InputUserData("Enter an integer greater than 0: ");
Console.WriteLine($"M = {M}, N = {N} -> A(m,n) = {Akkerman(M, N)}");
