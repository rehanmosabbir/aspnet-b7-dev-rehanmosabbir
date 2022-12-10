int t;
t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    long a, b, n;
    string[] line = Console.ReadLine().Split(' ');
    a = int.Parse(line[0]);
    b = int.Parse(line[1]);
    n = int.Parse(line[2]);

    long sum = 0, c = 0;
    while (sum <= n)
    {
        if (a > b)
        {
            b += a;
            sum = b;
            c++;
        }
        else
        {
            a += b;
            sum = a;
            c++;
        }
        if (sum > n)
        {
            break;
        }
    }
    Console.WriteLine(c);
}
