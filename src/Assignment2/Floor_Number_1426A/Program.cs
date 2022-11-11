int t, n, x;
t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    n = int.Parse(line[0]);
    x = int.Parse(line[1]);
    int c = 2, ans = 1;
    while (c < n)
    {
        c += x;
        ans++;
    }
    Console.WriteLine(ans);
}
