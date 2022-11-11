int a, i = 0, last = 0, current = 0;

a = int.Parse(Console.ReadLine());
while (a > 0)
{
    i++;
    current = last + i;
    last = current;
    a -= current;
    if (a < 0)
    {
        i--;
    }
}
Console.WriteLine(i);
