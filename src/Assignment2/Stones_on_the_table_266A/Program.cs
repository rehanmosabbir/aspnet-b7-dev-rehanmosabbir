
string b;
int a, c = 0;

a = int.Parse(Console.ReadLine());
b = Console.ReadLine();

for (int i = 1; i < a; i++)
{
    if ((char)b[i - 1] == (char)b[i])
    {
        c++;
    }
}

Console.WriteLine(c);
