
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int NumA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int NumB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число");
int NumС = int.Parse(Console.ReadLine()!);

int max = 0;

if(NumA > NumB)
{
    max = NumA;
    if(NumA > NumС)
    {
        max = NumA;
    }
    else 
    {
        max = NumС;
    }
}
else if(NumB > NumС)
{
    max = NumB;
}
else
{
    max = NumС;
}


Console.Write("max = ");
Console.Write(max);



