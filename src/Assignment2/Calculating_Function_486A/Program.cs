
long n = long.Parse(Console.ReadLine());
long a;

if (n % 2 == 0) a = n / 2;
else a = ((n + 1) / 2) * (-1);
Console.WriteLine(a);