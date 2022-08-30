
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] p = Console.ReadLine().Split(' ');
    int a = int.Parse(p[0]);
    int b = int.Parse(p[1]);
    int quotient = a / b;
    int nextQuotient = quotient + 1;
    int next_a = nextQuotient * b;
    if (a % b == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        int answer = next_a - a;
        Console.WriteLine(answer);
    }

}
