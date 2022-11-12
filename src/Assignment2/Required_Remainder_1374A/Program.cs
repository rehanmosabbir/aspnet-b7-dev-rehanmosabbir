long t;
long x, y, n;
t = long.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    x = long.Parse(line[0]);
    y = long.Parse(line[1]);
    n = long.Parse(line[2]);
    
    long ans = 0;
    ans = n - n % x + y;
    if (ans <= n)
    {
        Console.WriteLine(ans);
    }
    else
    {
        Console.WriteLine((n - n % x - (x - y)));
    }
}
