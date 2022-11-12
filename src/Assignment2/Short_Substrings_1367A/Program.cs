
int t;
t = int.Parse(Console.ReadLine());
for(int i = 0 ; i < t; i++)
{
    string str, ans = null;
    str = Console.ReadLine();
    int n = str.Length;
    for(int j = 0; j < n; j++)
    {
        if(j == 0 || j == n - 1)
        {
            ans += str[j];
        }
        else
        {
            ans += str[j];
            j++;
        }
    }
    Console.WriteLine(ans);

}
