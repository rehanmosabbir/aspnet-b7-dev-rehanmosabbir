
string a, b = "hello";
int j = 0, pas = 0;
a = Console.ReadLine();
for (int i = 0; i < a.Length; i++)
{
    if (a[i] == b[j])
    {
        j++;
        pas++;

        if (pas == 5)
        {
           break;
        }
    }
}
if (pas == 5)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}
