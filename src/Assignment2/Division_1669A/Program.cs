int n = int.Parse(Console.ReadLine());
int a;
for(int i = 0; i < n; i++)
{
    a = int.Parse(Console.ReadLine());
    if(a < 1400)
    {
        Console.WriteLine("Division 4");
    }
    else if(a >= 1400 && a < 1600)
    {
        Console.WriteLine("Division 3");
    }
    else if (a >= 1600 && a < 1900)
    {
        Console.WriteLine("Division 2");
    }
    else
    {
        Console.WriteLine("Division 1");
    }
}
