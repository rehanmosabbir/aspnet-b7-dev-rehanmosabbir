long t;
t = int.Parse(Console.ReadLine());

for(int m = 0; m < t;m++)
{
    int[] c = new int[50];
    string a, b;
    int p = 0;
    int q = 0;
    a = Console.ReadLine();
    b = Console.ReadLine();

    int len = b.Length;
    for(int j = 0; j < len; j++)
    {
        for(int i = 0; i < 26; i++)
        {
            if (b[j] == a[i])
            {
                c[j] = i;
            }
        }
    }

    int sum = 0;
    for(int k = 0; k < len - 1; k++)
    {
        sum = sum + Math.Abs(c[k+1] - c[k]);
    }

    Console.WriteLine(sum);

}
