
int n, m,i;
string[] str = Console.ReadLine().Split(' ');
n = int.Parse(str[0]);
m = int.Parse(str[1]);
if (n > m)
{
    i = m;
}
else
{
    i = n;
}
if (i % 2 == 0)
{
    Console.WriteLine("Malvika");
}
else
{
    Console.WriteLine("Akshat");
}
