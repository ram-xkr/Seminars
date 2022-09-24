// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N
using static System.Console;

WriteLine("Введите число: ");
int N = Convert.ToInt32(ReadLine());
int n1 = 2;
while (n1 <= N)
{
    Write($"{n1} ");
    n1 = n1 +2;
}