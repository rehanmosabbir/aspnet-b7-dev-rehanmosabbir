
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("I hate ");
    }
    else
    {
        Console.Write("I love ");
    }
    if (i != a - 1)
    {
        Console.Write("that ");
    }
    else
    {
        Console.Write("it ");
    }
}
