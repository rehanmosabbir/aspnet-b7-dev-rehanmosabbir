int[] p = new int[6];


int a, b, c, i;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

p[0] = a * b + c;
p[1] = a + b * c;
p[2] = a * (b + c);
p[3] = (a + b) * c;
p[4] = a + b + c;
p[5] = a * b * c;
Array.Sort(p);
Console.WriteLine(p[5]);
