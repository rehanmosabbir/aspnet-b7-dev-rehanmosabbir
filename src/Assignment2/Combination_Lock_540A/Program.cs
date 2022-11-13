int n;
string a, b;
n = int.Parse(Console.ReadLine());
a = Console.ReadLine();
b = Console.ReadLine();
int ans = 0;

for (int i = 0; i < n; i++)
    ans += Math.Min(10 - Math.Abs(a[i] - b[i]), Math.Abs(a[i] - b[i]));

Console.WriteLine(ans);
