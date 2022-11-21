//программа, которая выводит третью цифру заданного числа или сообщает, что ее нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


int thirdOne(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}