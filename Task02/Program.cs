//Напишите программу, которая на вход принимает числа и выдаёт, какое число большее,
//а какое меньшее.
using static System.Console;

Clear();
WriteLine("Введите числа: ");
int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());
if (a > b)
{
    WriteLine($"Наибольшее число равно {a}, а наименьшее равно {b}.");
}
else
{
    WriteLine($"Наибольшее число равно {b}, а наименьшее равно {a}.");
}