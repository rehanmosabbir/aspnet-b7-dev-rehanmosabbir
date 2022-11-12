int n;
n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.Write(n - 4);
    Console.Write(" 4");
}
else
{
    Console.Write(n - 9);
    Console.Write(" 9");
}
