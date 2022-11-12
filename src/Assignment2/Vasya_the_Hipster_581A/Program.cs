int a, b;
string[] line = Console.ReadLine().Split(" ");
a = int.Parse(line[0]);
b = int.Parse(line[1]);

if (a >= b)
{
    a -= b;
    a /= 2;
    Console.Write(b);
    Console.Write(' ');
    Console.Write(a);


}
else
{
    b -= a;
    b /= 2;
    Console.Write(a);
    Console.Write(' ');
    Console.Write(b);
}
