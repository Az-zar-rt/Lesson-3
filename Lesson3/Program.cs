int x = 11;
int y = 11;
int sum = 0;

Console.WriteLine("Первое число "+x);
Console.WriteLine("Второе число " +y);
if (x > y)
{
    for (int i = y; i < x + 1; i++)
    {
        sum += i;
        Console.WriteLine(sum);
    }
}
else if (y > x)
{
    for (int i = x; i < y + 1; i++)
    {
        sum += i;
        Console.WriteLine(sum);
    }
}
else
{
    x = y;
    sum = x;
    Console.WriteLine(sum);
}
//checked
