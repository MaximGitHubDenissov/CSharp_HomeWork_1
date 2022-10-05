// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Веедите первое число");
int NumA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int NumB = int.Parse(Console.ReadLine()!);

if (NumA > NumB)
{
    Console.Write("max = ");
    Console.Write(NumA);
}
else
{
    Console.Write("max = ");
    Console.Write(NumB);
}