long t;
t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    long a, b, c, d;
    int count = 0;
    string[] line = Console.ReadLine().Split(" ");
    a = int.Parse(line[0]);
    b = int.Parse(line[1]);
    c = int.Parse(line[2]);
    d = int.Parse(line[3]);
    if (b > a)
    {
        count++;
    }
    if (c > a)
    {
        count++;
    }
    if (d > a)
    {
        count++;
    }
    Console.WriteLine(count);

}
