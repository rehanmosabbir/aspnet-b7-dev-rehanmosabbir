
int a, j = 0, b = 0;
a = int.Parse(Console.ReadLine());
int[] arr = new int[a];
string[] str = Console.ReadLine().Split(' ');
for (int i = 0; i < a; i++)
{
    arr[i] = int.Parse(str[i]);
    
    if (arr[i] % 2 == 0)
    {
        j++;
    }
    else
    {
        b++;
    }
}
if (j > b)
{
    for (int i = 0; i < a; i++)
    {
        if (arr[i] % 2 != 0)
        {
            Console.WriteLine(i+1);
            break;
        }
    }
}
else
{
    for (int i = 0; i < a; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Console.WriteLine(i+1);
            break;
        }
    }
}
