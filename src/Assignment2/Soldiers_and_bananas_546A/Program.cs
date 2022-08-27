
string[] str = Console.ReadLine().Split(' ');
int k = int.Parse(str[0]);
int n = int.Parse(str[1]);
int w = int.Parse(str[2]);
int price = 0;
for (int i = 1; i <= w; i++)
{
    price = price + (i * k);
}
if (price < n || price == n)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(price - n);
}