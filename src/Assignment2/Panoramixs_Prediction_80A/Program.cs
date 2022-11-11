int m, n;
bool f = false;
int[] a = new int[16]{
        2,
        3,
        5,
        7,
        11,
        13,
        17,
        19,
        23,
        29,
        31,
        37,
        41,
        43,
        47,
        0
};

string[] line = Console.ReadLine().Split(" ");
n = int.Parse(line[0]);
m = int.Parse(line[1]);
for (int i = 0; i < 14; i++)
{
    if (a[i] == n)
    {
        if(a[i + 1] == m)
        {
            f = true;
        }
    }
}
if (f)
{  
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
