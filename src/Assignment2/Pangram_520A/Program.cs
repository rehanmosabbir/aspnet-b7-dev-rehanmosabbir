int n, i, j, cn = 0;
n = int.Parse(Console.ReadLine());
char[] b = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

string str = Console.ReadLine();

string a = str.ToUpper();

for (i = 0; i < 26; i++)
{
    for (j = 0; j < n; j++)

        if (b[i] == a[j])
        {
            cn++;
            break;
        }

}

if (cn == 26) Console.WriteLine("YES"); 
else Console.WriteLine("NO");
