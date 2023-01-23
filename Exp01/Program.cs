Console.WriteLine("Введите трехзначное число");

int numbers = 585;
int midel = 0;

while (numbers >= 100)
{
    numbers /= 10;
}
midel = numbers % 10;

Console.WriteLine(midel);
