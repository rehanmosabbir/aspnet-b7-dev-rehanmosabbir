
int a, b;
string[] arr = Console.ReadLine().Split(' ');
a = int.Parse(arr[0]);
b = int.Parse(arr[1]);
for (int i = 1; i <= a; i++)
{
    for (int j = 0; j < b; j++)
    {
        if (i % 4 == 0)
        {
            if (j == 0) Console.Write("#");
            else Console.Write(".");
        }
        else if (i % 4 == 2)
        {
            if (j == b - 1) Console.Write("#");
            else Console.Write(".");
        }
        else
        {
            Console.Write("#");
        }
    }
    Console.WriteLine();
}
