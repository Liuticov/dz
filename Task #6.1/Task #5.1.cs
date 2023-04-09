// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());



bool OutputKratnoLi(int a);
{
    return a  == Math.Pow(b, 2) || b  == Math.Pow(a, 2);
}
Console.WriteLine(OutputKratnoLi(a));