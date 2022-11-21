// программа, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным
Console.WriteLine("Введите цифру дня недели: ");
int weekDayNum = int.Parse(Console.ReadLine());

if (weekDayNum == 6 || weekDayNum ==7)
{
    Console.WriteLine("Weeeekeend!!!!");
}

else if (weekDayNum < 1 || weekDayNum > 7)
{
    Console.WriteLine("OOops incorrect number!!!!");
}

else 
{
    Console.WriteLine("Weekday!");
}