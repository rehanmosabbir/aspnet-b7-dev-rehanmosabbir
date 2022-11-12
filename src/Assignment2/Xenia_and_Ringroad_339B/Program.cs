int n, m;
string[] line = Console.ReadLine().Split(" ");

n = int.Parse(line[0]);
m = int.Parse(line[1]);

int loc = 1;
long ans = 0;

int[] now = new int[m];
string[] arr = Console.ReadLine().Split(" ");

for (int i = 0; i < m; i++)
{
    now[i] = int.Parse(arr[i]);
}
for (int i = 0; i < m; i++)
{
    

    if (now[i] >= loc)
        ans += now[i] - loc;
    else
        ans += n - (loc - now[i]);
    loc = now[i];
}

Console.WriteLine(ans);
