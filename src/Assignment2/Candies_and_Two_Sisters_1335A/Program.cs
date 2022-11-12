int t;
double n;
long ans;
t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    ans = 0;
    n = double.Parse(Console.ReadLine());
    ans = (long)Math.Ceiling((n / 2) - 1);
    Console.WriteLine(ans);
}
