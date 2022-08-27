String s = Console.ReadLine();
int upperCount = 0;
int lowerCount = 0;
for (int i = 0; i < s.Length; i++)
{
    char c = s[i];
    if (Char.IsUpper(c)) { upperCount++; }
    if (Char.IsLower(c)) { lowerCount++; }
}

if (upperCount > lowerCount)
{
    Console.WriteLine(s.ToUpper());
}
else if (lowerCount > upperCount)
{
    Console.WriteLine(s.ToLower());
}
else
{
    Console.WriteLine(s.ToLower());
}
