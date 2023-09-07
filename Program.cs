// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// System.Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// int startNum = N;
// int endNum = 1;

// System.Console.WriteLine(PrintNumbers(startNum, endNum));

// string PrintNumbers(int start, int end)
// {
//     if (start == end )
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbers(start - 1 , end));
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.WriteLine("Введите число M : ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число N : ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int SumEl(int num2, int num1)
// {
//     if (num2 == num1) return num2;
//     else return SumEl(num2 + 1, num1) + num2;
// }

// System.Console.WriteLine(SumEl(num1, num2));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(M,N);
void AkkermanFunction(int M, int N)
{
    Console.Write(Akkerman(M, N)); 
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}