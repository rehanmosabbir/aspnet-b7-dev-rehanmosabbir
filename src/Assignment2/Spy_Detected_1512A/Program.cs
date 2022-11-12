int t;
t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int n;
    n = int.Parse(Console.ReadLine());
    int[] ar = new int[n];
    string[] line = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; ++j)
    {
        ar[j] = int.Parse(line[j]);
    }
    bool found = false;
    for (int k = 1; k < n - 1; ++k)
    {
        if (ar[k] != ar[k - 1] && ar[k] != ar[k + 1])
        {
            Console.WriteLine(k+1);
            found = true;
        }
    }
    if (!found)
    {
        if (ar[0] != ar[1])
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(n);
        }
    }
}
