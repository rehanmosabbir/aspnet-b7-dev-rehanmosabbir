int[] arr = new int[1001];

int j = 1;
for (int i = 1; i <= 1666; i++)
{
    if (i % 3 != 0)
    {
        if (i % 10 != 3)
        {
            arr[j] = i;
            j = j + 1;
        }

    }

}

int t;
t = int.Parse(Console.ReadLine());
int k;
for(int l = 0; l < t; l++)
{
    k = int.Parse(Console.ReadLine());
    Console.WriteLine(arr[k]);
}
