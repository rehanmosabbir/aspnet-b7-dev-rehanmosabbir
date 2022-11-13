int k;
k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int n;
    n = int.Parse(Console.ReadLine());
    string s, t = "Timur";
    s = Console.ReadLine();
    

    char[] s1 = s.ToCharArray();
    Array.Sort(s1);
    string s2 = new string(s1);


    char[] t1 = t.ToCharArray();
    Array.Sort(t1);
    string t2 = new string(t1);

    if (s2 == t2)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}
