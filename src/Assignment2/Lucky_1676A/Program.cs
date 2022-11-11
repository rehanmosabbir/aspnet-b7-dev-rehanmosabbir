int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    string a = Console.ReadLine();
    int j, sumf = 0, suml = 0;
    for(j = 0; j < 3; j++)
    {
        sumf += (a[j] - '0');
    }
    for (j = 3; j < 6; j++)
    {
        suml += (a[j] - '0');
    }
    if(suml == sumf)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
