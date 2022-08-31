
int n = int.Parse(Console.ReadLine());
for(int i = n; i > 0; i--)
{
    string s = Console.ReadLine();
    int count = 0;
    int mid = s.Length / 2;
    if (s.Length == 1) Console.WriteLine("NO");
    else if(s.Length % 2 == 0)
    {
        for(int j = 0; j < mid; j++)
        {
            if (s[j] == s[mid + j])
            {
                count++;
            }
        }
        if (count == mid) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
    else Console.WriteLine("NO");
}