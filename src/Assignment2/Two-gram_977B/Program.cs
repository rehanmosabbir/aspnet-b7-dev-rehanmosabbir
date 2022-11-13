string str;

int call(string sub)
{
    int cnt = 0, maxi = 0;

    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] == sub[0] && str[i + 1] == sub[1])
            cnt++;

    }
    return cnt;
}


int maxi = 0, n;
string gram = null;

n = int.Parse(Console.ReadLine());
str = Console.ReadLine();

for (int i = 0; i < str.Length - 1; i++)
{
    string sub = str.Substring(i, 2); //substr(index, length)

    int temp = call(sub);

    if (temp > maxi)
    {
        maxi = temp;
        gram = sub;
    }
}

Console.WriteLine(gram);


