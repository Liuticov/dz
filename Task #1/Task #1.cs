

int number = new Random().Next(10, 100);
int first = number / 10;
int second = number % 10;
Console.WriteLine("Случайное двузначное число: " + number);
if (first > second)
    Console.Write("Большее число из диапозона: " + first);
else
    Console.Write("Большее число из диапозона: " + second);