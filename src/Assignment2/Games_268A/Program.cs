
int n;
n = int.Parse(Console.ReadLine());

int number = 0;
int[] h = new int[n];
int[] a = new int[n];


for (int i = 0; i < n; ++i)
{
    string[] line = Console.ReadLine().Split(" ");
    h[i] = int.Parse(line[0]);
    a[i] = int.Parse(line[1]);
    for (int j = 0; j < i; ++j)
    {
        if (h[i] == a[j])
        {
            number += 1;
        }
        if (a[i] == h[j])
        {
            number += 1;
        }
    }
}
Console.WriteLine(number);
