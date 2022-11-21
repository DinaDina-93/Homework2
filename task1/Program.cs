//программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int a = num % 100;
int b = num % 10;
int c = (a - b) / 10;

if (num < 100 || num >= 1000)
{
    Console.WriteLine("неправильный ввод!");
}
else 
{
    Console.WriteLine($"второе число - > {c}! ");
}