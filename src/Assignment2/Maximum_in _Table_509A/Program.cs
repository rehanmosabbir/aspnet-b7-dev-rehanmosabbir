int a;
int[,] arr = new int[10,10];

a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (i == 0)
        {
            arr[i,j] = 1;
        }
        else if (j == 0)
        {
            arr[i,j] = 1;
        }
        else
        {
            arr[i,j] = arr[i - 1,j] + arr[i,j - 1];
        }
    }
}
Console.WriteLine(arr[a - 1,a - 1]);
