// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

using static System.Console;

Clear();
WriteLine("Введите числа: ");
int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());
int c = Convert.ToInt32(ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
WriteLine($"Максимально число: {max}.");