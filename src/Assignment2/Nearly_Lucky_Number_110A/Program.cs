
string str = Console.ReadLine();

int count = 0;

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == '4' || str[i] == '7')
    {
        count++;
    }

}
if (count == 4 || count == 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");