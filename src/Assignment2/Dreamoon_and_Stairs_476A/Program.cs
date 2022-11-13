int x, n, m;
string[] line = Console.ReadLine().Split(" ");
n = int.Parse(line[0]);
m = int.Parse(line[1]);

if (m > n)
    x = -1;
else
{
    if (n % 2 == 0)
        x = n / 2;
    else
        x = (n / 2) + 1;
    while (x % m != 0)
    {
        x++;
    }
}

Console.WriteLine(x);

