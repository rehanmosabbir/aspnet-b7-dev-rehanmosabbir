int a, b, div, mod;
string[] line = Console.ReadLine().Split(" ");
a = int.Parse(line[0]);
b = int.Parse(line[1]);
int sum = a;
while (a >= b)
{
    div = (a / b);
    sum = sum + div;
    mod = (a % b);
    a = (div + mod);
}
Console.WriteLine(sum);
