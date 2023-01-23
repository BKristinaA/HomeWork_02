Console.WriteLine("Введите трехзначное число");

int N = 585;
int midel = 0;

while ( N >= 100)
{
    N /= 10;
}
midel = N % 10;

Console.WriteLine(midel);
