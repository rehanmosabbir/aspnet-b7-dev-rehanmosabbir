
int noOfProblems = int.Parse(Console.ReadLine());
int[] sum = new int[noOfProblems];
int newSum = 0;

for (int i = 0; i < noOfProblems; i++)
{
    string[] a = Console.ReadLine().Split(' ');

    for (int j = 0; j < a.Length; j++)
    {
        if (int.Parse(a[j]) == 1)
        {
            sum[i]++;
        }
    }
}

for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] >= 2)
    {
        newSum++;
    }
}

Console.WriteLine(newSum);
