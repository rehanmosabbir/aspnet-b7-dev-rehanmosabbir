int n, e;
int p = 0, c = 0;
n = int.Parse(Console.ReadLine());

string[] str = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    e = int.Parse(str[i]);
    if (e == -1)
    {
        if (p > 0)
            p--;
        else
            c++;
    }
    else
        p += e;
}

Console.WriteLine(c);
