Console.WriteLine("Введите число: ");
int number = 8;
if (1 <= number && number <= 7)
{
    if (number > 5)
    {
        Console.Write("Выходной день");
    }
    else
    {
        Console.Write("Рабочий день");
    }
}
else
{
    Console.Write("К сожалению в календаре нет заданного дня");
}
