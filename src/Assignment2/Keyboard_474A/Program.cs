string solve(string s1, char c)
{
    string s = "qwertyuiopasdfghjkl;zxcvbnm,./";
    string answer=null;
    int len = s1.Length;
    for (int i = 0; i < len; i++)
    {
        int index = s.IndexOf(s1[i]);
        if (c == 'R')
        {
            answer += s[index - 1];

        }
        else
        {
            answer += s[index + 1];
        }

    }
    return answer;

}


string s2;
char c;
c = char.Parse(Console.ReadLine());
s2 = Console.ReadLine();
Console.WriteLine(solve(s2,c));


