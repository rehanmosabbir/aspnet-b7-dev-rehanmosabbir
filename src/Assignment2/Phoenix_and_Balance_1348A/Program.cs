int t, n;
int[] a = new int[10000];
t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    long ans = 0, sum1 = 0, sum2 = 0;
    int div = 0;
    n = int.Parse(Console.ReadLine());
    int k = 0;
    for (int j = 1; j <= n; j++)
    {
        a[k++] = (int)Math.Pow(2, j);
    }

    div = n / 2;
    sum1 = a[n - 1];
    for (int q = 0; q <= div - 2; q++)
    {
        sum1 += a[q];
    }
    for (int r = div - 1; r < n - 1; r++)
    {
        sum2 += a[r];
    }

    ans = Math.Abs(sum1 - sum2);
    Console.WriteLine(ans);
}