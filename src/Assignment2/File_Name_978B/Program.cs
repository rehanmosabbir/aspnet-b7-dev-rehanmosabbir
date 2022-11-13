int len, i, k = 0;
string str;
len = int.Parse(Console.ReadLine());
str = Console.ReadLine();


for (i = 0; i < len - 2; i++)
    if (str[i] == 'x' && str[i + 1] == 'x' && str[i + 2] == 'x')
        ++k;

    

Console.WriteLine(k);