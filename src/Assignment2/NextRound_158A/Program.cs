
string[] arr = Console.ReadLine().Split(' ');
int n = int.Parse(arr[0]);
int k = int.Parse(arr[1]);
string[] scores = Console.ReadLine().Split(' ');
int x = int.Parse(scores[k - 1]);
int sum = 0;

for (int i = 0; i < scores.Length; i++)
{
    if (int.Parse(scores[i]) >= x && int.Parse(scores[i]) > 0)
    {
        sum++;
    }
}

Console.WriteLine(sum);