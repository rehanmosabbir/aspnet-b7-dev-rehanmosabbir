int n, k, l, c, d, p, nl, np;


string[] line = Console.ReadLine().Split(" ");
n = int.Parse(line[0]);
k = int.Parse(line[1]);
l = int.Parse(line[2]); 
c = int.Parse(line[3]);
d = int.Parse(line[4]);
p = int.Parse(line[5]);
nl = int.Parse(line[6]);
np = int.Parse(line[7]);

Console.WriteLine(Math.Min(Math.Min(k * l / nl, c * d), p / np) / n);

