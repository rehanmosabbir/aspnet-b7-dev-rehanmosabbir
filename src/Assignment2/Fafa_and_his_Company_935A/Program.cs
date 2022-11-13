int i, n, cnt = 1;
n = int.Parse(Console.ReadLine());
for (i = 2; i * i < n; i++)
{
    if (n % i == 0)
        cnt += 2;
}
if ((double)Math.Sqrt(n) == (int)Math.Sqrt(n))
    cnt++;

Console.WriteLine(cnt);
