
string s;
char u;
bool c = true;
s = Console.ReadLine();

for (int i = 1; i < s.Length; i++)
{
    if (Char.IsLower(s[i]))
    {
        c = false;
    }
}

if (c == true)
{
    for (int j = 0; j < s.Length; j++)
    {
        if (Char.IsLower(s[j]))
            u = char.ToUpper(s[j]);
        else
            u = char.ToLower(s[j]);
        Console.Write(u);
    }
}
else
    Console.WriteLine(s);
