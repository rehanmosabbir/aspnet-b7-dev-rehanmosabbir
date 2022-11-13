int t;
t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int a, b, c;
    string[] line = Console.ReadLine().Split(" ");
    a = int.Parse(line[0]);
    b = int.Parse(line[1]);
    c = int.Parse(line[2]);
    if(a == b + c || b == c + a || c == a + b)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
