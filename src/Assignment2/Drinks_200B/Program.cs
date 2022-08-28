

int n = int.Parse(Console.ReadLine());
string[] p = Console.ReadLine().Split(' ');

int sum = 0;

for (int i = 0; i < p.Length; i++)
{
    sum += int.Parse(p[i]);
}

Console.WriteLine((decimal)sum / n);
