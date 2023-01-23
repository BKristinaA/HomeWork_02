Console.WriteLine("Введите число: ");

int number = 698;

while (number >= 1000)
{
    number /= 10;
}
if (number < 100)
{
    Console.Write("Третьего числа нет ");
}
else
{
    number = number % 10;
    Console.WriteLine(number);
}
