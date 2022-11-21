//программа, которая выводит третью цифру заданного числа или сообщает, что ее нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}

if (ThirdDigit(num) == -1)
{
Console.WriteLine("There is no third digit");
}
else
{
Console.WriteLine($"Third Digit: {ThirdDigit(num)}");
}