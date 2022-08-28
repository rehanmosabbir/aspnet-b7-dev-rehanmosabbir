
long n, k;
string[] str = Console.ReadLine().Split(' ');
n = long.Parse(str[0]);
k = long.Parse(str[1]);
if (k <= (n + 1) / 2)
{
    Console.WriteLine(k * 2 - 1);  
}
else
{
    Console.WriteLine((k - (n + 1) / 2) * 2);
}