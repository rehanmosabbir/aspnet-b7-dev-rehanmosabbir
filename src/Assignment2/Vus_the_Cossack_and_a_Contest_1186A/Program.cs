
int n, m, k;
string[] line = Console.ReadLine().Split(" ");
n = int.Parse(line[0]);
m = int.Parse(line[1]);
k = int.Parse(line[2]);

if (n > Math.Min(m, k))
    Console.WriteLine("NO");
else
    Console.WriteLine("YES");



