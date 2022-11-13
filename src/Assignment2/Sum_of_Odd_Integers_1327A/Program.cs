
long i, j, k;
long n, m, t;

t = long.Parse(Console.ReadLine());
for(i = 0; i < t; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    n = int.Parse(line[0]);
    k = int.Parse(line[1]);
    if (n % 2 == k % 2)
    {
        if (k * k > n) Console.WriteLine("NO");
        else Console.WriteLine("YES");
    }
    else Console.WriteLine("NO");
}
