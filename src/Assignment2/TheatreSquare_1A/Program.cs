
string[] line = Console.ReadLine().Split(' ');
int n = int.Parse(line[0]);
int m = int.Parse(line[1]);
int a = int.Parse(line[2]);

long x, y, sum;

x = n / a;
y = m / a;
if (n % a != 0)
{
    x = x + 1;
}

if (m % a != 0)
{
    y = y + 1;
}

sum = x * y;
Console.WriteLine(sum);
