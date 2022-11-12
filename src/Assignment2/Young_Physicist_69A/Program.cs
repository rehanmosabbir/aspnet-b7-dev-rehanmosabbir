int n, x, y, z, xsum = 0, ysum = 0, zsum = 0;
n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    x = int.Parse(line[0]);
    y = int.Parse(line[1]);
    z = int.Parse(line[2]);
    xsum += x;
    ysum += y;
    zsum += z;
}

if (xsum == 0 && ysum == 0 && zsum == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

