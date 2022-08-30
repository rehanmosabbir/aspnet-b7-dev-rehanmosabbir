

int n;
n = int.Parse(Console.ReadLine());
int[] score = new int[n];
string[] arr = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
   score[i] = int.Parse(arr[i]);
}
int answer = 0;

for (int i = 0; i < n; i++)
{
    if (i == 0) continue;
    bool isMax = true, isMin = true;
    for (int j = 0; j < i; j++)
    {
        if (score[j] <= score[i])
        {
            isMin = false;
        }
        if (score[j] >= score[i])
        {
            isMax = false;
        }
    }
    if (isMin || isMax)
    {
        answer++;
    }
}

Console.WriteLine(answer);
