int a;
a = int.Parse(Console.ReadLine());
int[] arr = new int[a];
string[] str = Console.ReadLine().Split(' ');
for (int i = 0; i < a; i++)
{
    arr[i] = int.Parse(str[i]);
}
for (int j = 1; j <= a; j++)
{
    for (int i = 0; i < a; i++)
    {
        if (arr[i] == j)
        {
            Console.Write(i+1);
            Console.Write(" ");
        }
    }
}
