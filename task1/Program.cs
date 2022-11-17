//программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num / 100;
int b = num / 10;
int c = num % 10;
int d = b % 10;

Console.WriteLine($"{d} -> Вторая цифра"); 